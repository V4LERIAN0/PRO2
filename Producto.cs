using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial 
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Estatus { get; set; }

        // Nuevas propiedades para ubicación
        public string Pasillo { get; set; }
        public string Estante { get; set; }

        // Constructor principal que inicializa los campos necesarios
        public Producto(int id, string nombre, decimal precioCompra, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            PrecioCompra = precioCompra;
            PrecioVenta = 0;
            Cantidad = cantidad;

            // Inicializar propiedades adicionales con valores predeterminados
            Codigo = string.Empty;
            Categoria = string.Empty;
            Marca = string.Empty;
            Estatus = string.Empty;

            // Inicializar nuevas propiedades de ubicación
            Pasillo = string.Empty;
            Estante = string.Empty;
        }

        // Método para cambiar el precio de venta
        public void CambiarPrecioVenta(decimal nuevoPrecio)
        {
            PrecioVenta = nuevoPrecio;
        }
    }
}


