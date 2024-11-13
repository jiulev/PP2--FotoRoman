using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pago
    {

        public int IDPAGO { get; set; }
        public Pedido oPedido { get; set; }

        public decimal MONTOPAGO { get; set; }
        public string FECHAPAGO { get; set; }
        public string METODOPAGO { get; set; }
    }
}
