using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosStack
{
    internal class Ejercicio3Stack
    {
        static Stack<string> historial = new Stack<string>();
        public static void menuEj3Stack() {

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║           Historial de Navegacion Web          ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Nueva Pagina                                ║");
                Console.WriteLine("║ 2. Atras                                       ║");
                Console.WriteLine("║ 3. Mostrar Historial                           ║");
                Console.WriteLine("║ 4. Menu Ejercicios Stack                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": NuevaPagina();
                        break;

                    case "2": Atras();
                        break;

                    case "3": MostrarHistorial();
                        break;

                    case "4": salir = true;
                        break;

                    default: Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }
            }

        }

        static void NuevaPagina()
        {
            string nueva;
            Console.WriteLine("Ingrese el nombre de la nueva pagina que ha visitado: ");
            nueva = Console.ReadLine();

            historial.Push(nueva);
        }

        static void Atras()
        {
            int contPaginas = historial.Count;

            if(contPaginas > 1)
            {
                string actual = historial.Pop();
                Console.WriteLine($"Volviste desde {actual} a {historial.Peek()}");
            }
            else if(contPaginas == 1)
            {
                Console.WriteLine("No puedes volver atras porque estas en la primera pagina");
            }
            else
            {
                Console.WriteLine("El historial esta vacio");
            }

                Program.Pause();
        }

        static void MostrarHistorial()
        {
            int cantPaginas = historial.Count;
            if(cantPaginas != 0)
            {
                foreach(var pagina in historial)
                {
                    Console.WriteLine(pagina);
                }
            }
            else
            {
                Console.WriteLine("El historial esta vacio");
            }

            Program.Pause();
        }
    }
}
