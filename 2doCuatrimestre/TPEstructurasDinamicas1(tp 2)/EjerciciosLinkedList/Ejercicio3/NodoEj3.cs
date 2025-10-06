using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio3
{
    internal class NodoEj3
    {
        public string Cancion;
        public NodoEj3? Anterior;
        public NodoEj3? Siguiente;

        public NodoEj3(string cancion)
        {
            Cancion = cancion;
            Anterior = null;
            Siguiente = null;
        }
    }
}
