using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPEstructurasDinamicasParte2.Listas.Ejercicio3
{
    internal class Calificacion
    {

        public double Nota { get; set; }

        public Calificacion(double nota)
        {
            Nota = nota;
        }

        public override string ToString()
        {
            return $"Nota: {Nota}";
        }
    }
}
