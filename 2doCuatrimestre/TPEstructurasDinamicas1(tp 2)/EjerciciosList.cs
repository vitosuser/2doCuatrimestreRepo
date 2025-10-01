using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_
{
    class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set;  }
    }
    internal class EjerciciosList
    {
        static void menu() {

            bool volver = false;

            while (!volver) {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║                Ejercicios List                 ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Gestion Inventario Tienda                   ║");
                Console.WriteLine("║ 2. Lista de Tareas Pendientes                  ║");
                Console.WriteLine("║ 3. Registro de Calificaciones Alumnos          ║");
                Console.WriteLine("║ 4. Menu Principal                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1": Ejercicio1();
                            break;
                    case "2": Ejercicio2();
                            break;
                    case "3": Ejercicio3();
                            break;
                    case "4": volver = true;
                        break;

                    default: Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }

            }
        }

        static void Ejercicio1()
        {
            bool salir = false;
            List<string> miLista = new List<string>();

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
                        Console.WriteLine("\nIngrese el nombre del producto que desea agregar");
                        break;

                    case "2": BuscarP();
                        break;

                    case "3": EliminarP();
                        break;

                    case "4": menu();
                        break;

                    default: Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;

                }

            }
        }
    }
}
