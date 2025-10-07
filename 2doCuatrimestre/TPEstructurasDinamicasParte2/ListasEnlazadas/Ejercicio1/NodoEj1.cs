using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio1
{
    public class NodoEj1
    {
        public string Nombre;
        public NodoEj1? Siguiente;

        public NodoEj1(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}" ;
        }
    }
}
