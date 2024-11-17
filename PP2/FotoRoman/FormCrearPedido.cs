using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace FotoRoman
{
    public partial class FormCrearPedido : Form
    {
        private List<DetallePedido> detallesPedido = new List<DetallePedido>();
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Categoria> listaCategorias = new List<Categoria>();
        private List<Producto> listaProductos = new List<Producto>();
        private int idPedidoGenerado;

        public FormCrearPedido()
        {
            InitializeComponent();
        }

        private void FormCrearPedido_Load(object sender, EventArgs e)
        {
            try
            {
                CargarClientes();
                CargarCategorias();

                // Mostrar el próximo número de pedido
                int proximoNumeroPedido = CNPedido.ObtenerProximoNumeroPedido();
                num.Text = proximoNumeroPedido.ToString();
                buttonRegistrar.Enabled = false; // Deshabilitar botón de registrar pago hasta que se cree el pedido
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular el total del pedido
        private void CalcularTotal()
        {
            decimal totalSum = detallesPedido.Sum(d => d.SUBTOTAL);
            total.Text = $"Total: ${totalSum:F2}";
        }

        // Evento para agregar un producto al pedido
        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string productoNombre = comboProducto.SelectedItem is Producto producto ? producto.Nombre : "Sin nombre";
                decimal precio = Convert.ToDecimal(textPrecio1.Text);
                int cantidad = Convert.ToInt32(textCantidad1.Text);
                decimal subtotal = precio * cantidad;

                if (string.IsNullOrWhiteSpace(productoNombre) || precio <= 0 || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese datos válidos para el producto, precio y cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var productoSeleccionado = listaProductos.FirstOrDefault(p => p.Nombre == productoNombre);
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DetallePedido detalle = new DetallePedido
                {
                    oProducto = productoSeleccionado,
                    CANTIDAD = cantidad,
                    PRECIOUNITARIO = precio,
                    SUBTOTAL = subtotal
                };

                detallesPedido.Add(detalle);
                dataGridView1.Rows.Add(productoNombre, precio, subtotal);
                CalcularTotal();

                comboProducto.SelectedIndex = -1;
                textPrecio1.Clear();
                textCantidad1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para eliminar un ítem del pedido
        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                detallesPedido.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Eliminar ítem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void RegistrarPago()
        {
            if (idPedidoGenerado > 0)
            {
                FormRegistrarPago formPago = new FormRegistrarPago
                {
                    TextNombre = comboCliente.Text,
                    TextImporte = total.Text.Replace("Total: $", ""),
                    TextNum = idPedidoGenerado.ToString()
                };

                formPago.ShowDialog();
                LimpiarCampos();
                RefrescarNumeroPedido();
            }
        }


        // Evento para crear el pedido
        private void crear1_Click(object sender, EventArgs e)
        {
            try
            {
                if (detallesPedido.Count == 0)
                {
                    MessageBox.Show("No hay ítems agregados al pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCliente = comboCliente.SelectedIndex + 1;
                int idUsuario = 1;
                decimal totalPedido = detallesPedido.Sum(d => d.SUBTOTAL);
                string estado = "Pendiente";
                DateTime fechaPedido = DateTime.Now;

                string mensaje;
                bool resultado = CNPedido.InsertarPedido(idCliente, idUsuario, totalPedido, fechaPedido, estado, detallesPedido, out mensaje);

                if (resultado)
                {
                    idPedidoGenerado = CNPedido.ObtenerUltimoIdPedido();
                    var respuesta = MessageBox.Show("Pedido creado exitosamente. ¿Desea registrar el pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        buttonRegistrar.Enabled = true;
                        RegistrarPago();
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            comboCliente.SelectedIndex = -1;
            comboCategoria.SelectedIndex = -1;
            comboProducto.SelectedIndex = -1;
            textDni.Clear();
            textLocalidad.Clear();
            textCantidad1.Clear();
            textPrecio1.Clear();
            total.Text = "$0.00";
            detallesPedido.Clear();
            dataGridView1.Rows.Clear();
            buttonRegistrar.Enabled = false;
        }


        private void RefrescarNumeroPedido()
        {
            int proximoNumeroPedido = CNPedido.ObtenerProximoNumeroPedido();
            num.Text = proximoNumeroPedido.ToString();
        }

        // Evento para registrar el pago
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPedidoGenerado > 0)
                {
                    RegistrarPago();
                }
                else
                {
                    MessageBox.Show("Primero debe crear un pedido antes de registrar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de registro de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Cargar la lista de clientes
        private void CargarClientes()
        {
            try
            {
                listaClientes = CNCliente.ListarClientes();
                comboCliente.Items.Clear();

                foreach (var cliente in listaClientes)
                {
                    comboCliente.Items.Add(cliente.NOMBRE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Cargar la lista de categorías
        private void CargarCategorias()
        {
            try
            {
                listaCategorias = CNCategoria.ListarDescripciones();
                comboCategoria.Items.Clear();

                foreach (var categoria in listaCategorias)
                {
                    comboCategoria.Items.Add(new { Text = categoria.DESCRIPCION, Value = categoria.IDCATEGORIA });
                }

                comboCategoria.DisplayMember = "Text";
                comboCategoria.ValueMember = "Value";
                comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para seleccionar una categoría y cargar productos
        private void comboCategoria_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (comboCategoria.SelectedItem != null)
                {
                    var categoriaSeleccionada = (dynamic)comboCategoria.SelectedItem;
                    int idCategoria = categoriaSeleccionada.Value;
                    CargarProductos(idCategoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar productos según la categoría seleccionada
        private void CargarProductos(int idCategoria)
        {
            try
            {
                listaProductos = CNProducto.ListarPorCategoria(idCategoria);
                comboProducto.Items.Clear();

                foreach (var producto in listaProductos)
                {
                    comboProducto.Items.Add(producto);
                }

                comboProducto.DisplayMember = "Nombre";
                comboProducto.ValueMember = "IdProducto";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para seleccionar un cliente
        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string clienteSeleccionado = comboCliente.Text;
                var cliente = listaClientes.FirstOrDefault(c => c.NOMBRE == clienteSeleccionado);

                if (cliente != null)
                {
                    textDni.Text = cliente.DOCUMENTO.ToString();
                    textLocalidad.Text = cliente.LOCALIDAD;
                }
                else
                {
                    textDni.Clear();
                    textLocalidad.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento para seleccionar un producto y mostrar su precio
        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboProducto.SelectedItem != null)
                {
                    var productoSeleccionado = (Producto)comboProducto.SelectedItem;
                    textPrecio1.Text = productoSeleccionado.Precio.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
