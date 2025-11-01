namespace TPArchivosEj3
{
    internal class Program
    {
        static GestorVentas gestor = new GestorVentas();
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║               Control de Ventas                ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Registrar Nueva Venta                       ║");
                Console.WriteLine("║ 2. Mostrar Ventas                              ║");
                Console.WriteLine("║ 3. Calcular Total Vendido por Dia              ║");
                Console.WriteLine("║ 4. Generar Archivo Resumen                     ║");
                Console.WriteLine("║ 5. Salir                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        NuevaVenta();
                        break;

                    case "2":
                        ListarVentas();
                        break;

                    case "3":
                        TotalPorDia();
                        break;

                    case "4":
                        ArchivoResumen();
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

        static void NuevaVenta()
        {
            Console.WriteLine("Ingrese la fecha de la venta: ");
            string fechaVenta = Console.ReadLine();
            DateTime fecha;

            //verif fecha
            if(!string.IsNullOrEmpty(fechaVenta))
            {
                if (!DateTime.TryParseExact(fechaVenta, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha))
                {
                    Console.WriteLine("Formato de fecha invalido. Use DD/MM/AAAA");
                    
                }
                else
                {
                    //verif nombre prod

                    Console.WriteLine("Ingrese el nombre del producto: ");
                    string producto = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(producto))
                    {
                        Console.WriteLine("Debe ingresar un nombre de producto");
                        
                    }
                    else
                    {
                        //verif cantidad

                        Console.WriteLine("Ingrese la cantidad vendida: ");

                        if (!int.TryParse(Console.ReadLine(), out int cantidad))
                        {
                            Console.WriteLine("Debe ingresar un numero entero en la cantidad vendida");
                            
                        }
                        else
                        {
                            if(cantidad > 0)
                            {
                            //verif precio
                                Console.WriteLine("Ingrese el valor total de la venta: ");
                                if(!float.TryParse(Console.ReadLine(), out float precio))
                                {

                                Console.WriteLine("Debe ingresar un numero en el valor total de la venta");

                                }
                                else
                                {
                                    if(precio > 0)
                                    {
                                        gestor.RegistrarVenta(fecha, producto, cantidad, precio);

                                    }
                                    else
                                    {
                                        Console.WriteLine("El precio debe ser mayor a cero");
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("La cantidad debe ser mayor a cero");

                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar una fecha");
            }

            Pause();
        }

        static void ListarVentas()
        {
            gestor.Listar();
            Pause();
        }

        static void TotalPorDia()
        {
            Console.WriteLine("Ingrese la fecha: ");
            string fechaIn = Console.ReadLine();
            DateTime fecha;

            if (!string.IsNullOrWhiteSpace(fechaIn))
            {
                if (!DateTime.TryParseExact(fechaIn, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha))
                {
                    Console.WriteLine("Formato de fecha invalido. Use DD/MM/AAAA");

                }
                else
                {
                    gestor.CalcularTotalDia(fecha);

                }

            }
            else
            {
                Console.WriteLine("Debe ingresar una fecha");

            }

            Pause();

        }

        static void ArchivoResumen()
        {
            gestor.GenerarArchivo();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Oprima una tecla para continuar");
            Console.ReadKey();
        }
    }
}
