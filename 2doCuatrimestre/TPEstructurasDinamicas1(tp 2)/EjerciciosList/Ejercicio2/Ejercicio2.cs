using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio2
{
    internal class Ejercicio2
    {
        //Aqui podria crear una lista en forma global y usarla durante toda la clase, pero voy a crear una clase aparte para la list
        static List<Tareas> lista= new List<Tareas>();
        public static void menuEj2()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║           Lista de Tareas Pendientes           ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Tarea                               ║");
                Console.WriteLine("║ 2. Marcar Tarea como Completada                ║");
                Console.WriteLine("║ 3. Mostrar Lista de Tareas Pendientes          ║");
                Console.WriteLine("║ 4. Menu Ejercicios List                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "1": AgregarTarea();
                        break;

                    case "2": EliminarTarea();
                        break;

                    case "3": ListarTareas();
                        break;

                    case "4": salir = true;
                        Program.Main();
                        break;

                }

            }
        }

        static void AgregarTarea()
        {
            string tarea;

            Console.WriteLine("Ingrese el nombre de la tarea que desea agregar: ");
            tarea = Console.ReadLine();

            lista.Add(new Tareas(tarea));

        }

        static void EliminarTarea()
        {
            int eliminarIndice;

            Console.WriteLine("Ingrese el indice de la tarea que desea eliminar: ");
            try
            {
                eliminarIndice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Debe ingresar un numero entero como indice");
                Program.Pause();
                return;
            }

            if (eliminarIndice >= 0 && eliminarIndice < lista.Count)
            {
                lista.RemoveAt(eliminarIndice);

                Console.WriteLine("Se elimino la tarea con exito");
            }
            else {

                Console.WriteLine("El indice no es valido");

            }

            Program.Pause();
        }

        static void ListarTareas()
        {
            Console.WriteLine("Lista de tareas: ");

            if (lista.Count != 0)
            {
                foreach(var tarea in lista)
                {
                    Console.WriteLine($"{tarea.Nombre}");
                }


            }
            else
            {
                Console.WriteLine("Lista de tareas vacia");
            }

            Program.Pause();
        }

    }
}
