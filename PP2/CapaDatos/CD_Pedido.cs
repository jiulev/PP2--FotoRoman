using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pedido
    {
        // Método para insertar un pedido y sus detalles
        public static bool InsertarPedido(int idCliente, int idUsuario, decimal total, DateTime fechaPedido, string estado, List<DetallePedido> detalles)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                SqlTransaction? transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // Insertar el pedido
                    using (SqlCommand cmdPedido = new SqlCommand("InsertarPedido", connection, transaction))
                    {
                        cmdPedido.CommandType = CommandType.StoredProcedure;
                        cmdPedido.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                        cmdPedido.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
                        cmdPedido.Parameters.AddWithValue("@TOTAL", total);
                        cmdPedido.Parameters.AddWithValue("@FECHAPEDIDO", fechaPedido);
                        cmdPedido.Parameters.AddWithValue("@ESTADO", estado);

                        // Obtener el ID del pedido insertado
                        int idPedido = Convert.ToInt32(cmdPedido.ExecuteScalar());

                        // Insertar los detalles del pedido
                        foreach (DetallePedido detalle in detalles)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand("InsertarDetallePedido", connection, transaction))
                            {
                                cmdDetalle.CommandType = CommandType.StoredProcedure;
                                cmdDetalle.Parameters.AddWithValue("@IDPEDIDO", idPedido);
                                cmdDetalle.Parameters.AddWithValue("@IDPRODUCTO", detalle.oProducto.IdProducto);
                                cmdDetalle.Parameters.AddWithValue("@CANTIDAD", detalle.CANTIDAD);
                                cmdDetalle.Parameters.AddWithValue("@PRECIOUNITARIO", detalle.PRECIOUNITARIO);
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction?.Rollback();
                    throw new Exception("Error al insertar el pedido y sus detalles: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Método para obtener el último ID de pedido
        public static int ObtenerUltimoIdPedido()
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ISNULL(MAX(IDPEDIDO), 0) FROM PEDIDO";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el último ID de pedido: " + ex.Message);
                }
            }
        }
    }
}
