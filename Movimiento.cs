using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Movimiento
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Tipo { get; set; }  // Compra, Recepción, Venta

    protected Movimiento(int id, DateTime fecha, string tipo)
    {
        Id = id;
        Fecha = fecha;
        Tipo = tipo;
    }
}

