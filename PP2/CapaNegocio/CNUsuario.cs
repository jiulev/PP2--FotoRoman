using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNUsuario
    {
        // Instancia de la capa de datos
        private readonly CD_Usuario objcd_usuario = new CD_Usuario();

        // Método para listar los usuarios
        public List<Usuario> Listar()
        {
            CD_Usuario objcd_usuario = new CD_Usuario();
            return objcd_usuario.Listar();
        }

        // Método para insertar un usuario
        public void Insertar(Usuario usuario)
        {
            objcd_usuario.Insertar(usuario);
        }

        // Método para editar un usuario
        public void Editar(Usuario usuario)
        {
            try
            {
                if (usuario.IDUSUARIO <= 0)
                {
                    throw new System.ArgumentException("ID de usuario inválido.");
                }

                objcd_usuario.Editar(usuario);
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error al editar el usuario en la capa de negocio", ex);
            }
        }

        // Método para eliminar un usuario
        public void Eliminar(int idUsuario)
        {
            // Validaciones antes de eliminar (opcional)
            if (idUsuario <= 0)
            {
                throw new System.ArgumentException("ID de usuario inválido.");
            }

            objcd_usuario.Eliminar(idUsuario);
        }
    }
}
