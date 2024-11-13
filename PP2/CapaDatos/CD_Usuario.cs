using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        // Método para listar los usuarios desde la tabla "Usuario"
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();

                    string query = @"
                        SELECT 
                            IDUSUARIO, 
                            NOMBRE, 
                            DOCUMENTO, 
                            EMAIL, 
                            PASSWORD, 
                            FECHACREACION
                        FROM Usuario";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                IDUSUARIO = reader["IDUSUARIO"] != DBNull.Value ? Convert.ToInt32(reader["IDUSUARIO"]) : 0,
                                NOMBRE = reader["NOMBRE"].ToString() ?? string.Empty,  // Garantizar que no haya nulos
                                DOCUMENTO = reader["DOCUMENTO"].ToString() ?? string.Empty,  // Garantizar que no haya nulos
                                EMAIL = reader["EMAIL"].ToString() ?? string.Empty,  // Garantizar que no haya nulos

                                PASSWORD = reader["PASSWORD"].ToString() ?? string.Empty,
                                FECHACREACION = reader["FECHACREACION"] != DBNull.Value ? Convert.ToDateTime(reader["FECHACREACION"]) : (DateTime?)null // Manejar null como nullable DateTime
                            };

                            lista.Add(usuario);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar los usuarios: " + ex.Message);
                }
            }

            return lista;
        }

        // Método para insertar un usuario en la base de datos
        public void Insertar(Usuario usuario)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();

                    // Elimina IDUSUARIO del query ya que es autoincremental
                    string query = "INSERT INTO Usuario (NOMBRE, EMAIL, PASSWORD, IDROL, FECHACREACION, DOCUMENTO) " +
                                   "VALUES (@Nombre, @Email, @Password, @IDROL, GETDATE(), @Documento)";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        // Ajustar nombres de parámetros a los correctos
                        command.Parameters.AddWithValue("@Nombre", usuario.NOMBRE ?? string.Empty); // Asegura que no sea null
                        command.Parameters.AddWithValue("@Email", usuario.EMAIL ?? string.Empty); // Asegura que no sea null
                        command.Parameters.AddWithValue("@Password", usuario.PASSWORD ?? string.Empty); // Asegura que no sea null
                        command.Parameters.AddWithValue("@IDROL", usuario.oRol?.IDROL ?? 0); // Asignar el IDROL de acuerdo a la selección
                        command.Parameters.AddWithValue("@Documento", usuario.DOCUMENTO ?? string.Empty); // Asegura que no sea null

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el usuario", ex);
                }
            }
        }


    }
}






