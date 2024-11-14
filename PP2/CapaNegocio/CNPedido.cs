using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNPedido
    {
        // Método para procesar un pedido y sus detalles
        public static bool ProcesarPedido(Pedido pedido, List<DetallePedido> detalles, out string mensaje)
        {
            mensaje = string.Empty;

            // Validar los datos del pedido
            if (pedido.ocliente == null || pedido.ocliente.IDCliente <= 0)
            {
                mensaje = "El cliente es inválido.";
                return false;
            }
            if (pedido.oUsuario == null || pedido.oUsuario.IDUSUARIO <= 0)
            {
                mensaje = "El usuario es inválido.";
                return false;
            }
            if (detalles == null || detalles.Count == 0)
            {
                mensaje = "El pedido no tiene detalles.";
                return false;
            }

            try
            {
                // Llamar al método de la capa de datos para insertar el pedido y sus detalles
                bool resultado = CD_Pedido.InsertarPedido(pedido, detalles);

                if (resultado)
                {
                    mensaje = "Pedido procesado exitosamente.";
                    return true;
                }
                else
                {
                    mensaje = "Error al procesar el pedido en la capa de datos.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al procesar el pedido: {ex.Message}";
                return false;
            }
        }

        // Método para obtener el próximo número de pedido
        public static int ObtenerProximoNumeroPedido()
        {
            try
            {
                int ultimoId = CD_Pedido.ObtenerUltimoIdPedido();
                return ultimoId + 1;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el próximo número de pedido: {ex.Message}");
            }
        }
    }
}
