using ProyectoParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RecepcionMovimiento : Movimiento
{
    public List<Producto> Productos { get; set; }

    public RecepcionMovimiento(int id, DateTime fecha)
        : base(id, fecha, "Recepción")
    {
        Productos = new List<Producto>();
    }

    public void RecibirProducto(Producto producto, int cantidad, decimal precioVenta)
    {
        producto.Cantidad += cantidad;
        producto.CambiarPrecioVenta(precioVenta);
        Productos.Add(producto);
    }
}