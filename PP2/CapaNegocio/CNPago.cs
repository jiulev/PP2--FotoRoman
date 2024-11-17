using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNPago
    {
        // Método para insertar una lista de pagos
        public static bool InsertarPagos(List<Pago> detallesPago, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                // Recorrer cada pago y llamarlo a la capa de datos
                foreach (var pago in detallesPago)
                {
                    // Llamar al método de la capa de datos para insertar el pago
                    CD_Pago.InsertarPago(pago);
                }

                mensaje = "Pagos insertados exitosamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al insertar los pagos: {ex.Message}";
                return false;
            }
        }
    }
}
