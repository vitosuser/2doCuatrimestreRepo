using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosStack;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosQueue
{
    internal class submenuQueue
    {

        public static void menuQueue()
        {
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║               Ejercicios Queue                 ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Cola de impresion de documentos             ║");
                Console.WriteLine("║ 2. Simulador de Call Center                    ║");
                Console.WriteLine("║ 3. Cola de Procesos en el Sistema Operativo    ║");
                Console.WriteLine("║ 4. Menu Principal                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1":
                        Ejercicio1Queue.menuEj1Queue();
                        break;
                    case "2":
                        Ejercicio2Queue.menuEj2Queue();
                        break;
                    case "3":
                        Ejercicio3Queue.menuEj3Queue();
                        break;
                    case "4":
                        volver = true;
                        Program.Main();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }

            }
        }
    }
}
