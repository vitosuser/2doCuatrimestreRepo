using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosDictionary
{
    internal class Ejercicio3Dictionary
    {
        static Dictionary<string, string> traducciones = new Dictionary <string, string>();
        public static void menuEj3Dictionary()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║              Traductor de Idiomas              ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Traduccion                          ║");
                Console.WriteLine("║ 2. Buscar Traduccion                           ║");
                Console.WriteLine("║ 3. Lista de Traducciones                       ║");
                Console.WriteLine("║ 4. Menu Ejercicios Dictionary                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTraduccion();
                        break;

                    case "2":
                        BuscarTraduccion();
                        break;

                    case "3":
                        ListarTraducciones();
                        break;

                    case "4":
                        salir = true;
                        submenuDictionary.menuDictionary();
                        break;

                    default:
                        Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }
            }
        }

        static void AgregarTraduccion()
        {
            string ingles, espanol;
            Console.WriteLine("Termino en ingles: ");
            ingles = Console.ReadLine();

            if (traducciones.ContainsKey(ingles))
            {
                Console.WriteLine("El termino en ingles ya existe");
            }
            else
            {
                Console.WriteLine("Significado en español: ");
                espanol = Console.ReadLine();

                traducciones.Add(ingles, espanol);

                Console.WriteLine("Se agrego la traduccion con exito");
            }

            Program.Pause();
        }

        static void BuscarTraduccion()
        {
            string buscado;
            int contTraducciones = traducciones.Count;

            if(contTraducciones != 0)
            {
                Console.WriteLine("Termino: ");
                buscado = Console.ReadLine();

                if (traducciones.ContainsKey(buscado))
                {
                    Console.WriteLine($"Significado en español: {traducciones[buscado]}");

                }
                else
                {
                    Console.WriteLine("No se encontro el termino");
                }

            }
            else
            {

                Console.WriteLine("No hay ninguna traduccion almacenada");

            }

            Program.Pause();

        }

        static void ListarTraducciones()
        {
            int contTraducciones = traducciones.Count;

            if(contTraducciones != 0)
            {
                Console.WriteLine("Traducciones almacenadas: \n");

                foreach(var trad in traducciones)
                {
                    Console.WriteLine($"Ingles: {trad.Key} --- Español: {trad.Value} \n");
                }
            }
            else
            {
                Console.WriteLine("No hay ninguna traduccion almacenada");
            }

            Program.Pause();
        }
    }
}
