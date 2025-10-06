using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio3
{
    internal class Ejercicio3LinkedList
    {
        private static NodoEj3? actual;

        public Ejercicio3LinkedList()
        {
            actual = null;
        }

        public static void menuEj3LinkedList()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║        Lista de Reproduccion de Musica         ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Cancion                             ║");
                Console.WriteLine("║ 2. Reproducir Siguiente Cancion                ║");
                Console.WriteLine("║ 3. Reproducir Cancion Anterior                 ║");
                Console.WriteLine("║ 4. Eliminar Cancion de la Lista                ║");
                Console.WriteLine("║ 5. Mostrar Lista de Reproduccion               ║");
                Console.WriteLine("║ 6. Menu Ejercicios LinkedList                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCancion();
                        break;

                    case "2":
                        ReproducirSiguiente();
                        break;

                    case "3":
                        ReproducirAnterior();
                        break;

                    case "4":
                        EliminarCancion();
                        break;

                    case "5":
                        MostrarLista();
                        break;

                    case "6":
                        salir = true;
                        submenuLinkedList.menuLinkedList();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 6");
                        Program.Pause();
                        break;
                }
            }
        }

        static void AgregarCancion()
        {
            string cancion;

            Console.WriteLine("Nombre de la cancion: ");
            cancion = Console.ReadLine();

            NodoEj3 nuevo = new NodoEj3(cancion);

            if (actual == null)
            {

                actual = nuevo;

            }
            else
            {
                NodoEj3 aux = actual;

                while(aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;

            }

            Program.Pause();
        }

        static void ReproducirSiguiente()
        {
            if(actual == null)
            {
                Console.WriteLine("La lista de reproduccion esta vacia, no existe una cancion siguiente");
            }
            else
            {
                if(actual.Siguiente == null)
                {
                    Console.WriteLine("Esta en la ultima cancion, no existe una cancion siguiente");
                }
                else
                {
                    actual = actual.Siguiente;

                    Console.WriteLine($"Se paso a la siguiente cancion. Esta escuchando {actual.Cancion}");
                }
            }

            Program.Pause();
        }

        static void ReproducirAnterior()
        {
            if (actual == null)
            {
                Console.WriteLine("La lista de reproduccion esta vacia, no existe una cancion siguiente");
            }
            else
            {
                if(actual.Anterior == null)
                {
                    Console.WriteLine("Esta en la primera cancion de la lista");
                }
                else
                {
                    actual = actual.Anterior;

                    Console.WriteLine($"Se paso a la cancion anterior. Esta escuchando {actual.Cancion}");
                }
            }

            Program.Pause();
        }

        static void EliminarCancion()
        {
            bool encontrada = false;

            if (actual == null)
            {
                Console.WriteLine("La lista de reproduccion esta vacia, no se puede eliminar");
            }
            else
            {
                Console.WriteLine("Nombre de la cancion que desea eliminar: ");
                string eliminar = Console.ReadLine();


                NodoEj3 aux = actual;

                while(aux.Anterior != null) //voy al principio de la lista
                {
                    aux = aux.Anterior;
                }

                while(aux != null && !encontrada )
                {
                    if(aux.Cancion.Equals(eliminar, StringComparison.OrdinalIgnoreCase))
                    {

                        if(aux.Anterior != null)
                        {
                            aux.Anterior.Siguiente = aux.Siguiente; // si existe el nodo anterior a aux, que salte directamente al nodo siguiente de aux
                        
                        }
                        if(aux.Siguiente != null)
                        {
                            aux.Siguiente.Anterior = aux.Anterior; //si existe el nodo siguiente a aux, que su nodo anterior pase a ser el anterior de aux
                        
                        }

                        if(aux == actual)
                        {
                            actual = aux.Siguiente ?? aux.Anterior; //si la que se elimina es la que se esta reproduciendo, que se reproduza la siguiente o sino la anterior
                        }

                        encontrada = true;
                        break; //salgo cuando la encuentro para no entrar en un bucle infinito
                    }
                }
            }

            if (!encontrada)
            {
                Console.WriteLine("La cancion no se encontro en la lista de reproduccion");
            }

            Program.Pause();
        }

        static void MostrarLista()
        {
            if (actual == null)
            {
                Console.WriteLine("La lista de reproduccion esta vacia");
            }
            else
            {
                NodoEj3 aux = actual;

                while (aux.Anterior != null) //voy al primer nodo
                {
                    aux = aux.Anterior;
                }

                Console.WriteLine("Lista de reproduccion: ");

                while (aux != null)
                {
                    if (aux == actual)
                    {
                        Console.WriteLine($"{aux.Cancion} (Actual)");

                    }
                    else
                    {
                        Console.WriteLine($"{aux.Cancion}");


                    }

                    aux = aux.Siguiente;


                }

                Program.Pause();

            }
        }
    }
}
