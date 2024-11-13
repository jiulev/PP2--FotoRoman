using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace FotoRoman
{
    public partial class FrmEditarUsuario : Form
    {
        private Usuario usuario;

        // Constructor que recibe un objeto Usuario
        public FrmEditarUsuario(Usuario usuarioSeleccionado)
        {
            InitializeComponent();
            usuario = usuarioSeleccionado;

            // Cargar datos del usuario en los controles del formulario
            textNombre.Text = usuario.NOMBRE;
            textDocumento.Text = usuario.DOCUMENTO; // Solo para mostrar, no se puede editar
            textDocumento.ReadOnly = true;
            textEmail.Text = usuario.EMAIL;
            textPassword.Text = usuario.PASSWORD;
        }

        // Evento para el botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar solo los datos editables
                usuario.NOMBRE = textNombre.Text ?? string.Empty;
                usuario.EMAIL = textEmail.Text ?? string.Empty;
                usuario.PASSWORD = textPassword.Text ?? string.Empty;

                // Llamar al método de la capa de negocio para actualizar el usuario
                CNUsuario cnUsuario = new CNUsuario();
                cnUsuario.Editar(usuario);

                MessageBox.Show("Usuario actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }

        // Evento para el botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin guardar cambios
            this.Close();
        }

        // Evento Load del formulario
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            // Este evento está definido para evitar errores, aunque no se usa.
        }

        // Evento para el TextBox Nombre (no se utiliza, pero lo definimos por seguridad)
        private void textNombre_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento para el TextBox Email
        private void textEmail_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento para el TextBox Password
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento para el TextBox Documento (aunque es de solo lectura)
        private void textDocumento_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
