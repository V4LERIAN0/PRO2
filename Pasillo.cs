using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace ProyectoParcial
{
    public class Pasillo
    {
        public string Nombre { get; set; }
        public List<Estante> Estantes { get; set; }

        public Pasillo(string nombre)
        {
            Nombre = nombre;
            Estantes = new List<Estante>();
        }
    }
}
