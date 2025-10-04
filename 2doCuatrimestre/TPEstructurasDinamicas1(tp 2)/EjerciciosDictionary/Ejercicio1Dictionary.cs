using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary
{
    internal class Ejercicio1Dictionary
    {
        static Dictionary<string, string> directorio = new Dictionary<string, string>();
        public static void menuEj1Dictionary()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║             Directorio Telefonico              ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Nuevo Contacto                      ║");
                Console.WriteLine("║ 2. Buscar Contacto                             ║");
                Console.WriteLine("║ 3. Eliminar un Contacto                        ║");
                Console.WriteLine("║ 4. Menu Ejercicios Dictionary                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": NuevoContacto();
                        break;

                    case "2": BuscarContacto();
                        break;

                    case "3": EliminarContacto();
                        break;

                    case "4":salir = true;
                        submenuDictionary.menuDictionary();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }
            }
        }

        static void NuevoContacto()
        {
            string nombre, numero;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();

            if (directorio.ContainsKey(nombre))
            {
                Console.WriteLine("El contacto ya existe");
            }
            else
            {
                Console.WriteLine("Numero de telefono: ");
                numero = Console.ReadLine();

                directorio.Add(nombre, numero);

                Console.WriteLine($"{nombre} fue agregado con exito a la agenda");

            }

            Program.Pause();

        }

        static void BuscarContacto()
        {
            string buscar;
            int contadorAgenda = directorio.Count;

            if (contadorAgenda != 0)
            {
                Console.WriteLine("Ingrese el nombre del contacto que desea buscar: ");
                buscar = Console.ReadLine();

                if (directorio.ContainsKey(buscar))
                {
                    Console.WriteLine("El contacto esta en la agenda: ");
                    Console.WriteLine($"Nombre: {buscar} -- Tel: {directorio[buscar]}");

                }
                else
                {
                    Console.WriteLine("El contacto no existe en la agenda");
                    Console.WriteLine("Desea agregarlo? S / N");
                    char.TryParse(Console.ReadLine(), out char respuesta);

                    if(respuesta == 'S' || respuesta == 's')
                    {
                        NuevoContacto();
                    }
                    else
                    {
                        return;
                    }
                }

            }
            else
            {
                Console.WriteLine("La agenda esta vacia");
            }

            Program.Pause();
        }

        static void EliminarContacto()
        {
            string eliminar;
            int contadorAgenda = directorio.Count;

            if (contadorAgenda != 0)
            {
                Console.WriteLine("Ingrese el nombre del contacto que desea eliminar");
                eliminar = Console.ReadLine();

                if (directorio.ContainsKey(eliminar))
                {
                    directorio.Remove(eliminar);

                    Console.WriteLine($"Se ha eliminado {eliminar} de la agenda");
                }
                else
                {
                    Console.WriteLine($"El contacto {eliminar} no pertenece a la agenda");
                }

            }
            else
            {
                Console.WriteLine("No es posible eliminar un contacto porque la agenda esta vacia");
            }

            Program.Pause();
        }
    }
}
