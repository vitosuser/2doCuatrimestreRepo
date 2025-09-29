using System;
using System.Collections;

namespace TPCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Queue miCola = new Queue();
            Console.WriteLine("Fila supermercado \n");

            miCola.Enqueue("Silvia");
            miCola.Enqueue("Bruno");
            miCola.Enqueue("Lucas");

            int tamanioCola = miCola.Count;

            Console.WriteLine("Personas en la cola: "+ tamanioCola + "\n");

            //Puedo clonar una cola antes de hacer el Dequeue
            Queue filaClon = (Queue)miCola.Clone();

            //Me fijo que elemento esta al frente de la cola

            Console.WriteLine("Al frente de la cola esta: " + miCola.Peek() + "\n");

            Console.WriteLine("Cola: \n");

            for (i = 0; i < tamanioCola; i++)
            {
                Console.WriteLine(miCola.Dequeue());
            }

            Console.WriteLine("Se atendieron todas las personas en la cola \n");
            Console.WriteLine("Cantidad de personas en la cola ahora: " + miCola.Count + "\n");


            //Recorro la cola clon sin hacer Dequeue, osea que no modifico valores dentro de ella
            Console.WriteLine("Personas atendidas: \n");

            foreach (var pers in filaClon)
            {
                Console.WriteLine(pers);
            }

            //Puedo verificar si existe un valor en la cola

            Console.WriteLine("Esta Lucas en la cola? " + filaClon.Contains("Lucas") + "\n");
            Console.WriteLine("Esta Gabriel en la cola? " + filaClon.Contains("Gabriel") + "\n");

            //Vacio la filaClon

            filaClon.Clear();

            Console.ReadKey();
        }
    }
}
