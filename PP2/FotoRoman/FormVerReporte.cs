using CapaEntidad;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoRoman
{
    public partial class FormVerReporte : Form
    {
        public FormVerReporte()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar el usuario
                string usuarioNombre = textBox1.Text.Trim();
                CNUsuario cnUsuario = new CNUsuario(); // Instancia de la clase CNUsuario
                Usuario? usuario = cnUsuario.Listar().FirstOrDefault(u => u.NOMBRE.Equals(usuarioNombre, StringComparison.OrdinalIgnoreCase));

                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ajustar el rango de fechas
                DateTime fechaDesde = dtpFechaDesde.Value.Date; // Inicio del día seleccionado
                DateTime fechaHasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1); // Final del día seleccionado

                // Obtener los pedidos del usuario en el rango de fechas
                var pedidos = CNPedido.ObtenerPedidosPorUsuarioYFechas(usuario.IDUSUARIO, fechaDesde, fechaHasta);

                // Si no hay pedidos, mostrar mensaje
                if (pedidos == null || pedidos.Count == 0)
                {
                    MessageBox.Show("No se encontraron pedidos para el usuario en el rango de fechas especificado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar los datos en el DataGridView
                var detalles = pedidos.Select(p => new
                {
                    p.IDPEDIDO,
                    p.TOTAL,
                    FECHA = p.FECHAPEDIDO.ToString("dd/MM/yyyy HH:mm:ss") // Mostrar fecha y hora
                }).ToList();

                dataGridViewPedidos.DataSource = detalles;

                // Sumar los totales y mostrar en el label
                decimal total = detalles.Sum(p => p.TOTAL);
                lblTotal.Text = $"Total: {total:C2}"; // Formato de moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FormVerReporte_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de CNUsuario
                CNUsuario cnUsuario = new CNUsuario();

                // Crear un objeto AutoCompleteStringCollection
                AutoCompleteStringCollection autoCompleteUsuarios = new AutoCompleteStringCollection();

                // Obtener los nombres de los usuarios desde la base de datos
                var usuarios = cnUsuario.Listar();
                foreach (var usuario in usuarios)
                {
                    autoCompleteUsuarios.Add(usuario.NOMBRE);
                }

                // Configurar las propiedades de autocompletar del textBox1
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = autoCompleteUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el autocompletado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPedidos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para generar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ruta para guardar el archivo PDF
                string rutaPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReportePedidos.pdf");

                // Crear el documento PDF
                using (FileStream stream = new FileStream(rutaPDF, FileMode.Create))
                {
                    Document documento = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(documento, stream);

                    documento.Open();

                    // Título del reporte
                    Paragraph titulo = new Paragraph("Reporte de Pedidos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 20;
                    documento.Add(titulo);

                    // Subtítulo con información del usuario y fechas
                    Paragraph info = new Paragraph($"Usuario: {textBox1.Text}\n" +
                                                    $"Desde: {dtpFechaDesde.Value:dd/MM/yyyy}\n" +
                                                    $"Hasta: {dtpFechaHasta.Value:dd/MM/yyyy}\n",
                                                    FontFactory.GetFont(FontFactory.HELVETICA, 12));
                    info.Alignment = Element.ALIGN_LEFT;
                    info.SpacingAfter = 20;
                    documento.Add(info);

                    // Crear la tabla con los datos
                    PdfPTable tabla = new PdfPTable(3);
                    tabla.WidthPercentage = 100;
                    tabla.SetWidths(new float[] { 1, 1, 1 }); // Proporción de las columnas

                    // Encabezados de la tabla
                    tabla.AddCell(new PdfPCell(new Phrase("ID Pedido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase("Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase("Fecha", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { HorizontalAlignment = Element.ALIGN_CENTER });

                    // Agregar las filas del DataGridView al PDF
                    foreach (DataGridViewRow fila in dataGridViewPedidos.Rows)
                    {
                        if (fila.Cells["IDPEDIDO"].Value != null) tabla.AddCell(fila.Cells["IDPEDIDO"].Value.ToString());
                        if (fila.Cells["TOTAL"].Value != null) tabla.AddCell(fila.Cells["TOTAL"].Value.ToString());
                        if (fila.Cells["FECHA"].Value != null) tabla.AddCell(fila.Cells["FECHA"].Value.ToString());
                    }

                    documento.Add(tabla);

                    // Agregar el total al final
                    Paragraph total = new Paragraph($"\nTotal: {lblTotal.Text}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                    total.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(total);

                    documento.Close();
                    writer.Close();
                }

                // Abrir el PDF generado
                MessageBox.Show($"Reporte generado exitosamente en:\n{rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
