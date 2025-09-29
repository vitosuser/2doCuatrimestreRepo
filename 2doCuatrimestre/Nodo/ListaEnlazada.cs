using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPListaEnlazada //cambiar el nombre de la clase por ListaEnlazada, en vez de class2
{
    public class ListaEnlazada
    {
        private Nodo? inicio;

        // Agrega un nodo al final
        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Muestra todos los nodos
        public void Mostrar()
        {
            Nodo? actual = inicio;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // Busca un valor
        public bool Buscar(int valor)
        {
            Nodo? actual = inicio;
            while (actual != null)
            {
                if (actual.Valor == valor)
                    return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        // Elimina un nodo por valor
        public void Eliminar(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Siguiente;
                return;
            }

            Nodo actual = inicio;
            while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }

        // Inserta un nodo después de un valor específico
        public void InsertarDespuesDe(int valorExistente, int nuevoValor)
        {
            Nodo? actual = inicio;
            while (actual != null && actual.Valor != valorExistente)
            {
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                Nodo nuevo = new Nodo(nuevoValor);
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }
    }
}
