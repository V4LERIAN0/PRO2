using ProyectoParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Inventario
{
    public List<Producto> Productos { get; set; }

    public Inventario()
    {
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void ActualizarCantidad(Producto producto, int cantidad)
    {
        var prod = Productos.FirstOrDefault(p => p.Id == producto.Id);
        if (prod != null)
        {
            prod.Cantidad = cantidad;
        }
    }
}

