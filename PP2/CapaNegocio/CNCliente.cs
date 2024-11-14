using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

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

            if (cliente.DOCUMENTO == 0)
            {
                mensaje = "El documento es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.NOMBRE))
            {
                mensaje = "El nombre es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.CORREO))
            {
                mensaje = "El correo es obligatorio.";
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

        // Obtener nombres de clientes para autocompletado
        public static List<string> ObtenerNombresClientes()
        {
            return CD_Cliente.ObtenerNombresClientes();
        }
    }
}
