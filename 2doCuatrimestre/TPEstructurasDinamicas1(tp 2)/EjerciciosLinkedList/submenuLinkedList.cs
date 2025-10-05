using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList
{
    internal class submenuLinkedList
    {
        public static void menuLinkedList()
        {
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║             Ejercicios LinkedList              ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Gestion de Lista de Espera en Restaurante   ║");
                Console.WriteLine("║ 2. Historial de un Editor de Texto             ║");
                Console.WriteLine("║ 3. Lista de Reproduccion de Musica             ║");
                Console.WriteLine("║ 4. Menu Principal                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1":
                        //Ejercicio1.Ejericicio1LinkedList.menuEj1LinkedList();
                        break;
                    case "2":
                        //Ejercicio2.Ejericicio2LinkedList.menuEj2LinkedList();
                        break;
                    case "3":
                        //Ejercicio3.Ejericicio3LinkedList.menuEj3LinkedList();
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
