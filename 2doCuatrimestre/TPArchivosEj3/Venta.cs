using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj3
{
    public class Venta
    {
        public DateTime Fecha {  get; set; }
        public string Nombre {  get; set; }
        public int Cantidad {  get; set; }
        public float Precio {  get; set; }

        public Venta(DateTime fecha, string nombre, int cantidad, float precio)
        {
            Fecha = fecha;
            Nombre = nombre.Trim();
            Cantidad = cantidad;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy},{Nombre},{Cantidad},{Precio}";
        }

        public static Venta Parse(string linea)
        {
            string lineaLimpia = linea.Trim();
            string[] partes = lineaLimpia.Split(',');

            if (partes.Length != 4)
            {
                throw new FormatException("Error de formato: La linea debe tener 4 campos separados por \",\"");

            }
            try
            {
                DateTime fecha = DateTime.ParseExact(partes[0].Trim(), "dd/MM/yyyy", null);
                string nombre = partes[1].Trim();
                int cantidad = int.Parse(partes[2].Trim());
                float precio = float.Parse(partes[3].Trim());

                return new Venta(fecha, nombre, cantidad, precio);
            } 
            catch(Exception)
            {
                throw new FormatException("Error al parsear los datos");

            }
        } 
    }
}
