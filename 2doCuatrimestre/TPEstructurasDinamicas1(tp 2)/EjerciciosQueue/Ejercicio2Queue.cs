using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosQueue
{
    internal class Ejercicio2Queue
    {
        static Queue<string> llamadas = new Queue<string>();

        public static void menuEj2Queue()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║                Simulador de Call Center               ║");
                Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Llamada Entrate a la Cola                  ║");
                Console.WriteLine("║ 2. Atender la Primer Llamada de la Cola               ║");
                Console.WriteLine("║ 3. Mostrar Cola de Llamadas Pendientes por Atender    ║");
                Console.WriteLine("║ 4. Menu Ejercicios Queue                              ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarLlamada();
                        break;

                    case "2": AtenderPrimerLlamada();
                        break;

                    case "3": MostrarColaLlamadas();
                        break;

                    case "4": salir = true;
                        submenuQueue.menuQueue();
                        break;

                    default: Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                            break;

                }
            }
        }

        static void AgregarLlamada()
        {
            string digitos;
            Console.WriteLine("Ingrese los 4 ultimos digitos de la llamada entrante: ");
            digitos = Console.ReadLine();

            llamadas.Enqueue(digitos);
        }

        static void AtenderPrimerLlamada()
        {
            int contLlamadas = llamadas.Count;
            string llamadaAtend;

            if (contLlamadas != 0)
            {
                llamadaAtend = llamadas.Dequeue();

                Console.WriteLine($"La Llamada con el numero terminado en {llamadaAtend} fue atendida");

            }
            else
            {
                Console.WriteLine("No hay llamadas entrantes en cola");
            }

            Program.Pause();
        }

        static void MostrarColaLlamadas()
        {
            int contLlamadas = llamadas.Count;

            if(contLlamadas != 0)
            {
                Console.WriteLine("Cola de llamadas entrantes: \n");

                foreach (var call in llamadas)
                {
                    Console.WriteLine($"{call}");
                }
            }
            else
            {
                Console.WriteLine("La cola de llamadas entrantes esta vacia");
            }

            Program.Pause();
        }
    }
}
