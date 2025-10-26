using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8EJ2
{
    public class Nodo
    {
        public string Nombre;
        public Nodo? Izquierdo;
        public Nodo? Derecho;

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
