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
                Console.WriteLine("║ 5. Menu Ejercicios List                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":AgregarCalif();
                        break;

                    case "2":PromedioCalif();
                        break;
                }
            }
        }

        static void AgregarCalif()
        {
            int calificacion;

            Console.WriteLine("Ingrese la calificacion: ");
            try
            {
                calificacion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR. Debe ingresar una calificacion numerica");
                Program.Pause();
                return;
            }
            if(calificacion >= 0 && calificacion <= 10)
            {
                miLista.Add(new Calificaciones(calificacion));
                Console.WriteLine("Se agrego la calificacion con exito!");
            }
            else
            {
                Console.WriteLine("Debe ingresar una calificacion del 1 al 10");
            }

            Program.Pause();

        }

        static void PromedioCalif()
        {
            int sumador = 0;
            int i;
            int cantCalif = miLista.Count;
            float promedio;
            
            if(cantCalif != 0)
            {
                for(i = 0; i < cantCalif; i++)
                {
                    sumador = sumador + miLista[i].Calificacion;
                }

                promedio = (float)  sumador / cantCalif;

                Console.WriteLine($"Promedio del total de calificaciones: {promedio}");
            }
            else
            {
                Console.WriteLine("La lista de calificaciones esta vacia");
            }

            Program.Pause();
        }
    }
}
