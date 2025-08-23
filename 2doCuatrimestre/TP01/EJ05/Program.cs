using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, i, total = 0;

            for(i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el valor {0}", i)
                cadena = Console.ReadLine();
                a = Convert.ToInt32(cadena);
                total = total + a;
            }

            Console.WriteLine("Total: {0}", total);

            Console.ReadKey();
        }
    }
}
