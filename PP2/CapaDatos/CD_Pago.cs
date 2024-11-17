using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pago
    {
        // Método para insertar un pago en la base de datos
        public static void InsertarPago(Pago pago)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarPago", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@IDPEDIDO", pago.IDPEDIDO);
                        cmd.Parameters.AddWithValue("@MONTOPAGO", pago.MONTOPAGO);
                     
                        cmd.Parameters.AddWithValue("@METODOPAGO", pago.METODOPAGO ?? (object)DBNull.Value);

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el pago: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión explícitamente
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
