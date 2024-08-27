using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Estante
    {
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }

        public Estante(string nombre)
        {
            Nombre = nombre;
            Productos = new List<Producto>();
        }
    }
}
