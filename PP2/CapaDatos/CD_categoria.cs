using CapaEntidad;
using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public static void Insertar(Categoria categoria)  // Método marcado como static
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertarCategoriaUnica", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", categoria.DESCRIPCION);
                        command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000) // Código de error para RAISERROR
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                    else
                    {
                        throw new Exception("Error al insertar la categoría", ex);
                    }
                }
            }
        }

        public static List<Categoria> ListarDescripciones()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();
                    string query = "SELECT IDCATEGORIA, DESCRIPCION FROM CATEGORIA ORDER BY DESCRIPCION";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria
                            {
                                IDCATEGORIA = Convert.ToInt32(reader["IDCATEGORIA"]),
                                DESCRIPCION = reader["DESCRIPCION"]?.ToString() ?? string.Empty

                            };
                            lista.Add(categoria);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar las descripciones de categorías: " + ex.Message);
                }
            }

            return lista;
        }
        public static void EditarCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE CATEGORIA SET DESCRIPCION = @Descripcion WHERE IDCATEGORIA = @IdCategoria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descripcion", categoria.DESCRIPCION);
                        command.Parameters.AddWithValue("@IdCategoria", categoria.IDCATEGORIA);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar la categoría: " + ex.Message);
                }
            }
        }
        public static void EliminarCategoria(int idCategoria)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM CATEGORIA WHERE IDCATEGORIA = @IdCategoria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la categoría: " + ex.Message);
                }
            }
        }



    }

}
