using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio1
{
    internal class Ejercicio1
    {
        static List<Producto> miLista = new List<Producto>();

        public static void menuEj1()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║            Gestion Inventario Tienda           ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Producto                            ║");
                Console.WriteLine("║ 2. Buscar Producto                             ║");
                Console.WriteLine("║ 3. Eliminar Producto                           ║");
                Console.WriteLine("║ 4. Mostrar Lista                               ║");
                Console.WriteLine("║ 5. Menu Ejercicios List                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarProducto();
                        break;

                    case "2":
                        BuscarProducto();
                        break;

                    case "3":
                        EliminarProducto();
                        break;

                    case "4":
                        MostrarLista();
                        break;

                    case "5":
                        submenuList.menu();
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;

                }

            }
        }

        static void AgregarProducto()
        {
            string nombre;
            int cantidad;
            Console.WriteLine("\nIngrese el nombre del producto: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            miLista.Add(new Producto(nombre, cantidad));

            Console.WriteLine("Se agrego el producto con exito");
            //ver si agregar el pause
        }

        static void BuscarProducto()
        {
            string buscado;
            Console.WriteLine("Ingrese el nombre del producto que desa buscar: ");
            buscado = Console.ReadLine();

            Producto producto = miLista.Find(p => p.Nombre.Equals(buscado, StringComparison.OrdinalIgnoreCase));

            if (producto != null)
            {
                Console.WriteLine("Producto encontrado!");
                Console.WriteLine($"{producto.Nombre} - Cantidad: {producto.Cantidad}");
            }
            else
            {
                Console.WriteLine("No se encontro el producto {0} en la lista", buscado);
            }


            Program.Pause();
        }

        static void EliminarProducto()
        {
            string eliminar;

            Console.WriteLine("Ingrese el producto que desea eliminar: ");
            eliminar = Console.ReadLine();

            Producto resultado = miLista.Find(p => p.Nombre.Equals(eliminar, StringComparison.OrdinalIgnoreCase));

            if(resultado != null)
            {
                miLista.Remove(resultado);
                Console.WriteLine("Producto encontrado!");
                Console.WriteLine($"Se elimino {resultado.Nombre} - Cantidad: {resultado.Cantidad} de la lista");

            }
            else
            {
                Console.WriteLine("No se encontro el producto en la lista");
            }

            Program.Pause();
        }

        static void MostrarLista()
        {
            if (miLista.Count != 0)
            {
                Console.WriteLine("\nLista: ");

                foreach (var prod in miLista)
                {
                    Console.WriteLine($"{prod.Nombre} - Cantidad: {prod.Cantidad}");
                }
                
            }

            else
            {
                Console.WriteLine("Invenario vacio. No hay productos para mostrar");
            }

            Program.Pause();
        }
    }
}
