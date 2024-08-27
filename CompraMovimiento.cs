using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcial;

public class CompraMovimiento : Movimiento
{
    public Proveedor Proveedor { get; set; }
    public List<Producto> Productos { get; set; }

    public CompraMovimiento(int id, DateTime fecha, Proveedor proveedor)
        : base(id, fecha, "Compra")
    {
        Proveedor = proveedor;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }
}

