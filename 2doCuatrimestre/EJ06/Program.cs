using System;

namespace dasdasdas
{
    /*EJ 6: ingresar los sueldos de empleados, sumarlos  indicar su 
			Valor 	promedio, finaliza con legajo = 0
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos = new int[100];
            int[] legajos = new int[100];
            int i = 0, suma = 0, contador = 0;
            float promedio;
            string cadena;

            do
            {
                Console.WriteLine("Ingrese el legajo del empleado (0 para finalizar):");
                cadena = Console.ReadLine();
                legajos[i] = Convert.ToInt32(cadena);

            } while (legajos[i] < 0);

            while (legajos[i] != 0 && i < 100)
            {
                do
                {
                    Console.WriteLine("Ahora ingrese el sueldo del empleado {0}: ", i + 1);
                    cadena = Console.ReadLine();
                    sueldos[i] = Convert.ToInt32(cadena);
                } while (sueldos[i] < 0);

                i = i + 1;

                do
                {
                    Console.WriteLine("Ingrese el legajo del empleado (0 para finalizar):");
                    cadena = Console.ReadLine();
                    legajos[i] = Convert.ToInt32(cadena);

                } while (legajos[i] < 0);

            }

            for (i = 0; i < 100; i++)
            {

                if (legajos[i] > 0)
                {
                    suma = suma + sueldos[i];
                    contador = contador + 1;
                }

            }

            if (contador != 0)
            {
                Console.WriteLine("Suma total de sueldos ingresados: {0}", suma);

                promedio = (float)suma / contador;

                Console.WriteLine("El promedio de sueldos es: {0}", promedio);
            }

            Console.ReadKey();
        }
    }
}