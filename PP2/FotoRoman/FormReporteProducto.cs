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
            // Llenar el ComboBox de meses
            cmbMeses.Items.AddRange(new string[]
            {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            cmbMeses.SelectedIndex = DateTime.Now.Month - 1; // Selecciona el mes actual por defecto

            // Llenar el ComboBox de años
            int anioActual = DateTime.Now.Year;
            for (int i = anioActual - 5; i <= anioActual; i++) // Últimos 5 años
            {
                comboBoxAnio.Items.Add(i);
            }
            comboBoxAnio.SelectedItem = anioActual; // Selecciona el año actual por defecto

            // Cargar datos iniciales
            CargarDatos(DateTime.Now.Month, anioActual);
        }

        private void CargarDatos(int mes, int anio)
        {
            try
            {
                // Obtener datos desde la Capa de Negocio
                datosProductos = CNProducto.ObtenerTop10ProductosPorMes(mes, anio);

                if (datosProductos == null || datosProductos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos más vendidos para el mes y año seleccionados.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Obtener el año seleccionado del ComboBox de años
                int anioSeleccionado = int.Parse(comboBoxAnio.SelectedItem.ToString());

                // Obtener los datos desde la Capa de Negocio con mes y año
                datosProductos = CNProducto.ObtenerTop10ProductosPorMes(mes, anioSeleccionado);

                if (datosProductos == null || datosProductos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos más vendidos para el mes y año seleccionados.",
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
            if (cmbMeses.SelectedIndex >= 0 && comboBoxAnio.SelectedItem != null)
            {
                int mesSeleccionado = cmbMeses.SelectedIndex + 1; // Índice del mes (0 = Enero)
                int anioSeleccionado;

                // Validar que el año sea válido
                if (int.TryParse(comboBoxAnio.SelectedItem.ToString(), out anioSeleccionado))
                {
                    CargarDatos(mesSeleccionado, anioSeleccionado); // Llama a CargarDatos con mes y año
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // MessageBox.Show("Selecciona un mes y un año antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void FormReporteProducto_Paint(object sender, PaintEventArgs e)
        {
            if (datosProductos == null || datosProductos.Count == 0) return;

            Graphics g = e.Graphics;

            // Configuración inicial
            int margenIzquierdo = 50;
            int margenInferior = 100;
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
            g.DrawString("Productos Más Vendidos", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, margenIzquierdo + 350, 10);



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesSeleccionado = cmbMeses.SelectedIndex + 1; // Índice del mes
            int anioSeleccionado = int.Parse(comboBoxAnio.SelectedItem.ToString()); // Año seleccionado

            if (mesSeleccionado > 0 && mesSeleccionado <= 12)
            {
                CargarDatos(mesSeleccionado, anioSeleccionado); // Actualiza los datos
            }
        }
    }
}