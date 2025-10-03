using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosList;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosStack
{
    internal class Ejercicio1Stack
    {
        static Stack<string> pilaPlatos = new Stack<string>();
        public static void menuEj1Stack()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║          Simulador de Pila de Platos           ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Apilar un Nuevo Plato                       ║");
                Console.WriteLine("║ 2. Desapilar Plato de Arriba                   ║");
                Console.WriteLine("║ 3. Mostrar Ultimo Plato (peek)                 ║");
                Console.WriteLine("║ 4. Mostrar Pila Platos                         ║");
                Console.WriteLine("║ 5. Menu Ejercicios Stack                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ApilarPlato();
                        break;

                    case "2":
                        DesapilarPlatoArriba();
                        break;

                    case "3":
                        MostrarUltimoPlato();
                        break;

                    case "4":
                        MostrarPila();
                        break;

                    case "5":
                        salir = true;
                        submenuStack.menuStack();
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 5");
                        Program.Pause();
                        break;

                }

            }
        }

        static void ApilarPlato()
        {
            string nombre;
            Console.WriteLine("Ingrese un nombre o numero de plato: ");
            nombre = Console.ReadLine();

            pilaPlatos.Push(nombre);

            Console.WriteLine($"Se apilo correctamente el plato {nombre}");
            Program.Pause();

        }

        static void DesapilarPlatoArriba()
        {
            int cantPlatos = pilaPlatos.Count;
            string identifDesapilado;

            if (cantPlatos != 0)
            {
                identifDesapilado = pilaPlatos.Pop();
                Console.WriteLine($"Se desapilo el plato {identifDesapilado}");
            }
            else
            {
                Console.WriteLine("La pila de platos esta vacia");
            }

            Program.Pause();
        }

        static void MostrarUltimoPlato()
        {
            int cantPlatos = pilaPlatos.Count;

            if (cantPlatos != 0)
            {
                Console.WriteLine("El plato que esta en la cima de la pila es: {0}", pilaPlatos.Peek());
            }
            else
            {
                Console.WriteLine("La pila de platos esta vacia");
            }

            Program.Pause();
        }

        static void MostrarPila()
        {
            int cantPlatos = pilaPlatos.Count;
            if (cantPlatos != 0)
            {

                Console.WriteLine("Pila de platos: ");

                foreach (var plato in pilaPlatos)
                {
                    Console.WriteLine(plato);
                }

            }
            else
            {
                Console.WriteLine("La pila de platos esta vacia");
            }

            Program.Pause();
        }
    }
}
