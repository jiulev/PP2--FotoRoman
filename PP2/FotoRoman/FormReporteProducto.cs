using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FotoRoman
{
    public partial class FormReporteProducto : Form
    {
        private List<(string NombreProducto, int CantidadVendida)> datosProductos;

        public FormReporteProducto()
        {
            InitializeComponent();
        }

        private void FormReporteProducto_Load(object sender, EventArgs e)
        {
            int mesActual = DateTime.Now.Month; // Obtener el mes actual
            CargarDatos(mesActual);

            this.Invalidate(); // Redibujar el formulario
                               // Llenar el ComboBox con los nombres de los meses
            cmbMeses.Items.AddRange(new string[]
            {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            cmbMeses.SelectedIndex = DateTime.Now.Month - 1; // Selecciona el mes actual por defecto
        }
        private void CargarDatos(int mes)
        {
            try
            {
                // Obtener datos desde la Capa de Negocio
                datosProductos = CNProducto.ObtenerTop10ProductosPorMes(mes);

                if (datosProductos == null || datosProductos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos más vendidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Invalidate(); // Redibujar el gráfico
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGraficoProductos(int mes)
        {
            try
            {
                // Obtener los datos desde la Capa de Negocio
                datosProductos = CNProducto.ObtenerTop10ProductosPorMes(mes);

                if (datosProductos == null || datosProductos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos más vendidos para el mes seleccionado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Forzar el redibujado del gráfico
                this.Refresh(); // Refresca todo el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesSeleccionado = cmbMeses.SelectedIndex + 1; // Índice empieza en 0
            CargarGraficoProductos(mesSeleccionado);
        }


        private void FormReporteProducto_Paint(object sender, PaintEventArgs e)
        {
            if (datosProductos == null || datosProductos.Count == 0) return;

            Graphics g = e.Graphics;

            // Configuración inicial
            int margenIzquierdo = 50;
            int margenInferior = 50;
            int alturaMaxima = 300;
            int anchoBarra = 50;
            int espacioEntreBarras = 20;

            // Encontrar el máximo valor para escalar el gráfico
            int maximo = 0;
            foreach (var dato in datosProductos)
                if (dato.CantidadVendida > maximo) maximo = dato.CantidadVendida;

            // Dibujar ejes X e Y
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, margenIzquierdo, margenInferior, margenIzquierdo, margenInferior + alturaMaxima);
            g.DrawLine(pen, margenIzquierdo, margenInferior + alturaMaxima, margenIzquierdo + 700, margenInferior + alturaMaxima);

            // Dibujar barras y etiquetas
            Brush brush = Brushes.Gray; //color barras

            Font font = new Font("Arial", 8);
            int xActual = margenIzquierdo + 20;

            foreach (var dato in datosProductos)
            {
                int alturaBarra = (int)((double)dato.CantidadVendida / maximo * alturaMaxima);

                // Dibujar barra
                g.FillRectangle(brush, xActual, margenInferior + alturaMaxima - alturaBarra, anchoBarra, alturaBarra);

                // Truncar el nombre a las primeras 8 letras
                string nombreCorto = dato.NombreProducto.Length > 8 ? dato.NombreProducto.Substring(0, 8) + "..." : dato.NombreProducto;

                // Etiqueta del producto y valor
                g.DrawString(nombreCorto, font, Brushes.Black, xActual, margenInferior + alturaMaxima + 5);
                g.DrawString(dato.CantidadVendida.ToString(), font, Brushes.Black, xActual, margenInferior + alturaMaxima - alturaBarra - 15);

                xActual += anchoBarra + espacioEntreBarras;
            }



            // Título del gráfico
            g.DrawString("Top Productos Más Vendidos", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, margenIzquierdo + 300, 10);



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
