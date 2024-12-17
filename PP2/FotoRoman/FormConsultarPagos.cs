using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio; // Referencia a la capa de negocio
using CapaEntidad;

using iTextSharp.text.pdf;
using iTextSharp.text;

namespace FotoRoman
{
    public partial class FormConsultarPagos : Form
    {
        public FormConsultarPagos()
        {
            InitializeComponent();
        }

        private void FormVerPagos_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar la lista de clientes
                var clientes = CNPedido.ListarTodosLosClientes();
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "NOMBRE";
                comboBoxClientes.ValueMember = "IDCliente";
                comboBoxClientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxIdPedido.Text, out int idPedido))
                {
                    var pagos = CNPedido.ObtenerPagosDelPedido(idPedido);

                    if (pagos != null && pagos.Count > 0)
                    {
                        dataGridViewPagos.DataSource = pagos;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron pagos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewPagos.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un ID de pedido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIdPedido.Clear();
            comboBoxClientes.SelectedIndex = -1;
            dataGridViewPagos.DataSource = null;
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void button1_Click(object sender, EventArgs e)
{
    try
    {
        if (string.IsNullOrWhiteSpace(textBoxIdPedido.Text))
        {
            MessageBox.Show("Primero debes buscar un pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int idPedido = Convert.ToInt32(textBoxIdPedido.Text);
        List<Pago> pagos = CNPedido.ObtenerPagosDelPedido(idPedido);

        if (pagos == null || pagos.Count == 0)
        {
            MessageBox.Show("No se encontraron pagos para este pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Definir la ruta del archivo PDF
        string rutaPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Pagos_{idPedido}.pdf");

        // Crear el documento PDF
        using (Document documento = new Document(PageSize.A4, 36, 36, 36, 36))
        {
            PdfWriter.GetInstance(documento, new FileStream(rutaPDF, FileMode.Create));
            documento.Open();

            // Agregar logo
            string logoPath = @"C:\Users\Usuario\Desktop\ISSD\2022 SEGUNDO SEMESTRE\PP1\imagens\roman.png";
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.Alignment = Element.ALIGN_RIGHT;
                logo.ScaleToFit(230, 150);
                documento.Add(logo);
            }

            documento.Add(new Paragraph("\n"));
            documento.Add(new Paragraph("Detalle de Pagos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
            documento.Add(new Paragraph("\n"));
                    // Agregar ID del pedido
                    documento.Add(new Paragraph($"\nID del Pedido: {idPedido}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                    documento.Add(new Paragraph("\n")); // Espaciado adicional


                    // Crear la tabla de pagos
                    PdfPTable tablaPagos = new PdfPTable(3); // 3 columnas
            tablaPagos.WidthPercentage = 100;

            // Encabezados de la tabla
            tablaPagos.AddCell(CrearCelda("Fecha de Pago", true));
            tablaPagos.AddCell(CrearCelda("Monto", true));
            tablaPagos.AddCell(CrearCelda("Método de Pago", true));

            // Llenar la tabla con los datos de los pagos
            foreach (var pago in pagos)
            {
                tablaPagos.AddCell(CrearCelda(pago.FECHAPAGO.ToString("dd/MM/yyyy")));
                tablaPagos.AddCell(CrearCelda($"${pago.MONTOPAGO:F2}"));
                tablaPagos.AddCell(CrearCelda(pago.METODOPAGO));
            }

            documento.Add(tablaPagos);

            documento.Close();

            MessageBox.Show($"PDF generado correctamente en: {rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = rutaPDF,
                UseShellExecute = true
            });
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

// Método auxiliar para crear celdas



        // Método auxiliar para crear celdas
        private PdfPCell CrearCelda(string texto, bool esEncabezado = false)
        {
            var fuente = esEncabezado ? FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12) : FontFactory.GetFont(FontFactory.HELVETICA, 12);
            var celda = new PdfPCell(new Phrase(texto, fuente))
            {
                Border = PdfPCell.BOX,
                Padding = 5,
                HorizontalAlignment = Element.ALIGN_LEFT
            };
            return celda;
        }

    }
}
