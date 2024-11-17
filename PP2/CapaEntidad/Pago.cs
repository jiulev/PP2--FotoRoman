using System;

namespace CapaEntidad
{
    public class Pago
    {
        public int IDPAGO { get; set; }
        public int IDPEDIDO { get; set; } // ID del pedido al que pertenece el pago
        public Pedido? oPedido { get; set; }

        public decimal MONTOPAGO { get; set; }
        public DateTime FECHAPAGO { get; set; } // Tipo DateTime para manejar la fecha y hora correctamente
        public string? METODOPAGO { get; set; }
    }
}
