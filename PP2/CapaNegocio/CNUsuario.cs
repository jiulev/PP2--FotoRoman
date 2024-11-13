using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        // Método para listar los usuarios
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        // Método para insertar un usuario
        public void Insertar(Usuario usuario)
        {
            objcd_usuario.Insertar(usuario);
        }
    }
}


