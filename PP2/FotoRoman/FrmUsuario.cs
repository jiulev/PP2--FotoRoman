using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace FotoRoman
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            CargarUsuarios(); // Llamar al método para cargar usuarios al abrir el formulario
        }

        // Método para cargar los usuarios y sus roles desde la base de datos
        private void CargarUsuarios()
        {
            // Obtener la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

            // Consulta SQL con un JOIN entre USUARIO y ROL
            string query = @"
                SELECT U.IDUSUARIO, U.NOMBRE, U.EMAIL, R.DESCRIPCION AS ROL
                FROM USUARIO U
                INNER JOIN ROL R ON U.IDROL = R.IDROL";

            // Usar SqlConnection y SqlDataAdapter para conectarse y llenar los datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Usar SqlDataAdapter para ejecutar la consulta y llenar los datos
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar los datos al DataGridView
                    dataGridViewUsuarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los usuarios y roles: " + ex.Message);
                }
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar lo que ocurra cuando se haga clic en una celda
        }
    }
}



