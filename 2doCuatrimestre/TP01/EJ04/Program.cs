using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int val1, val2;

            Console.WriteLine("Ingrese el valor 1: ");
            cadena = Console.ReadLine();
            val1 = Convert.ToInt32(cadena);

            Console.WriteLine("Ahora ingrese el valor 2: ");
            cadena = Console.ReadLine();
            val2 = Convert.ToInt32(cadena);

            if(val1 == val2)
            {
                Console.WriteLine("Los valores ingresados son iguales");
            }
            else
            {
                Console.WriteLine("Los valores ingresados son distintos");

                if(val1 > val2)
                {
                    Console.WriteLine("El valor 1 es mayor que el valor 2");
                }
                else
                {
                    Console.WriteLine("El valor 2 es mayor que el valor 1");
                }
            }

            Console.ReadKey();
        }
    }
}
