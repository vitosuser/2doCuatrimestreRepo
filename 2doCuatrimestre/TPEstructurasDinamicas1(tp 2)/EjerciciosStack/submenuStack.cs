using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio1;
using TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio2;
using TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio3;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosStack
{
    internal class submenuStack
    {
        public static void menuStack()
        {

            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║               Ejercicios Stack                 ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Simulador de Pila de Platos                 ║");
                Console.WriteLine("║ 2. Verificacion de Parentesis Balanceados      ║");
                Console.WriteLine("║ 3. Historial de Navegacion Web                 ║");
                Console.WriteLine("║ 4. Menu Principal                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1":
                        Ejercicio1Stack.menuEj1Stack();
                        break;
                    case "2":
                        Ejercicio2Stack.menuEj2Stack();
                        break;
                    case "3":
                        Ejercicio3Stack.menuEj3Stack();
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
