using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio2
{
    internal class Ejercicio2LinkedList
    {
        
        private static NodoEj2? actual;

        public Ejercicio2LinkedList()
        {
            actual = null;
        }

        public static void menuEj2LinkedList()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║       Historial de un Editor de Texto          ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Escribir                                    ║");
                Console.WriteLine("║ 2. Deshacer                                    ║");
                Console.WriteLine("║ 3. Rehacer                                     ║");
                Console.WriteLine("║ 4. Mostrar Texto Actual                        ║");
                Console.WriteLine("║ 5. Menu Ejercicios LinkedList                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Escribir();
                        break;

                    case "2":
                        Deshacer();
                        break;

                    case "3":
                        Rehacer();
                        break;

                    case "4":
                        MostrarTexto();
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

        static void Escribir()
        {
            string texto;

            Console.WriteLine("Ingrese el texto que desea escribir: ");
            texto = Console.ReadLine();

            NodoEj2 nuevo = new NodoEj2(texto);

            if(actual != null)
            {
                actual.Siguiente = nuevo;
                nuevo.Anterior = actual;
            }
            

            actual = nuevo;

            
        }

        static void Deshacer()
        {
            

            if (actual == null || actual.Anterior == null)
            {
                Console.WriteLine("No hay nada que deshacer");
            }
            else
            {

                actual = actual.Anterior;

                Console.WriteLine("Deshacer realizado");
            }

            Program.Pause();
        }

        static void Rehacer()
        {

            if (actual == null || actual.Siguiente == null)
            {
                Console.WriteLine("No hay nada que rehacer");
            }
            else
            {
                

                actual = actual.Siguiente;

                Console.WriteLine("Rehacer realizado");
            }

            Program.Pause();
        }

        static void MostrarTexto()
        {
            if(actual == null)
            {
                Console.WriteLine("El editor esta vacio. No se escribio nada");
            }
            else
            {

                Console.WriteLine("Texto: ");

                
                    Console.WriteLine($"{actual.Texto}");
                
            }

            Program.Pause();
        }

    }
}
