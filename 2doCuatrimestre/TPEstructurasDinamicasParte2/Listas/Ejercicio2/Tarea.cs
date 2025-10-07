using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicasParte2.Listas.Ejercicio2
{
    internal class Tarea
    {

        public string Nombre { get; set; }

        public Tarea(string nombre)
        {
            Nombre = nombre;
        }


        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }


}
