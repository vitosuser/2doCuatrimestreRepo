using System;

namespace EJ07
{
    /*ingresar el valor de la hs de cada categoría, guardarlo en 
			Un vector y luego ingresar los empleados de la empresa 
			Hasta legajo = 0, indicar el sueldo de cada empleado y el 
			Total a pagar 
*/
    internal class Program
    {
        const int CAT = 5;
        const int FI = 100; //cantidad maxima de sueldos a cargar
        const int CO = 3; //cantidad de datos a cargar (legajo, categoria y horas)
        static void Main(string[] args)
        {
            int[] valHora = new int[CAT];
            int[,] planilla = new int[FI, CO];
            int[] sueldos = new int[FI];

            ingresoDeDatos(planilla, valHora);
            calcularSueldos(planilla, valHora, sueldos);
            contarPorCat(planilla);

            Console.ReadKey();

        }

        public static void ingresoDeDatos(int[,] planilla, int[] valHora)
        {
            int i = 0;
            string cadena;

            Console.WriteLine("-----------------INGRESO DE CATEGORIAS----------------");

            for (i = 0; i < CAT; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el valor de la hora de la categoria {i + 1} ");
                    cadena = Console.ReadLine();
                    valHora[i] = Convert.ToInt32(cadena);

                    /*o tambien puedo hacer esto: 
                     
                     Console.WriteLine($"Ingrese el valor de la hora de la categoria {i} );
                    valHora[i] = int.Parse( Console.ReadLine());
                     
                     */
                } while (valHora[i] < 0);

            }

            Console.WriteLine("-----------------INGRESO DE DATOS----------------");

            do
            {
                Console.WriteLine("Ingrese el legajo del empleado (0 para finalizar):");
                cadena = Console.ReadLine();
                planilla[i, 0] = Convert.ToInt32(cadena);

            } while (planilla[i, 0] < 0);

            while (planilla[i, 0] != 0 && i < 100)
            {
                do
                {
                    Console.WriteLine("Ingrese la categoria del legajo numero {0}: ", planilla[i, 0]);
                    planilla[i, 1] = int.Parse(Console.ReadLine());

                } while (planilla[i, 1] < 0 || planilla[i, 1] > CAT);


                do
                {
                    Console.WriteLine("Ingrese la cantidad de hs trabajadas:");
                    planilla[i, 2] = int.Parse(Console.ReadLine());

                } while (planilla[i, 2] < 0);

                i = i + 1;

                do
                {
                    Console.WriteLine("Ingrese el legajo del empleado (0 para finalizar):");
                    cadena = Console.ReadLine();
                    planilla[i, 0] = Convert.ToInt32(cadena);

                } while (planilla[i, 0] < 0);
            }
        }

        public static void calcularSueldos(int[,] planilla, int[] valHora, int[] sueldos)
        {
            int i;
            int sumaSueldos = 0;

            for (i = 0; i < FI; i++)
            {
                if (planilla[i, 0] > 0)
                {
                    if (planilla[i, 1] > 0)
                    {
                        sueldos[i] = valHora[planilla[i, 1] - 1] * planilla[i, 2];

                        Console.WriteLine($"Sueldo del legajo numero {planilla[i, 0]}: {sueldos[i]}");
                        sumaSueldos = sumaSueldos + sueldos[i];
                    }

                }

            }

            if (sumaSueldos != 0)
            {

                Console.WriteLine("Suma total de sueldos a pagar: {0}", sumaSueldos);
            }

        }

        public static void contarPorCat(int[,] planilla)
        {
            int[] contadorCat = new int[CAT];
            int i;

            for(i = 0; i < FI; i++)
            {
                if (planilla[i, 0] > 0)
                {
                    switch (planilla[i, 1]) {

                        case 1: contadorCat[0] = contadorCat[0] + 1;
                            break;
                        case 2: contadorCat[1] = contadorCat[1] + 1;
                            break;
                        case 3: contadorCat[2] = contadorCat[2] + 1;
                            break;
                        case 4: contadorCat[3] = contadorCat[3] + 1;
                            break;
                        case 5: contadorCat[4] = contadorCat[4] + 1;
                            break;

                    }
                }
            }

            for(i = 0; i < CAT; i++)
            {
                Console.WriteLine($"Cantidad de empleados en la categoria {i + 1}: {contadorCat[i]}");
            }

        }
    }
}
