using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;




namespace FotoRoman
{
    public partial class FormVerPedido : Form
    {
        public FormVerPedido()
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

                var detalles = CNPedido.ObtenerDetallesDelPedido(pedido.IDPEDIDO);

                // Transformar datos a una lista plana
                var detallesPlano = detalles.Select(detalle => new
                {
                    Producto = detalle.oProducto.Nombre, // Acceder directamente al nombre del producto
                    Cantidad = detalle.CANTIDAD,
                    PrecioUnitario = detalle.PRECIOUNITARIO,
                    Subtotal = detalle.SUBTOTAL
                }).ToList();

                // Asignar datos al DataGridView
                dataGridViewDetallePedido.DataSource = detallesPlano;

                // Configuración de pagos
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
                string rutaCSV = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Pedido_{idPedido}.csv");

                // Crear el contenido del archivo CSV
                var sb = new StringBuilder();

                // Encabezados de cliente
                sb.AppendLine("Detalle del Pedido");
                sb.AppendLine($"Cliente,{pedido.oCliente?.NOMBRE ?? "Sin Nombre"}");
                sb.AppendLine($"Correo,{pedido.oCliente?.CORREO ?? "Sin Correo"}");
                sb.AppendLine($"Localidad,{pedido.oCliente?.LOCALIDAD ?? "Sin Localidad"}");
                sb.AppendLine($"Provincia,{pedido.oCliente?.PROVINCIA ?? "Sin Provincia"}");

                sb.AppendLine(); // Línea vacía

                // Encabezados de tabla de productos
                sb.AppendLine("Producto,Cantidad,Precio Unitario,Subtotal");

                // Detalles del pedido
                foreach (var detalle in CNPedido.ObtenerDetallesDelPedido(pedido.IDPEDIDO))
                {
                    string producto = detalle.oProducto?.Nombre ?? "Sin Nombre";
                    int cantidad = detalle.CANTIDAD;
                    decimal precioUnitario = detalle.PRECIOUNITARIO;
                    decimal subtotal = detalle.SUBTOTAL;

                    sb.AppendLine($"{producto},{cantidad},{precioUnitario:F2},{subtotal:F2}");
                }

                // Total del pedido
                sb.AppendLine();
                sb.AppendLine($"Total,,,{pedido.TOTAL:F2}");

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
                MessageBox.Show($"Error al generar el archivo : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridViewDetallePedido.DataSource = null;
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

        private void FormVerPedido_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de clientes desde la capa de negocio
                var clientes = CNPedido.ListarTodosLosClientes();

                // Configurar el comboBoxClientes
                comboBoxClientes.DataSource = clientes;             // Asignar la lista de clientes como fuente de datos
                comboBoxClientes.DisplayMember = "NOMBRE";         // Campo que se mostrará en el combo box
                comboBoxClientes.ValueMember = "IDCliente";        // Campo asociado al valor del combo box
                comboBoxClientes.SelectedIndex = -1;               // Inicialmente, sin selección

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
