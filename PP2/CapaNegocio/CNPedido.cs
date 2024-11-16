using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNPedido
    {
        // Método para insertar un pedido y sus detalles
        public static bool InsertarPedido(int idCliente, int idUsuario, decimal total, DateTime fechaPedido, string estado, List<DetallePedido> detalles, out string mensaje)
        {
            mensaje = string.Empty;

            // Validar datos del pedido
            if (idCliente <= 0)
            {
                mensaje = "El ID del cliente es inválido.";
                return false;
            }
            if (idUsuario <= 0)
            {
                mensaje = "El ID del usuario es inválido.";
                return false;
            }
            if (detalles == null || detalles.Count == 0)
            {
                mensaje = "El pedido no tiene detalles.";
                return false;
            }

            try
            {
                // Llamar al método de la capa de datos para insertar el pedido
                bool resultado = CD_Pedido.InsertarPedido(idCliente, idUsuario, total, fechaPedido, estado, detalles);

                if (resultado)
                {
                    mensaje = "Pedido insertado exitosamente.";
                    return true;
                }
                else
                {
                    mensaje = "Error al insertar el pedido en la base de datos.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al insertar el pedido: {ex.Message}";
                return false;
            }
        }

        // Método para obtener el próximo número de pedido
        public static int ObtenerProximoNumeroPedido()
        {
            try
            {
                return CD_Pedido.ObtenerUltimoIdPedido() + 1;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el próximo número de pedido: {ex.Message}");
            }
        }
    }
}
