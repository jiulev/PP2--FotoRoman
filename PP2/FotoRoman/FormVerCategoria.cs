using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace FotoRoman
{
    public partial class FormVerCategoria : Form
    {
        private List<Categoria> categorias = new List<Categoria>();

        public FormVerCategoria()
        {
            InitializeComponent();
            // Configurar el DataGridView para mostrar solo la columna deseada
            ConfigurarDataGridView();
        }

        private void FormVerCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                // Obtener las categorías desde la capa de negocio
                var categorias = CNCategoria.ListarDescripciones();

                // Asignar los datos al DataGridView
                dataGridViewCategorias.DataSource = categorias;

                // Configurar el DataGridView
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // Asegúrate de que las columnas estén generadas
            if (dataGridViewCategorias.Columns.Count > 0)
            {
                foreach (DataGridViewColumn column in dataGridViewCategorias.Columns)
                {
                    column.Visible = false; // Oculta todas las columnas
                }

                // Haz visible únicamente la columna "DESCRIPCION"
                if (dataGridViewCategorias.Columns["DESCRIPCION"] != null)
                {
                    dataGridViewCategorias.Columns["DESCRIPCION"].Visible = true;
                }
                else
                {
                    MessageBox.Show("La columna 'DESCRIPCION' no existe en el DataSource.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Configura el estilo del DataGridView
            dataGridViewCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategorias.MultiSelect = false;
        }



        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = textBoxBuscar.Text.Trim().ToLower();

                // Obtener todas las categorías
                var categorias = CNCategoria.ListarDescripciones();

                // Si no hay texto, mostrar todas las categorías
                if (string.IsNullOrEmpty(textoBusqueda))
                {
                    dataGridViewCategorias.DataSource = categorias;
                    return;
                }

                // Filtrar las categorías por descripción
                var categoriasFiltradas = categorias
                    .Where(c => c.DESCRIPCION.ToLower().Contains(textoBusqueda))
                    .ToList();

                // Actualizar el DataGridView con los resultados filtrados
                dataGridViewCategorias.DataSource = categoriasFiltradas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count > 0)
            {
                var categoriaSeleccionada = (Categoria)dataGridViewCategorias.SelectedRows[0].DataBoundItem;

                string nuevaDescripcion = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la nueva descripción:",
                    "Editar Categoría",
                    categoriaSeleccionada.DESCRIPCION);

                if (!string.IsNullOrWhiteSpace(nuevaDescripcion))
                {
                    try
                    {
                        categoriaSeleccionada.DESCRIPCION = nuevaDescripcion;
                        CNCategoria.EditarCategoria(categoriaSeleccionada);
                        MessageBox.Show("Categoría editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al editar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count > 0)
            {
                var categoriaSeleccionada = (Categoria)dataGridViewCategorias.SelectedRows[0].DataBoundItem;

                var confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría '{categoriaSeleccionada.DESCRIPCION}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        CNCategoria.EliminarCategoria(categoriaSeleccionada.IDCATEGORIA);
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count > 0)
            {
                // Obtener la categoría seleccionada
                var categoriaSeleccionada = (Categoria)dataGridViewCategorias.SelectedRows[0].DataBoundItem;

                // Confirmación antes de proceder con la eliminación
                var confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría '{categoriaSeleccionada.DESCRIPCION}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Validar si existen productos asociados a la categoría
                        bool tieneProductos = CNProducto.VerificarProductosPorCategoria(categoriaSeleccionada.IDCATEGORIA);

                        if (tieneProductos)
                        {
                            MessageBox.Show(
                                $"No se puede eliminar la categoría '{categoriaSeleccionada.DESCRIPCION}' porque tiene productos asociados.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        // Eliminar la categoría si no tiene productos asociados
                        CNCategoria.EliminarCategoria(categoriaSeleccionada.IDCATEGORIA);

                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar las categorías en el DataGridView
                        CargarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
