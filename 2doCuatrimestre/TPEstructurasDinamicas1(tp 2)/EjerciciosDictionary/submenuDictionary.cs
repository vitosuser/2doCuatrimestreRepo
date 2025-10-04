using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosQueue;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary
{
    internal class submenuDictionary
    {
        public static void menuDictionary()
        {
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║             Ejercicios Dictionary              ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Directorio Telefonico                       ║");
                Console.WriteLine("║ 2. Catalogo de Productos por Codigo            ║");
                Console.WriteLine("║ 3. Traductor de idiomas                        ║");
                Console.WriteLine("║ 4. Menu Principal                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1":
                        Ejercicio1Dictionary.menuEj1Dictionary();
                        break;
                    case "2":
                        Ejercicio2Dictionary.menuEj2Dictionary();
                        break;
                    case "3":
                        Ejercicio3Dictionary.menuEj3Dictionary();
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
