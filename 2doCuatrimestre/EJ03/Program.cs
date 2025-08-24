using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena; //varibale que voy a usar para transformar todo lo leido al tipo de dato que quiera
            int valHora, tiempo, sueldo;

            Console.WriteLine("Ingrese el valor de la hora: ");
            cadena = Console.ReadLine();
            valHora = Convert.ToInt32(cadena);

            Console.WriteLine("Ingrese el tiempo trabajado: ");
            cadena = Console.ReadLine();
            tiempo = Convert.ToInt32(cadena);

            sueldo = valHora * tiempo;

            Console.WriteLine("El sueldo del empleado es: {0}", sueldo);

            Console.ReadKey();
        }
    }
}
