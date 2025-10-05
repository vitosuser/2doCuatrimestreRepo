using System;
using System.Collections;

namespace TPEstructurasDinamicas1_tp_2_
{
    internal class Program
    {
        public static void Main()
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
                
                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1": EjerciciosList.submenuList.menu();
                        break;

                    case "2": //EjerciciosLinkedList();
                        break;

                    case "3": EjerciciosStack.submenuStack.menuStack();
                        break;

                    case "4": EjerciciosQueue.submenuQueue.menuQueue();
                        break;

                    case "5": EjerciciosDictionary.submenuDictionary.menuDictionary();
                        break;

                    case "6": salir = true;
                        Console.WriteLine("Fin del programa");
                        break;

                    default: 
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 6");
                        Pause(); 
                        break;
                }
            }
        }

        public static void Pause()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Oprima una tecla para continuar");
            Console.ReadKey();
        }
    }
}
