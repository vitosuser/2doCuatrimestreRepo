using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosList.Ejercicio3
{
    internal class Ejercicio3
    {
        static List<Calificaciones> miLista = new List<Calificaciones>();

        public static void menuEj3()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║      Registro de Calificaciones de Alumnos     ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Nueva Calificacion                  ║");
                Console.WriteLine("║ 2. Calcular Promedio de Calificaciones         ║");
                Console.WriteLine("║ 3. Eliminar Calificacion Mas Baja de la Lista  ║");
                Console.WriteLine("║ 4. Eliminar Calificacion Mas Alta de la Lista  ║");
                Console.WriteLine("║ 5. Lista de Calificaciones                     ║");
                Console.WriteLine("║ 6. Menu Ejercicios List                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCalif();
                        break;

                    case "2":
                        PromedioCalif();
                        break;

                    case "3":
                        elimCalifBaja();
                        break;

                    case "4":
                        elimCalifAlta();
                        break;

                    case "5":
                        MostrarCalif();
                        break;

                    case "6":
                        salir = true;
                        submenuList.menu();
                        break;

                    default:
                        Console.WriteLine("Valor no valido. Ingrese un numero del 1 al 6");
                        Program.Pause();
                        break;
                }
            }
        }

        static void AgregarCalif()
        {

            Console.WriteLine("Ingrese la calificacion: ");

            if (int.TryParse(Console.ReadLine(), out int calificacion))

            {

                if (calificacion >= 0 && calificacion <= 10)
                {
                    miLista.Add(new Calificaciones(calificacion));
                    Console.WriteLine("Se agrego la calificacion con exito!");
                }
                else
                {
                    Console.WriteLine("Debe ingresar una calificacion del 1 al 10");
                }
            }
            else
            {
                Console.WriteLine("ERROR. Debe ingresar una calificacion numerica");

            }

            Program.Pause();

        }

        static void PromedioCalif()
        {
            int sumador = 0;
            int i;
            int cantCalif = miLista.Count;
            float promedio;

            if (cantCalif != 0)
            {
                for (i = 0; i < cantCalif; i++)
                {
                    sumador = sumador + miLista[i].Calificacion;
                }

                promedio = (float)sumador / cantCalif;

                Console.WriteLine($"Promedio del total de calificaciones: {promedio}");
            }
            else
            {
                Console.WriteLine("La lista de calificaciones esta vacia");
            }

            Program.Pause();
        }

        static void elimCalifBaja()
        {
            int cantCalif = miLista.Count;
            int i;

            Calificaciones califBaja = miLista[0];

            if (cantCalif != 0)
            {
                for (i = 0; i < cantCalif; i++)
                {
                    if (miLista[i].Calificacion < califBaja.Calificacion)
                    {
                        califBaja = miLista[i];

                    }
                }
                miLista.Remove(califBaja);

                Console.WriteLine($"Se elimino la calificacion mas baja ({califBaja.Calificacion})");
            }
            else
            {
                Console.WriteLine("La lista de calificaciones esta vacia");
            }

            Program.Pause();
        }

        static void elimCalifAlta()
        {
            int contCalif = miLista.Count;
            int i;

            Calificaciones califAlta = miLista[0];

            if (contCalif != 0)
            {
                for (i = 0; i < contCalif; i++)
                {
                    if (miLista[i].Calificacion > califAlta.Calificacion)
                    {
                        califAlta = miLista[i];
                    }
                }

                miLista.Remove(califAlta);
                Console.WriteLine($"Se elimino la calificacion mas alta ({califAlta.Calificacion})");
            }
            else
            {
                Console.WriteLine("La lista de calificaciones esta vacia");
            }

            Program.Pause();
        }

        static void MostrarCalif()
        {
            Console.WriteLine("Lista de calififaciones: \n");

            foreach(var calif in miLista)
            {
                Console.WriteLine($"{calif.Calificacion}");
            }

            Program.Pause();
        }
    }
}
