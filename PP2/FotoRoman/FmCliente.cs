using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace FotoRoman
{
    public partial class FmCliente : Form
    {
        public FmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Cliente y asignar los valores de los campos de texto
                Cliente cliente = new Cliente
                {
                    DOCUMENTO = int.Parse(textDocumento.Text.Trim()),
                    NOMBRE = textNombre.Text.Trim(),
                    CORREO = textCorreo.Text.Trim(),
                    ESTADO = "Activo", // Estado por defecto
                    LOCALIDAD = textLocalidad.Text.Trim(),
                    PROVINCIA = textProvincia.Text.Trim(),
                    FECHACREACION = DateTime.Now // Fecha de creación actual
                };

                // Llamar al método InsertarCliente en CNCliente de forma estática
                string mensaje;
                bool exito = CNCliente.InsertarCliente(cliente, out mensaje);

                // Mostrar el mensaje de resultado
                MessageBox.Show(mensaje, exito ? "Éxito" : "Error", MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para el documento.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textLocalidad_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void textestadoo_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void FmCliente_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void CancelarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar los campos del formulario
                textNombre.Clear();
                textDocumento.Clear();
                textCorreo.Clear();
                textLocalidad.Clear();
                textProvincia.Clear();

                // Opcional: Mostrar un mensaje de confirmación
                MessageBox.Show("Los campos han sido limpiados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al limpiar los campos
                MessageBox.Show($"Error al limpiar los campos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
