using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using CapaEntidad;

namespace FotoRoman
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void iconButton1_Click(object sender, EventArgs e) // Botón de ingresar
        {
            // Obtener la lista de usuarios
            List<Usuario> usuarios = new CNUsuario().Listar();

            // Buscar el usuario con el documento y clave ingresados
            Usuario ousuario = usuarios
                  .Where(u => u.DOCUMENTO == txtdocumento.Text && u.PASSWORD.Equals(txtclave.Text, StringComparison.OrdinalIgnoreCase))
    .FirstOrDefault();

            // Verificar si se encontró el usuario
            if (ousuario != null)
            {
                // Usuario encontrado
                MessageBox.Show("Usuario encontrado. Bienvenido, " + ousuario.NOMBRE);

                // Mostrar el formulario Inicio
                Inicio form = new Inicio();
                form.Show();

                // Ocultar el formulario actual
                this.Hide();

                // Suscribirse al evento FormClosing del formulario Inicio
                form.FormClosing += frm_closing; // Este evento debe estar definido
            }
            else
            {
                // Usuario no encontrado
                MessageBox.Show("Documento o clave incorrectos.");
            }
        }




        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";

            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
