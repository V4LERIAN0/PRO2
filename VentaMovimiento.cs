using ProyectoParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VentaMovimiento : Movimiento
{
    public List<Producto> ProductosVendidos { get; set; }

    public VentaMovimiento(int id, DateTime fecha)
        : base(id, fecha, "Venta")
    {
        ProductosVendidos = new List<Producto>();
    }

    public void VenderProducto(Producto producto, int cantidad)
    {
        if (producto.Cantidad >= cantidad)
        {
            producto.Cantidad -= cantidad;
            ProductosVendidos.Add(producto);
        }
        else
        {
            throw new Exception("Cantidad insuficiente en inventario");
        }
    }
}
