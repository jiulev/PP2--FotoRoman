using CapaEntidad;
using CapaNegocio;
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
    public partial class FormVerPago : Form
    {
        public FormVerPago()
        {
            InitializeComponent();
        }

        private void MostrarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.oCliente == null)
                {
                    MessageBox.Show("No se encontraron datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textBoxIdPedido.Text = pedido.IDPEDIDO.ToString();
                comboBoxClientes.Text = pedido.oCliente.NOMBRE;

                textBoxDatosCliente.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                textBoxDatosCliente.Text = $"Correo: {pedido.oCliente.CORREO}\n" +
                                           $"Localidad: {pedido.oCliente.LOCALIDAD}\n" +
                                           $"Provincia: {pedido.oCliente.PROVINCIA}";

                // Asignar datos al DataGridView de pagos
                dataGridViewPagos.DataSource = CNPedido.ObtenerPagosDelPedido(pedido.IDPEDIDO);
                dataGridViewPagos.AutoResizeColumns();
                dataGridViewPagos.AutoResizeRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxIdPedido.Text))
                {
                    int idPedido = Convert.ToInt32(textBoxIdPedido.Text);
                    Pedido? pedido = CNPedido.BuscarPedidoPorId(idPedido);

                    if (pedido != null)
                    {
                        MostrarPedido(pedido);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el pedido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (!string.IsNullOrWhiteSpace(comboBoxClientes.Text))
                {
                    List<Pedido> pedidos = CNPedido.BuscarPedidosPorNombreCliente(comboBoxClientes.Text);

                    if (pedidos.Count == 1)
                    {
                        MostrarPedido(pedidos[0]);
                    }
                    else if (pedidos.Count > 1)
                    {
                        MessageBox.Show("Hay múltiples coincidencias. Por favor, ingrese el ID del pedido para detalles específicos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron coincidencias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el ID del pedido o seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxIdPedido.Text))
                {
                    MessageBox.Show("Primero debes buscar un pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPedido = Convert.ToInt32(textBoxIdPedido.Text);
                Pedido? pedido = CNPedido.BuscarPedidoPorId(idPedido);

                if (pedido == null)
                {
                    MessageBox.Show("No se encontró el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Definir la ruta del archivo CSV
                string rutaCSV = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Pagos_Pedido_{idPedido}.csv");

                // Crear el contenido del archivo CSV
                var sb = new StringBuilder();
                sb.AppendLine("IDPago,Monto,Fecha,MetodoPago");

                foreach (var pago in CNPedido.ObtenerPagosDelPedido(pedido.IDPEDIDO))
                {
                    sb.AppendLine($"{pago.IDPAGO},{pago.MONTOPAGO:F2},{pago.FECHAPAGO},{pago.METODOPAGO}");
                }

                // Guardar el archivo CSV
                File.WriteAllText(rutaCSV, sb.ToString(), Encoding.UTF8);

                // Mostrar mensaje de éxito
                MessageBox.Show($"Archivo generado exitosamente en:\n{rutaCSV}", "Archivo Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaCSV,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar todos los campos del formulario
                textBoxIdPedido.Clear();
                comboBoxClientes.SelectedIndex = -1;
                textBoxDatosCliente.Clear();

                dataGridViewPagos.DataSource = null;

                MessageBox.Show("Formulario limpiado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVerPago_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de clientes desde la capa de negocio
                var clientes = CNPedido.ListarTodosLosClientes();

                // Configurar el comboBoxClientes
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "NOMBRE";
                comboBoxClientes.ValueMember = "IDCliente";
                comboBoxClientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

