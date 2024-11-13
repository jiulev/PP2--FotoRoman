using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNCliente
    {
        // Método para obtener la lista de clientes
        public static List<Cliente> ListarClientes()
        {
            return CD_Cliente.Listar();
        }

        // Método para insertar un nuevo cliente
        public static bool InsertarCliente(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de campos obligatorios
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
            if (string.IsNullOrWhiteSpace(cliente.LOCALIDAD))
            {
                mensaje = "La localidad es obligatoria.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.PROVINCIA))
            {
                mensaje = "La provincia es obligatoria.";
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
                mensaje = $"Error al registrar el cliente: {ex.Message}";
                return false;
            }
        }
    }
}
