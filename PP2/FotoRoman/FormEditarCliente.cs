using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace FotoRoman
{
    public partial class FormEditarCliente : Form
    {
        private Cliente clienteActual;

        // Constructor para recibir el cliente a editar
        public FormEditarCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;

            // Cargar datos del cliente en los controles del formulario
            textBoxNombre.Text = cliente.NOMBRE;
            textBoxCorreo.Text = cliente.CORREO;
            comboBoxEstado.Text = cliente.ESTADO;
            textBoxLocalidad.Text = cliente.LOCALIDAD;
            textBoxProvincia.Text = cliente.PROVINCIA;
            textBoxDocumento.Text = cliente.DOCUMENTO.ToString();

            // Configurar campos de solo lectura
            textBoxDocumento.ReadOnly = true;
    
        }

        // Evento del botón Guardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            clienteActual.NOMBRE = textBoxNombre.Text;
            clienteActual.CORREO = textBoxCorreo.Text;
            clienteActual.ESTADO = comboBoxEstado.Text;
            clienteActual.LOCALIDAD = textBoxLocalidad.Text;
            clienteActual.PROVINCIA = textBoxProvincia.Text;

            string mensaje;
            if (CNCliente.ActualizarCliente(clienteActual, out mensaje))
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Indicar que los cambios se guardaron
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento del botón Cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
