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
    }
}
