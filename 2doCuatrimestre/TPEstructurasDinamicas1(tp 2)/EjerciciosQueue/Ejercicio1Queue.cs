using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosStack;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosQueue
{
    internal class Ejercicio1Queue
    {
        static Queue<string> colaImpresion = new Queue<string>();
       public static void menuEj1Queue()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║        Cola de impresion de documentos         ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar a Cola de Impresion                 ║");
                Console.WriteLine("║ 2. Imprimir el Primer Documento de la Cola     ║");
                Console.WriteLine("║ 3. Mostrar Cola de Impresion                   ║");
                Console.WriteLine("║ 4. Menu Ejercicios Queue                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarDoc();
                        break;

                    case "2":
                        ImprimirPrimerDoc();
                        break;

                    case "3":
                        MostrarCola();
                        break;

                    case "4":
                        salir = true;
                        submenuQueue.menuQueue();
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;

                }

            }
        }

        static void AgregarDoc()
        {
            string documento;

            Console.WriteLine("Ingrese el nombre del documento a agregar a la cola: ");
            documento = Console.ReadLine();

            colaImpresion.Enqueue(documento);


        }

        static void ImprimirPrimerDoc()
        {
            string impreso;
            int docEnCola = colaImpresion.Count;


            if (docEnCola != 0)
            {
                impreso = colaImpresion.Dequeue();

                Console.WriteLine($"Se imprimio el documento {impreso} ({impreso} salio de la cola)");

            }
            else
            {
                Console.WriteLine("No hay documentos en cola");
            }

            Program.Pause();
        }

        static void MostrarCola()
        {
            int docEnCola = colaImpresion.Count;

            if(docEnCola != 0)
            {
                Console.WriteLine("Cola de impresion: \n");
                foreach (var doc in colaImpresion)
                {
                    Console.WriteLine(doc);
                }
            }
            else
            {
                Console.WriteLine("La cola de documentos esta vacia");

            }

            Program.Pause();
        }

    }
}
