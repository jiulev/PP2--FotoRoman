namespace FotoRoman
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
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
            //aca editamos un usuario//
        }
    }
}
