using System;
using System.Collections.Generic; // Necesario para usar List<T>

namespace EjemploArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------
            // ARREGLO ESTÁTICO
            // ---------------------------
            int[] numerosEstaticos = new int[5]; // tamaño fijo de 5

            // Asignamos valores manualmente
            numerosEstaticos[0] = 10;
            numerosEstaticos[1] = 20;
            numerosEstaticos[2] = 30;
            numerosEstaticos[3] = 40;
            numerosEstaticos[4] = 50;

            Console.WriteLine("Arreglo estático:");
            foreach (int num in numerosEstaticos)
            {
                Console.WriteLine(num);
            }

            // ---------------------------
            // ARREGLO DINÁMICO (List<T>)
            // ---------------------------
            List<int> numerosDinamicos = new List<int>();

            // Podemos ir agregando valores dinámicamente, siempre se van a ir agregando al final de la lista

            numerosDinamicos.Add(100);
            numerosDinamicos.Add(200);
            numerosDinamicos.Add(300);

            // También podemos quitar elementos
            numerosDinamicos.Remove(200);

            //Ademas podemos insertar datos en determinadas posiciones
            //numerosDinamicos.Insert(indice, valor);

            /*en un bucle for each tenemos varios comandos utiles:
             
             numerosDinamicos.Contains(valor); verificar si el valor esta en la lista
             numerosDinamicos.IndexOf(valor); obtiene el indiice del primer valor que es igual a valor
             numerosDinamicos.RemoveAt(indice); eliminar por indice 
             numerosDinamicos.Sort(); ordena la lista de menor a mayor
             numerosDinamicos.Reverse(); invierte el orden de los elementos de la lista
             numerosDinamicos.Count; te da la cantidad de elementos en la lista, va sin ()
             numerosDinamicos.Clear(); elimina todos los elementos de la lista
            */
            Console.WriteLine("\nArreglo dinámico:");
            foreach (int num in numerosDinamicos)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
