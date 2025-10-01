using System;
using System.Collections;

namespace TPEstructurasDinamicas1_tp_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║                Menú Principal                  ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Ejercicios con List                         ║");
                Console.WriteLine("║ 2. Ejercicios con LinkedList                   ║");
                Console.WriteLine("║ 3. Ejercicios con Stack                        ║");
                Console.WriteLine("║ 4. Ejercicios con Queue                        ║");
                Console.WriteLine("║ 5. Ejercicios con Dictionary                   ║");
                Console.WriteLine("║ 6. Salir                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");
                //para cada menu de ejercicios crear una lista
                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1": EjerciciosList();
                        break;

                    case "2": EjerciciosLinkedList();
                        break;

                    case "3": EjerciciosStack();
                        break;

                    case "4": EjerciciosQueue();
                        break;

                    case "5": EjerciciosDictionary();
                        break;

                    case "6": salir = true;
                        Console.WriteLine("Fin del programa");
                        break;

                    default: 
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 6");
                        Pause(); // crear funcion pause
                        break;
                }
            }
        }

        public static void Pause()
        {
            Console.WriteLine("Oprima una tecla para continuar");
            Console.ReadKey();
        }
    }
}
