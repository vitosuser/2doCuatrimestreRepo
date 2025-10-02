using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosList
{
    
    internal class submenuList
    {
        public static void menu() {

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
                    case "1": Ejercicio1.Ejercicio1.menuEj1();
                            break;
                    case "2": Ejercicio2.Ejercicio2.menuEj2();
                            break;
                    case "3": Ejercicio3.Ejercicio3.menuEj3();
                            break;
                    case "4": volver = true;
                        Program.Main();
                        break;

                    default: Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 4");
                        Program.Pause();
                        break;
                }

            }
        }

    

                

            
        
    }
}
