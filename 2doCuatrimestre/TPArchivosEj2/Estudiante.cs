using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj2
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Promedio { get; set; }

        public Estudiante(string nombre, int edad, float promedio)
        {
            Nombre = nombre.Trim();
            Edad = edad;
            Promedio = promedio;
        }

        public override string ToString()
        {
            return $"{Nombre}-{Edad}-{Promedio}";
        }

        public static Estudiante Parse(string linea)
        {
            string lineaLimpia = linea.Trim();
            string[] partes = lineaLimpia.Split('-');

            if(partes.Length != 3)
            {
                throw new FormatException("Error de formato: La linea debe tener 3 campos separados por \",\"");
            }

            try
            {
                string nombre = partes[0].Trim();
                int edad = int.Parse(partes[1].Trim());
                float promedio = float.Parse(partes[2].Trim());

                return new Estudiante(nombre, edad, promedio);
            }
            catch (Exception)
            {
                throw new FormatException("Error al parsear los datos");
            }
        }
    }
}
