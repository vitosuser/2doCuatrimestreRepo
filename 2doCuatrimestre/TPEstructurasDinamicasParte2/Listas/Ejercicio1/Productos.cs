using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstructurasDinamicasParte2.Listas.Ejercicio1
{
    internal class Productos
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Productos(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;

        }

        public override string ToString() //para imprimir en listbox
        {
            return $"Nombre: {Nombre} - Cantidad: {Cantidad}";
        }
    }
}
