using CapaDatos;
using CapaEntidad;
using System;

namespace CapaNegocio
{
    public class CNCategoria
    {
        public static void InsertarCategoria(Categoria categoria)  // Método marcado como static
        {
            CD_Categoria.Insertar(categoria);  // Llamada a método estático en CD_Categoria
        }
    }
}
