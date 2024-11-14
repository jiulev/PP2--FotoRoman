using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pedido
    {
        // Método para insertar un pedido y sus detalles en la base de datos
        public static bool InsertarPedido(Pedido pedido, List<DetallePedido> detalles)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Insertar el pedido
                        using (SqlCommand command = new SqlCommand("InsertarPedido", connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IDCliente", pedido.ocliente.IDCliente);
                            command.Parameters.AddWithValue("@IDUsuario", pedido.oUsuario.IDUSUARIO);
                            command.Parameters.AddWithValue("@Total", pedido.TOTAL);
                            command.Parameters.AddWithValue("@FechaPedido", DateTime.Now);
                            command.Parameters.AddWithValue("@Estado", pedido.ESTADO ?? "Pendiente");

                            // Ejecutar el comando y obtener el ID del pedido insertado
                            pedido.IDPEDIDO = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Insertar los detalles del pedido
                        foreach (DetallePedido detalle in detalles)
                        {
                            using (SqlCommand command = new SqlCommand("InsertarDetallePedido", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@IDPedido", pedido.IDPEDIDO);
                                command.Parameters.AddWithValue("@IDProducto", detalle.oProducto.IdProducto);
                                command.Parameters.AddWithValue("@Cantidad", detalle.CANTIDAD);
                                command.Parameters.AddWithValue("@PrecioUnitario", detalle.PRECIOUNITARIO);

                                // Ejecutar la inserción del detalle
                                command.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción si todo fue exitoso
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        throw new Exception("Error al insertar el pedido y sus detalles. Transacción revertida: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        // Método para obtener el último ID de pedido registrado
        public static int ObtenerUltimoIdPedido()
        {
            int ultimoId = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();
                    string query = "SELECT ISNULL(MAX(IDPEDIDO), 0) FROM PEDIDO";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        // Ejecutar la consulta y obtener el último ID de pedido
                        ultimoId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el último ID de pedido: " + ex.Message);
                }
            }

            return ultimoId;
        }
    }
}
