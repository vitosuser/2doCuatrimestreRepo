namespace TPArchivosEj2
{
    internal class Program
    {
        static GestorEstudiantes gestor = new GestorEstudiantes();
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║            Registro de Estudiantes             ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Nuevo Estudiante                    ║");
                Console.WriteLine("║ 2. Mostrar Lista                               ║");
                Console.WriteLine("║ 3. Buscar Estudiante                           ║");
                Console.WriteLine("║ 4. Generar Archivo Reporte                     ║");
                Console.WriteLine("║ 5. Salir                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEstudiante();
                        break;

                    case "2":
                        ListarEstudiantes();
                        break;

                    case "3":
                        BuscarEstudiante();
                        break;

                    case "4":
                        ArchivoReporte();
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

        static void AgregarEstudiante()
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine($"Ingrese la edad del estudiante {nombre}: ");
                
                if(int.TryParse(Console.ReadLine(), out int edad))
                {
                    if (edad > 0 && edad < 100)
                    {

                        Console.WriteLine($"Ingrese el promedio del estudiante {nombre}: ");

                        if (float.TryParse(Console.ReadLine(), out float promedio))
                        {
                            if (promedio >= 0 && promedio <= 10)
                            {
                                gestor.AgregarEstudiante(nombre, edad, promedio);
                            }
                            else
                            {
                                Console.WriteLine("Debe ingresar un valor del 1 al 10 en el promedio");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un valor numerico en el promedio");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un entero en la edad");
                }
            }
            else
            {
                Console.WriteLine("Debe escribir un nombre");
            }

            Pause();

        }

        static void ListarEstudiantes()
        {
            gestor.Listar();
            Pause();
        }

        static void BuscarEstudiante()
        {
            Console.WriteLine("Ingrese el nombre del estudiante que desea buscar: ");
            string buscado = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(buscado))
            {
                gestor.BuscarPorNombre(buscado);
            }
            else
            {
                Console.WriteLine("Debe ingresar el nombre del estudiante");
            }

            Pause();
        }

        static void ArchivoReporte()
        {
            gestor.ExportarReporte();
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
