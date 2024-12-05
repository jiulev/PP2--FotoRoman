using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class Usuario
    {
        public int IDUSUARIO { get; set; }
        public string NOMBRE { get; set; } = string.Empty; // Inicializa con cadena vacía
        public string DOCUMENTO { get; set; } = string.Empty; // Inicializa con cadena vacía
        public string EMAIL { get; set; } = string.Empty; // Inicializa con cadena vacía
        public string PASSWORD { get; set; } = string.Empty; // Inicializa con cadena vacía
        public Rol oRol { get; set; } = new Rol(); // Inicializa con un nuevo objeto Rol
        public DateTime? FECHACREACION { get; set; } = null; // Permitir null como valor predeterminado
    }



    public static class UsuarioActual
    {
        public static Usuario Usuario { get; private set; }

        public static void IniciarSesion(Usuario usuario)
        {
            Usuario = usuario;
        }

        public static void CerrarSesion()
        {
            Usuario = null;
        }

        public static bool SesionIniciada => Usuario != null;
    }

}