using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicas1_tp_2_.EjerciciosStack
{
    internal class Ejercicio2Stack
    {
        static Stack<char> caracteres = new Stack<char>();

        public static void menuEj2Stack()
        {
            bool salir = false;

            while (!salir) {

                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║        Verificador Parentesis Balancedos       ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar caracter                            ║");
                Console.WriteLine("║ 2. Verificar Parentesis/Llaves/Corchetes       ║");
                Console.WriteLine("║ 3. Menu Ejercicios Stack                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarCaracter();
                        break;

                    case "2": Verificacion();
                        break;

                    case "3": salir = true;
                        submenuStack.menuStack();
                        break;

                    default: Console.WriteLine("No se ingreso un valor valido. Ingrese un numero del 1 al 3");
                        Program.Pause();
                        break;
                }

            }
        }

        static void AgregarCaracter()
        {
            Console.WriteLine("Ingrese el caracter que desea agregar: ");
            char caracter = char.Parse(Console.ReadLine());

            caracteres.Push(caracter);

        }

        static void Verificacion()
        {
            int cantCaract = caracteres.Count;
            char ultimoCaract; //variable que voy a usar luego para verificar que se hay abierto el simbolo antes de cerrarlo

           string expresion = string.Join("", caracteres);

            //creo otra pila para guardar los simbolos, separandolos de los demas caracteres
            Stack<char> simbolos = new Stack<char>();
            if(cantCaract != 0)
            {
                foreach (char caract in expresion.Reverse())// reverse porque sino, por la naturaleza de una pila, me quedaria al reves
                {
                    if (caract == '(' || caract == '{' || caract == '[')
                    {
                        simbolos.Push(caract);
                    }
                    else if (caract == ')' || caract == '}' || caract == ']')
                    {
                        if (simbolos.Count == 0) //si no hay ningun caracter, signfica que no se abrio ningun simbolo
                        {
                            Console.WriteLine("Se cerro un simbolo sin que haya sido abierto en un principio");
                            return;
                        }
                        else
                        {
                            ultimoCaract = simbolos.Pop();

                            if(caract == ')' && ultimoCaract != '(' || caract == '}' && ultimoCaract != '{' || caract == ']' && ultimoCaract != '[')
                            {
                                Console.WriteLine("Los simbolos de la expresion NO estan correctamente balanceados o anidados");
                                Program.Pause();
                                return;
                            }
                            
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }

            if (simbolos.Count == 0)
            {
                Console.WriteLine("Los simbolos estan correctamente anidados y balancedos");
            }
            else
            {
                Console.WriteLine("Faltan cerrar simbolos");
            }

                Program.Pause();
        }



    } 
}
