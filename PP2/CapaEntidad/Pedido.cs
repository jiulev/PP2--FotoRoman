using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedido
    {

        public int IDPEDIDO { get; set; }
        public Cliente ocliente { get; set; }
        public Usuario oUsuario { get; set; }
        public decimal TOTAL { get; set; }
        public string FECHAPEDIDO { get; set; }
        public string ESTADO { get; set; }

    }
}
