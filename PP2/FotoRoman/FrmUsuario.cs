﻿using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace FotoRoman
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        // Método para cargar los usuarios y sus roles
        private void CargarUsuarios()
        {
            CNUsuario cnUsuario = new CNUsuario();
            dataGridViewUsuarios.DataSource = cnUsuario.Listar();
        }

        // Método para el botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.");
                return;
            }

            // Verificar si la celda contiene el ID del usuario
            if (dataGridViewUsuarios.SelectedRows[0].Cells["IDUSUARIO"].Value is null)
            {
                MessageBox.Show("No se pudo obtener el ID del usuario seleccionado.");
                return;
            }

            int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["IDUSUARIO"].Value);
            EditarUsuario(idUsuario);
        }


        // Método para editar un usuario
        private void EditarUsuario(int idUsuario)
        {
            CNUsuario cnUsuario = new CNUsuario();

            // Manejar el posible valor nulo con 'asignación nula'
            Usuario usuario = cnUsuario.Listar().Find(u => u.IDUSUARIO == idUsuario) ?? new Usuario();

            if (usuario.IDUSUARIO == 0)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(usuario);
            frmEditarUsuario.ShowDialog();

            CargarUsuarios();
        }


        // Método para el botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
                return;
            }

            int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["IDUSUARIO"].Value);
            EliminarUsuario(idUsuario);
        }

        // Método para eliminar un usuario
        private void EliminarUsuario(int idUsuario)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    CNUsuario cnUsuario = new CNUsuario();
                    cnUsuario.Eliminar(idUsuario);
                    MessageBox.Show("Usuario eliminado correctamente.");
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }
    }
}
