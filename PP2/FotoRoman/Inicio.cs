using System;
using System.Windows.Forms;
using CapaEntidad;

namespace FotoRoman
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            // Configurar visibilidad de menús según el rol del usuario
            if (UsuarioActual.Usuario == null)
            {
                MessageBox.Show("No se ha iniciado sesión correctamente. Se cerrará la aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            ConfigurarMenusPorRol();
        }

        /// <summary>
        /// Configurar los menús visibles según el rol del usuario actual.
        /// </summary>
        private void ConfigurarMenusPorRol()
        {
            // Obtener el rol del usuario actual
            int idRol = UsuarioActual.Usuario.oRol.IDROL;

            // Configurar menús según el rol
            if (idRol == 2) // Vendedor
            {
                // Ocultar el menú de reportes
                iconMenuItem22.Visible = false;

                // Ocultar el menú de usuarios
                menuusuario.Visible = false;
            }
            else if (idRol == 1) // Director
            {
                // No se oculta nada, tiene acceso completo
            }
            else
            {
                MessageBox.Show("Rol no reconocido. Contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void abrirFormulario(object sender, EventArgs e)
        {
            // Este método está vacío, puedes agregar lógica si lo necesitas
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            // Este método está vacío, puedes agregar lógica si lo necesitas
        }

        private void iconMenuItem21_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario FrmUsuario
            FrmUsuario frmUsuario = new FrmUsuario();

            // Mostrar el formulario
            frmUsuario.Show(); // Usa ShowDialog() si quieres que sea modal
        }

        private void crearUsuario(object sender, EventArgs e)
        {
            // Crea una instancia del formulario FormCrearUsuario
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario();

            // Mostrar el formulario (puedes usar ShowDialog si prefieres que sea modal)
            formCrearUsuario.Show();
        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FmCliente
            FmCliente fmCliente = new FmCliente();

            // Mostrar el formulario como una ventana modal
            fmCliente.ShowDialog();
        }

        private void iconMenuItem15_Click(object sender, EventArgs e)
        {
            FormCategoriaa formCategoriaa = new FormCategoriaa();
            formCategoriaa.ShowDialog(); // Abre FormCategoriaa como un diálogo modal
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormCrearProducto
            FormCrearProducto formCrearProducto = new FormCrearProducto();

            // Mostrar el formulario como una ventana modal
            formCrearProducto.ShowDialog();
        }

        private void iconMenuItem19_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica para editar un usuario
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormCrearPedido
            FormCrearPedido formCrearPedido = new FormCrearPedido();

            // Mostrar el formulario como ventana modal
            formCrearPedido.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            FormVerPedido formVerPedido = new FormVerPedido();

            // Mostrar el formulario de forma modal
            formVerPedido.ShowDialog();
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            FormVerPago formVerPago = new FormVerPago();

            // Mostrar el formulario de forma modal
            formVerPago.ShowDialog();
        }

        private void iconMenuItem22_Click(object sender, EventArgs e)
        {
            FormVerReporte formVerReporte = new FormVerReporte();

            // Mostrar el formulario de reportes de forma modal
            formVerReporte.ShowDialog();
        }

        /// <summary>
        /// Evento para cerrar la sesión del usuario actual.
        /// </summary>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar la sesión del usuario actual
            UsuarioActual.CerrarSesion();

            // Cerrar el formulario actual
            this.Close();

            // Mostrar el formulario de login nuevamente
            new Login().Show();
        }
    }
}
