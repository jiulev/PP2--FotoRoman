﻿using CapaDatos;
using CapaEntidad;
using System;

namespace CapaNegocio
{
    public class CNProducto
    {
        public bool InsertarProducto(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                mensaje = "El nombre del producto es obligatorio.";
                return false;
            }
            if (producto.Precio <= 0)
            {
                mensaje = "El precio debe ser un valor positivo.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(producto.DescripcionCategoria))
            {
                mensaje = "Debe seleccionar una categoría válida.";
                return false;
            }

            try
            {
                // Llamada al método estático Insertar de CD_Producto
                CD_Producto.Insertar(producto);
                mensaje = "Producto registrado exitosamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al registrar el producto: {ex.Message}";
                return false;
            }
        }

        // Método para obtener las descripciones de categorías
        public List<string> ObtenerDescripcionesCategorias()
        {
            return CD_Producto.ObtenerDescripcionesCategorias();
        }

        public static List<Producto> ListarPorCategoria(int idCategoria)
        {
            return CD_Producto.ListarPorCategoria(idCategoria);
        }




    }
}
