using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPListaEnlazada 
{
        public class Nodo
        {
            public int Valor;
            public Nodo? Siguiente; // se le pone "?" para que acepte "null"

            public Nodo(int valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }
    
}
