using System;
using System.Collections;

namespace TPPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; 

            Stack miPila = new Stack();


            miPila.Push("Luis"); // con este comando agrego elementos a la pila
            miPila.Push("Jose");
            miPila.Push("Pedro");
            miPila.Push("Manuel");

            int tamanioPila = miPila.Count;

            Console.WriteLine("Cantidad de elementos en la pila: " + tamanioPila + "\n");
            

            //Imprimo los valores de la pila

            for (i = 0; i < tamanioPila; i ++)
            {
                Console.WriteLine("Valores de la pila: " + miPila.Pop());
            }

            //Limpio la pila

            miPila.Clear();

            Console.WriteLine("\nSe limpio la pila. Contador Pila: " + miPila.Count);

            Console.WriteLine("Agrego nuevos elementos");

            miPila.Push("Roberto"); 
            miPila.Push("Juan");
            miPila.Push("Maria");
            miPila.Push("Santiago");

            //Miro el ultimo elemento agregado sin cambiarlo, como con el miPila.Pop

            Console.WriteLine("\nUltimo elemento agregado: " + miPila.Peek() + "\n");

            //Recorro pila sin eliminar elementos como el Pop

            foreach(var elem in miPila)
            {
                Console.WriteLine(elem);
            }

            //Busco si un valor existe dentro de la pila

            Console.WriteLine("\nLa pila contiene a Juan? " + miPila.Contains("Juan"));
            Console.WriteLine("\nLa pila contiene a Thiago? " + miPila.Contains("Thiago"));

            Console.ReadKey();
        }
    }
}
