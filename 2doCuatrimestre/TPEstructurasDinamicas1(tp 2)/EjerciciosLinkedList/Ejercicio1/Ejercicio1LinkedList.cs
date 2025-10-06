using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosLinkedList.Ejercicio1
{
    internal class Ejercicio1LinkedList
    {
        private static NodoEj1? cabeza;

        public Ejercicio1LinkedList() // constructor
        {
            cabeza = null; // inicializo lista que no tiene nodos todavia
           
        }

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
                Console.WriteLine("║ 4. Mostrar Lista                               ║");
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
                        SentarCliente();
                        break;

                    case "3":
                        EliminarCliente();
                        break;

                    case "4":
                        MostrarClientes();
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
            string cliente;

            
            Console.WriteLine("Nombre del cliente: ");
            cliente = Console.ReadLine();

            NodoEj1 nuevo = new NodoEj1(cliente);

            if (cabeza == null) // si el nodo actual esta vacio, que inserte el nodo nuevo ahi
            {
                cabeza = nuevo;
            }
            else 
            {
                NodoEj1 actual = cabeza;

                while(actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
            }

            Console.WriteLine($"Se agrego a {cliente} a la lista");

            Program.Pause();
        }

        static void SentarCliente()
        {
            if(cabeza == null)
            {
                Console.WriteLine("La lista de espera esta vacia");
            }
            else
            {

                Console.WriteLine($"El cliente {cabeza.Nombre} fue setado en una mesa");
                cabeza = cabeza.Siguiente;

            }

            Program.Pause();
        }

        static void EliminarCliente()
        {
            string eliminar;

            if(cabeza == null)
            {
                Console.WriteLine("La lista de espera esta vacia");

            }
            else
            {
                Console.WriteLine("Nombre del cliente a eliminar");
                eliminar = Console.ReadLine();

                if(cabeza.Nombre.Equals(eliminar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Se elimino al cliente {cabeza.Nombre} de la lista");
                    cabeza = cabeza.Siguiente;

                }
                else
                {
                    NodoEj1 actual = cabeza;
                    NodoEj1 anterior = null; /* creo un nodo para enlazar el nodo anterior al siguiente del actual,
                     el actual va aser eliminado cuando se encuentre el nombre del cliente que se desea eliminar
                    y lo inicializo en nunull porque antes del nodo inicia (cabeza) no hay ningun otro*/

                    while(actual != null && !actual.Nombre.Equals(eliminar, StringComparison.OrdinalIgnoreCase))
                    {
                        anterior = actual;
                        actual = actual.Siguiente;
                    }

                    if(actual != null) // si existe algo en actual, signfica que termino el while y encontro a eliminar
                    {
                        anterior.Siguiente = actual.Siguiente; // conecto el nodo anterior al eliminado con
                                                               // el nodo siguiente al eliminado, para q no quede vacio
                        Console.WriteLine($"Se elimino de la lista de espera a {eliminar}");
                    }

                    else
                    {
                        Console.WriteLine($"{eliminar} no esta en la lista de espera");
                    }
                }
            }

            Program.Pause();
        }

        static void MostrarClientes()
        {
            if(cabeza == null)
            {
                Console.WriteLine("La lista de espera esta vacia");
            }
            else
            {
                NodoEj1 actual = cabeza;

                Console.WriteLine("Lista de espera: ");

                while(actual != null)
                {
                    Console.WriteLine($"{actual.Nombre}");
                    actual = actual.Siguiente;
                }
            }

            Program.Pause();
        }


    }
}


    

