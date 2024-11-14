﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Producto
    {
        // Método para insertar un producto usando el procedimiento almacenado
        public static void Insertar(Producto producto)
        {
            using var connection = new SqlConnection(Conexion.ObtenerCadenaConexion());
            try
            {
                connection.Open();

                // Llamada al procedimiento almacenado InsertarProducto
                using var command = new SqlCommand("InsertarProducto", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                // Añadir parámetros
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@DescripcionCategoria", producto.DescripcionCategoria);

                // Ejecutar el procedimiento
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000) // Código de error para RAISERROR
                {
                    throw new Exception("Error: " + ex.Message);
                }
                else
                {
                    throw new Exception("Error al insertar el producto", ex);
                }
            }
        }

        // Método para obtener las descripciones de las categorías desde la base de datos
        public static List<string> ObtenerDescripcionesCategorias()
        {
            var categorias = new List<string>();

            using var connection = new SqlConnection(Conexion.ObtenerCadenaConexion());
            try
            {
                connection.Open();
                using var command = new SqlCommand("SELECT DESCRIPCION FROM CATEGORIA", connection);
                
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(reader["DESCRIPCION"]?.ToString() ?? string.Empty);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener descripciones de categorías: " + ex.Message);
            }

            return categorias;
        }

        public static List<Producto> ListarPorCategoria(int idCategoria)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();
                    string query = "SELECT IdProducto, Nombre, Precio FROM PRODUCTO WHERE IDCATEGORIA = @IDCATEGORIA ORDER BY Nombre";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        command.Parameters.AddWithValue("@IDCATEGORIA", idCategoria);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                IdProducto = reader["IdProducto"] != DBNull.Value ? Convert.ToInt32(reader["IdProducto"]) : 0,
                                Nombre = reader["Nombre"]?.ToString() ?? string.Empty,
                                Precio = reader["Precio"] != DBNull.Value ? Convert.ToDecimal(reader["Precio"]) : 0m

                            };
                            lista.Add(producto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar productos por categoría: " + ex.Message);
                }
            }

            return lista;
        }





    }
}
