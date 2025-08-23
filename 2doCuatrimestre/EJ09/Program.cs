using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ09
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] planilla = new int[4, 4];
            int i, j;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese las horas trabajdas en la categoria: {0} depto: {1}: ", i + 1, j + 1);
                    planilla[i, j] = int.Parse(Console.ReadLine());

                }

            }

            for(i = 0; i < 4; i++)
            {

                for(j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Categoria: {i + 1}- Depto: {j + 1}- Horas trabajadas: {planilla[i, j]}");
                }
            }

            Console.ReadKey();
        }
    }
}
