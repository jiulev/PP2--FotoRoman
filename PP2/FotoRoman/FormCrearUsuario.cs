using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace FotoRoman
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();

            // Limpiar el ComboBox antes de agregar los ítems
            cmbRol.Items.Clear();

            // Poblar el ComboBox con las opciones de roles
            cmbRol.Items.Add("Vendedor");  // Agrega la opción "Vendedor"
            cmbRol.Items.Add("Director");  // Agrega la opción "Director"

            // Selecciona por defecto el primer ítem (opcional)
            cmbRol.SelectedIndex = 0;  // Esto es opcional, selecciona el primer rol por defecto
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            // Este método puede dejarse vacío si no tienes lógica específica al cargar el formulario
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo Documento no esté vacío y sea un número válido
                if (string.IsNullOrWhiteSpace(textDocumento.Text) || !int.TryParse(textDocumento.Text.Trim(), out int documento))
                {
                    MessageBox.Show("El documento debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDocumento.Focus();
                    return;
                }

                // Validar que el documento tenga entre 7 y 10 dígitos
                if (textDocumento.Text.Length < 7 || textDocumento.Text.Length > 10)
                {
                    MessageBox.Show("El documento debe tener entre 7 y 10 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDocumento.Focus();
                    return;
                }

                // Validar que el campo Nombre no esté vacío
                if (string.IsNullOrWhiteSpace(textNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNombre.Focus();
                    return;
                }

                // Validar que el campo Email no esté vacío y tenga formato válido
                if (string.IsNullOrWhiteSpace(textEmail.Text) || !System.Text.RegularExpressions.Regex.IsMatch(textEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo electrónico es obligatorio y debe tener un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textEmail.Focus();
                    return;
                }

                // Validar que el campo Contraseña no esté vacío y tenga entre 3 y 10 caracteres
                if (string.IsNullOrWhiteSpace(textPassword.Text) || textPassword.Text.Length < 3 || textPassword.Text.Length > 10)
                {
                    MessageBox.Show("La contraseña debe tener entre 3 y 10 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPassword.Focus();
                    return;
                }

                // Crear una nueva instancia de Usuario
                Usuario nuevoUsuario = new Usuario
                {
                    IDUSUARIO = documento,
                    DOCUMENTO = documento.ToString(), // Se guarda el DNI como documento
                    NOMBRE = textNombre.Text.Trim(),
                    EMAIL = textEmail.Text.Trim(),
                    PASSWORD = textPassword.Text.Trim(),
                    FECHACREACION = DateTime.Now // Asignar la fecha de creación
                };

                // Asignar el rol dependiendo de la selección del ComboBox
                if (cmbRol.SelectedIndex == 0) // Posición 0 = "Vendedor"
                {
                    nuevoUsuario.oRol = new Rol { IDROL = 1 }; // IDROL para "Vendedor"
                }
                else if (cmbRol.SelectedIndex == 1) // Posición 1 = "Director"
                {
                    nuevoUsuario.oRol = new Rol { IDROL = 2 }; // IDROL para "Director"
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un rol válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRol.Focus();
                    return;
                }

                // Llamar a la capa de negocio para insertar el usuario
                CNUsuario cnUsuario = new CNUsuario();
                cnUsuario.Insertar(nuevoUsuario);

                // Mostrar mensaje de éxito
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                textNombre.Clear();
                textDocumento.Clear();
                textEmail.Clear();
                textPassword.Clear();
                cmbRol.SelectedIndex = 0; // Restablecer el ComboBox
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si la inserción falla
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void cancelar_click(object sender, EventArgs e)
        {
            this.Close();  // Cerrar el formulario sin realizar cambios
        }

        // Métodos de eventos no usados o vacíos
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label2_Click(object sender, EventArgs e) { }
        private void Label3_Click(object sender, EventArgs e) { }
        private void Label4_Click(object sender, EventArgs e) { }
        private void Rol_Click(object sender, EventArgs e) { }
    }
}


