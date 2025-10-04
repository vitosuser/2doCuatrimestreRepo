using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary
{
    internal class Ejercicio2Dictionary
    {
        static Dictionary<string, string> productos = new Dictionary<string, string>();
        public static void menuEj2Dictionary()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║       Catalogo de Productos por Codigo         ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Nuevo Producto                      ║");
                Console.WriteLine("║ 2. Buscar Producto                             ║");
                Console.WriteLine("║ 3. Menu Ejercicios Dictionary                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        NuevoProducto();
                        break;

                    case "2":
                        BuscarProducto();
                        break;

                    case "3":
                        salir = true;
                        submenuDictionary.menuDictionary();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 3");
                        Program.Pause();
                        break;
                }
            }
        }

        static void NuevoProducto()
        {
            string SKU, nombre;

            Console.WriteLine("Ingrese el codigo SKU del producto: ");
            SKU = Console.ReadLine();

            if (productos.ContainsKey(SKU))
            {
                Console.WriteLine($"El codigo SKU ya existe y corresponde al producto: {productos[SKU]}");
            }
            else
            {
                Console.WriteLine("Nombre del producto: ");
                nombre = Console.ReadLine();

                productos.Add(SKU, nombre);

                Console.WriteLine("Se agrego el producto con exito!");
            }

            Program.Pause();
        }

        static void BuscarProducto()
        {
            int contProductos = productos.Count;
            string buscado;

            if(contProductos != 0)
            {
                Console.WriteLine("SKU del producto: ");
                buscado = Console.ReadLine();

                if (productos.ContainsKey(buscado))
                {
                    Console.WriteLine($"Producto encontrado --- Nombre: {productos[buscado]}");

                }
                else
                {
                    Console.WriteLine("No se encontro el producto");
                }
            }
            else
            {
                Console.WriteLine("No hay productos cargados");
            }

            Program.Pause();
        }
    }
}
