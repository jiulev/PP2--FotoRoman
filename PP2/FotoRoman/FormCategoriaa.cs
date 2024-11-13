using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace FotoRoman
{
    public partial class FormCategoriaa : Form
    {
        public FormCategoriaa()
        {
            InitializeComponent();
        }

        private void FormCategoriaa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CrearCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de Categoria y asignar la descripción desde comboBoxCategoria
                Categoria categoria = new Categoria
                {
                    DESCRIPCION = comboBoxCategoria.Text.Trim()
                };

                // Llamar al método estático InsertarCategoria en CNCategoria
                CNCategoria.InsertarCategoria(categoria);

                MessageBox.Show("Categoría registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CancelarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
