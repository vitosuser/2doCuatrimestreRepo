using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio3
{
    internal class NodoEj3
    {
        public string Cancion;
        public NodoEj3? Siguiente;
        public NodoEj3? Anterior;

        public NodoEj3(string cancion)
        {
            Cancion = cancion;
            Siguiente = null;
            Anterior = null;

        }

        public override string ToString()
        {
            return $"{Cancion}";
        }
    }
}
