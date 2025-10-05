using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio1
{
    internal class Ejercicio1LinkedList
    {
        public static void menuEj1LinkedList()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║   Gestion de Lista de Espera en Restaurante    ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Cliente                             ║");
                Console.WriteLine("║ 2. Seder asiento al Primero en la Lista        ║");
                Console.WriteLine("║ 3. Eliminar Cliente de la Lista                ║");
                Console.WriteLine("║ 4. Mostrar Lista                ║");
                Console.WriteLine("║ 5. Menu Ejercicios LinkedList                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCliente();
                        break;

                    case "2":
                        //SentarCliente();
                        break;

                    case "3":
                        //EliminarCliente();
                        break;

                    case "4":
                        //MostrarClientes();
                        break;

                    case "5":
                        salir = true;
                        submenuLinkedList.menuLinkedList();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 5");
                        Program.Pause();
                        break;
                }
            }
        }

        static void AgregarCliente()
        {

        }
    }
}
