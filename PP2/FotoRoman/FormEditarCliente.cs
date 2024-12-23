using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace FotoRoman
{
    public partial class FormEditarCliente : Form
    {
        private Cliente clienteActual;

        public FormEditarCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;

            // Llenar los datos del cliente en los controles
            textBoxNombre.Text = cliente.NOMBRE;
            textBoxCorreo.Text = cliente.CORREO;
            comboBoxEstado.Text = cliente.ESTADO;
            textBoxDocumento.Text = cliente.DOCUMENTO.ToString();
            textBoxTelefono.Text = cliente.TELEFONO.ToString();


            // Configurar el ComboBox para las provincias y localidades
            CargarProvincias(); // Llenar las provincias
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            // Seleccionar la provincia y localidad actuales del cliente
            comboBoxprovincia.SelectedItem = clienteActual.PROVINCIA;
            comboBoxLocalidad.SelectedItem = clienteActual.LOCALIDAD;
        }
        private void CargarProvincias()
        {
            try
            {
                // Obtener las provincias de la base de datos
                List<Provincia> provincias = CN_Localidades.ListarProvincias();
                if (provincias == null || provincias.Count == 0)
                {
                    MessageBox.Show("No se encontraron provincias en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    provincias = new List<Provincia>();
                }

                // Agregar opción para registrar nueva provincia
                provincias.Add(new Provincia { IDProvincia = -1, Nombre = "Registrar nueva provincia" });

                // Asignar las provincias al ComboBox
                comboBoxprovincia.DataSource = provincias;
                comboBoxprovincia.DisplayMember = "Nombre";
                comboBoxprovincia.ValueMember = "IDProvincia";

                // Manejar el cambio de provincia
                comboBoxprovincia.SelectedIndexChanged += (s, e) =>
                {
                    if (comboBoxprovincia.SelectedValue is int idProvincia)
                    {
                        if (idProvincia == -1) // Registrar nueva provincia
                        {
                            RegistrarNuevaProvincia();
                        }
                        else
                        {
                            CargarLocalidades(idProvincia);
                        }
                    }
                };

                // Seleccionar la provincia actual del cliente
                comboBoxprovincia.SelectedIndex = provincias.FindIndex(p => p.Nombre == clienteActual.PROVINCIA);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las provincias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLocalidades(int idProvincia)
        {
            try
            {
                // Obtener las localidades de la base de datos
                List<Localidad> localidades = CN_Localidades.ListarLocalidadesPorProvincia(idProvincia);
                if (localidades == null || localidades.Count == 0)
                {
                    MessageBox.Show("No se encontraron localidades para la provincia seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    localidades = new List<Localidad>();
                }

                // Agregar opción para registrar nueva localidad
                localidades.Add(new Localidad { IDLocalidad = -1, Nombre = "Registrar nueva localidad" });

                // Asignar las localidades al ComboBox
                comboBoxLocalidad.DataSource = localidades;
                comboBoxLocalidad.DisplayMember = "Nombre";
                comboBoxLocalidad.ValueMember = "IDLocalidad";

                // Manejar el cambio de localidad
                comboBoxLocalidad.SelectedIndexChanged += (s, e) =>
                {
                    if (comboBoxLocalidad.SelectedValue is int idLocalidad)
                    {
                        if (idLocalidad == -1) // Registrar nueva localidad
                        {
                            RegistrarNuevaLocalidad();
                        }
                    }
                };

                // Seleccionar la localidad actual del cliente
                comboBoxLocalidad.SelectedIndex = localidades.FindIndex(l => l.Nombre == clienteActual.LOCALIDAD);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarNuevaProvincia()
        {
            FormRegistrar formRegistrar = new FormRegistrar();
            if (formRegistrar.ShowDialog() == DialogResult.OK)
            {
                // Recargar provincias después de registrar
                CargarProvincias();
            }
            comboBoxprovincia.SelectedIndex = -1; // Restablecer selección
        }

        private void RegistrarNuevaLocalidad()
        {
            if (comboBoxprovincia.SelectedValue is int idProvincia && idProvincia != -1)
            {
                FormRegistrarLocalidad formRegistrarLocalidad = new FormRegistrarLocalidad();
                formRegistrarLocalidad.Tag = idProvincia; // Pasar el ID de la provincia seleccionada

                if (formRegistrarLocalidad.ShowDialog() == DialogResult.OK)
                {
                    // Recargar localidades después de registrar
                    CargarLocalidades(idProvincia);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una provincia antes de agregar una localidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            clienteActual.NOMBRE = textBoxNombre.Text;
            clienteActual.CORREO = textBoxCorreo.Text;
            clienteActual.ESTADO = comboBoxEstado.Text;
            clienteActual.PROVINCIA = comboBoxprovincia.Text;
            clienteActual.LOCALIDAD = comboBoxLocalidad.Text;

            // Captura el valor del teléfono
            if (int.TryParse(textBoxTelefono.Text, out int telefono))
            {
                clienteActual.TELEFONO = telefono;
            }
            else
            {
                MessageBox.Show("Ingrese un teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar a la capa de negocio para actualizar
            string mensaje;
            if (CNCliente.ActualizarCliente(clienteActual, out mensaje))
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
