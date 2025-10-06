using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio2
{
    internal class NodoEj2
    {
        public string Texto;
        public NodoEj2? Anterior;
        public NodoEj2? Siguiente;

        public NodoEj2(string texto)
        {
            Texto = texto;
            Anterior = null;
            Siguiente = null;
        }

    }
}
