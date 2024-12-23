namespace CapaEntidad
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public int DOCUMENTO { get; set; }
        public string NOMBRE { get; set; } = string.Empty;
        public string CORREO { get; set; } = string.Empty;
        public int TELEFONO { get; set; }  // Nuevo campo
        public string ESTADO { get; set; } = "Activo";
        public string LOCALIDAD { get; set; } = string.Empty;
        public string PROVINCIA { get; set; } = string.Empty;
        public DateTime? FECHACREACION { get; set; }
    }
}
