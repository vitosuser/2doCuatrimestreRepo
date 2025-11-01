namespace TPArchivosEj1
{
    internal class Program
    {
        static GestorTareas gestor = new GestorTareas();
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║                Gestor de Tareas                ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Tarea                               ║");
                Console.WriteLine("║ 2. Listar Tareas                               ║");
                Console.WriteLine("║ 3. Marcar como Completada                      ║");
                Console.WriteLine("║ 4. Eliminar tarea                              ║");
                Console.WriteLine("║ 5. Salir                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;

                    case "2":
                        ListarTareas();
                        break;

                    case "3":
                        TareaCompletada();
                        break;

                    case "4":
                        EliminarTarea();
                        break;

                    case "5":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 5");
                        Pause();
                        break;

                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese el nombre de la tarea: ");
            string descripcion = Console.ReadLine();
            gestor.AgregarTarea(descripcion);
            Pause();

        }

        static void TareaCompletada()
        {
            gestor.ListarTareas();
            Console.WriteLine("Ingrese el indice de la tarea a completar: ");
            string indice = Console.ReadLine();

            if(int.TryParse(indice, out int numero))
            {
                gestor.TareaCompletada(numero);
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero entero");
            }

            Pause();

        }
        static void EliminarTarea()
        {
            gestor.ListarTareas();
            Console.WriteLine("Ingrese el indice de la tarea a eliminar: ");
            string indice = Console.ReadLine();

            if (int.TryParse(indice, out int numero))
            {
                gestor.EliminarTarea(numero);
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero entero");
            }

            Pause();
        }

        static void ListarTareas()
        {
            gestor.ListarTareas();
            Pause();

        }

            public static void Pause()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Oprima una tecla para continuar");
                Console.ReadKey();
            }
    }
}
