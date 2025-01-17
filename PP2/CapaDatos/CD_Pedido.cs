﻿using CapaEntidad;
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

        // Método para buscar un pedido por ID
        public static Pedido? BuscarPedidoPorId(int idPedido)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT p.IDPEDIDO, p.TOTAL, p.FECHAPEDIDO, p.ESTADO,
                           c.IDCLIENTE, c.NOMBRE, c.CORREO, c.LOCALIDAD, c.PROVINCIA
                    FROM PEDIDO p
                    INNER JOIN CLIENTE c ON p.IDCLIENTE = c.IDCLIENTE
                    WHERE p.IDPEDIDO = @IDPEDIDO";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPEDIDO", idPedido);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Pedido
                                {
                                    IDPEDIDO = Convert.ToInt32(reader["IDPEDIDO"]),
                                    oCliente = new Cliente
                                    {
                                        IDCliente = Convert.ToInt32(reader["IDCLIENTE"]),
                                        NOMBRE = reader["NOMBRE"]?.ToString() ?? string.Empty,
                                        CORREO = reader["CORREO"]?.ToString() ?? string.Empty,
                                        LOCALIDAD = reader["LOCALIDAD"]?.ToString() ?? string.Empty,
                                        PROVINCIA = reader["PROVINCIA"]?.ToString() ?? string.Empty
                                    },
                                    TOTAL = Convert.ToDecimal(reader["TOTAL"]),
                                    FECHAPEDIDO = reader["FECHAPEDIDO"] != DBNull.Value ? Convert.ToDateTime(reader["FECHAPEDIDO"]) : DateTime.MinValue,

                                    ESTADO = reader["ESTADO"]?.ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el pedido por ID: " + ex.Message);
                }
            }

            return null;
        }

        // Método para buscar pedidos por nombre del cliente
        public static List<Pedido> BuscarPedidosPorNombreCliente(string nombreCliente)
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT p.IDPEDIDO, p.TOTAL, p.FECHAPEDIDO, p.ESTADO,
                           c.IDCLIENTE, c.NOMBRE, c.CORREO, c.LOCALIDAD, c.PROVINCIA
                    FROM PEDIDO p
                    INNER JOIN CLIENTE c ON p.IDCLIENTE = c.IDCLIENTE
                    WHERE c.NOMBRE LIKE '%' + @NOMBRE + '%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NOMBRE", nombreCliente);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pedidos.Add(new Pedido
                                {
                                    IDPEDIDO = Convert.ToInt32(reader["IDPEDIDO"]),
                                    oCliente = new Cliente
                                    {
                                        IDCliente = Convert.ToInt32(reader["IDCLIENTE"]),
                                        NOMBRE = reader["NOMBRE"]?.ToString() ?? string.Empty
                                    },
                                    TOTAL = Convert.ToDecimal(reader["TOTAL"]),
                                    FECHAPEDIDO = reader["FECHAPEDIDO"] != DBNull.Value ? Convert.ToDateTime(reader["FECHAPEDIDO"]) : DateTime.MinValue,

                                    ESTADO = reader["ESTADO"]?.ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar pedidos por nombre del cliente: " + ex.Message);
                }
            }

            return pedidos;
        }



        // Método para listar todos los pedidos
        public static List<Pedido> ListarTodosLosPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT p.IDPEDIDO, p.IDCLIENTE, p.IDUSUARIO, p.TOTAL, p.FECHAPEDIDO, p.ESTADO,
                       c.NOMBRE AS NombreCliente, u.NOMBRE AS NombreUsuario
                FROM PEDIDO p
                INNER JOIN CLIENTE c ON p.IDCLIENTE = c.IDCLIENTE
                INNER JOIN USUARIO u ON p.IDUSUARIO = u.IDUSUARIO";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    IDPEDIDO = Convert.ToInt32(reader["IDPEDIDO"]),
                                    IDCliente = Convert.ToInt32(reader["IDCLIENTE"]),
                                    IDUsuario = Convert.ToInt32(reader["IDUSUARIO"]),
                                    TOTAL = Convert.ToDecimal(reader["TOTAL"]),
                                    FECHAPEDIDO = reader["FECHAPEDIDO"] != DBNull.Value
    ? Convert.ToDateTime(reader["FECHAPEDIDO"])
    : DateTime.MinValue,
                                    ESTADO = reader["ESTADO"].ToString() ?? string.Empty,
                                    oCliente = new Cliente { NOMBRE = reader["NombreCliente"].ToString() ?? string.Empty },
                                    oUsuario = new Usuario { NOMBRE = reader["NombreUsuario"].ToString() ?? string.Empty }
                                };

                                listaPedidos.Add(pedido);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar todos los pedidos: " + ex.Message);
                }
            }

            return listaPedidos;
        }


        // Método para obtener los detalles de un pedido por su ID

        public static List<DetallePedido> ObtenerDetallesDelPedido(int idPedido)
        {
            List<DetallePedido> listaDetalles = new List<DetallePedido>();

            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT d.IDDETALLE, d.IDPEDIDO, d.IDPRODUCTO, d.CANTIDAD, d.PRECIOUNITARIO, 
                       p.NOMBRE AS NombreProducto
                FROM DETALLE_PEDIDO d
                INNER JOIN PRODUCTO p ON d.IDPRODUCTO = p.IDPRODUCTO
                WHERE d.IDPEDIDO = @IDPEDIDO";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPEDIDO", idPedido);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DetallePedido detalle = new DetallePedido
                                {
                                    IDDETALLE = Convert.ToInt32(reader["IDDETALLE"]),
                                    oPedido = new Pedido { IDPEDIDO = Convert.ToInt32(reader["IDPEDIDO"]) },
                                    oProducto = new Producto
                                    {
                                        IdProducto = Convert.ToInt32(reader["IDPRODUCTO"]),
                                        Nombre = reader["NombreProducto"].ToString() ?? string.Empty
                                    },
                                    CANTIDAD = Convert.ToInt32(reader["CANTIDAD"]),
                                    PRECIOUNITARIO = Convert.ToDecimal(reader["PRECIOUNITARIO"]),
                                    SUBTOTAL = Convert.ToInt32(reader["CANTIDAD"]) * Convert.ToDecimal(reader["PRECIOUNITARIO"])
                                };

                                listaDetalles.Add(detalle);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los detalles del pedido: " + ex.Message);
                }
            }

            return listaDetalles;
        }



        // Método para listar todos los clientes desde la base de datos
        public static List<Cliente> ListarTodosLosClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    connection.Open();
                    string query = "SELECT NOMBRE FROM CLIENTE WHERE ESTADO = 'Activo'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            NOMBRE = reader["NOMBRE"]?.ToString() ?? string.Empty


                        };
                        listaClientes.Add(cliente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes: " + ex.Message);
            }

            return listaClientes;
        }



        public static List<Pago> ObtenerPagosDelPedido(int idPedido)
        {
            List<Pago> listaPagos = new List<Pago>();

            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT IDPAGO, IDPEDIDO, MONTOPAGO, FECHAPAGO, METODOPAGO
                FROM PAGO
                WHERE IDPEDIDO = @IDPEDIDO";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPEDIDO", idPedido);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pago pago = new Pago
                                {
                                    IDPAGO = Convert.ToInt32(reader["IDPAGO"]),
                                    IDPEDIDO = Convert.ToInt32(reader["IDPEDIDO"]),
                                    MONTOPAGO = Convert.ToDecimal(reader["MONTOPAGO"]),
                                    FECHAPAGO = Convert.ToDateTime(reader["FECHAPAGO"]),
                                    METODOPAGO = reader["METODOPAGO"]?.ToString() ?? string.Empty
                                };
                                listaPagos.Add(pago);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los pagos del pedido: " + ex.Message);
                }
            }

            return listaPagos;
        }

        public List<Pedido> ObtenerPedidosPorUsuarioYFechas(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    conexion.Open();

                    // Log de las fechas antes de ejecutar el query
                    string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");
                   
                    File.AppendAllText(logPath, $"IDUsuario: {idUsuario}, Fecha Desde: {fechaDesde:yyyy-MM-dd HH:mm:ss}, Fecha Hasta: {fechaHasta:yyyy-MM-dd HH:mm:ss}{Environment.NewLine}");


                    string query = @"
            SELECT IDPEDIDO, TOTAL, FECHAPEDIDO
            FROM PEDIDO
            WHERE IDUSUARIO = @IDUsuario
              AND CAST(FECHAPEDIDO AS DATE) >= CAST(@FechaDesde AS DATE)
              AND CAST(FECHAPEDIDO AS DATE) <= CAST(@FechaHasta AS DATE)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaPedidos.Add(new Pedido
                                {
                                    IDPEDIDO = reader.GetInt32(0),
                                    TOTAL = reader.GetDecimal(1),
                                    FECHAPEDIDO = reader.GetDateTime(2)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener pedidos: " + ex.Message);
                }
            }

            return listaPedidos;
        }

        // Método para obtener el Top 10 de productos más vendidos por mes
        public static List<Producto> ObtenerTop10ProductosPorMes()
        {
            var listaProductos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            FORMAT(P.FECHAPEDIDO, 'yyyy-MM') AS Mes,
                            PR.NOMBRE AS Producto,
                            SUM(DP.CANTIDAD) AS CantidadVendida
                        FROM 
                            DETALLE_PEDIDO DP
                        INNER JOIN 
                            PRODUCTO PR ON DP.IDPRODUCTO = PR.IDPRODUCTO
                        INNER JOIN 
                            PEDIDO P ON DP.IDPEDIDO = P.IDPEDIDO
                        GROUP BY 
                            FORMAT(P.FECHAPEDIDO, 'yyyy-MM'), PR.NOMBRE
                        ORDER BY 
                            FORMAT(P.FECHAPEDIDO, 'yyyy-MM'), CantidadVendida DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaProductos.Add(new Producto
                                {
                                    Mes = reader["Mes"].ToString(),
                                    Nombre = reader["Producto"].ToString(),
                                    CantidadVendida = Convert.ToInt32(reader["CantidadVendida"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los productos más vendidos: " + ex.Message);
                }
            }

            return listaProductos;
        }
        public static decimal ObtenerTotalVentasPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            decimal totalVentas = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    conexion.Open();

                    string query = @"
                SELECT SUM(TOTAL) AS TotalVentas
                FROM PEDIDO
                WHERE CAST(FECHAPEDIDO AS DATE) >= CAST(@FechaDesde AS DATE)
                  AND CAST(FECHAPEDIDO AS DATE) <= CAST(@FechaHasta AS DATE)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        object result = comando.ExecuteScalar();
                        totalVentas = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el total de ventas: " + ex.Message);
                }
            }

            return totalVentas;
        }







    }
}
