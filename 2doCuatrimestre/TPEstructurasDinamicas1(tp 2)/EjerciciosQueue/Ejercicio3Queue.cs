using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosQueue
{
    internal class Ejercicio3Queue
    {
        static Queue<string> procesos = new Queue<string>();

        public static void menuEj3Queue()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║    Cola de Procesos en el Sistema Operativo    ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Nuevo Proceso                               ║");
                Console.WriteLine("║ 2. Ejectura Primer Proceso de la Cola          ║");
                Console.WriteLine("║ 3. Ejecutar Todos los Procesos de la cola      ║");
                Console.WriteLine("║ 4. Mostrar Cola de Procesos                    ║");
                Console.WriteLine("║ 5. Menu Ejercicios Queue                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        NuevoProceso();
                        break;

                    case "2":
                        EjecutarPrimerProceso();
                        break;

                    case "3":
                        EjecutarTodos();
                        break;

                    case "4":
                        MostrarProcesos();
                        break;

                    case "5":
                        salir = true;
                        submenuQueue.menuQueue();
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 5");
                        Program.Pause();
                        break;

                }
            }
        }

        static void NuevoProceso()
        {
            string nuevo;
            Console.WriteLine("Ingrese el nombre del nuevo proceso: ");
            nuevo = Console.ReadLine();

            procesos.Enqueue(nuevo);

        }

        static void EjecutarPrimerProceso()
        {
            int contProcesos = procesos.Count;
            string procesado;

            if (contProcesos != 0)
            {
                procesado = procesos.Dequeue();

                Console.WriteLine($"Se ha procesado el proceso llamado {procesado}");
            }
            else
            {
                Console.WriteLine("No hay procesos para ejecutar en la cola");
            }

            Program.Pause();
        }

        static void EjecutarTodos()
        {
            int contProcesos = procesos.Count;

            if(contProcesos != 0)
            {
                procesos.Clear();
                Console.WriteLine("Se han procesado todo los procesos de la cola");

            }
            else
            {
                Console.WriteLine("No hay procesos para ejecutar en la cola");

            }

            Program.Pause();
        }

        static void MostrarProcesos()
        {
            int contProcesos = procesos.Count;

            if( contProcesos != 0 )
            {
                Console.WriteLine("Cola de procesos: \n");
                foreach (string proc in procesos)
                {
                    Console.WriteLine(proc);
                }
            }
            else
            {
                Console.WriteLine("La cola de procesos esta vacia");
            }

            Program.Pause();
        }
    }
}
