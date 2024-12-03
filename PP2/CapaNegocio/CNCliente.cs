using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    public class CNCliente
    {
        // Obtener lista completa de clientes
        public static List<Cliente> ListarClientes()
        {
            return CD_Cliente.Listar();
        }

        // Insertar un nuevo cliente
        public static bool InsertarCliente(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación del documento
            if (cliente.DOCUMENTO <= 0)
            {
                mensaje = "El documento debe ser un número válido.";
                return false;
            }

            // Validación del nombre
            if (string.IsNullOrWhiteSpace(cliente.NOMBRE))
            {
                mensaje = "El nombre es obligatorio.";
                return false;
            }

            // Validación del correo
            if (string.IsNullOrWhiteSpace(cliente.CORREO))
            {
                mensaje = "El correo es obligatorio.";
                return false;
            }
            else if (!EsCorreoValido(cliente.CORREO))
            {
                mensaje = "El correo no tiene un formato válido.";
                return false;
            }

            try
            {
                CD_Cliente.Insertar(cliente);
                mensaje = "Cliente registrado exitosamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar el cliente: " + ex.Message;
                return false;
            }
        }

        // Método auxiliar para validar formato de correo
        private static bool EsCorreoValido(string correo)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patronCorreo);
        }

        // Obtener nombres de clientes para autocompletado
        public static List<string> ObtenerNombresClientes()
        {
            return CD_Cliente.ObtenerNombresClientes();
        }
    }
}
