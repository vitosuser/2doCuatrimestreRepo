using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj1
{
    internal class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public Tarea(string descripcion, bool completada)
        {
            Descripcion = descripcion.Trim();
            Completada = completada;
        }

        public override string ToString()
        {
            string estado = Completada ? "[Completada]" : "[Pendiente]"; // operador ternario 
            return $"{estado} {Descripcion}";
        }

        public static Tarea Parse(string linea)
        {
            string lineaLimpia = linea.Trim();

            if (lineaLimpia.StartsWith("[Completada]"))
            {
                string desc = lineaLimpia.Substring("[Completada]".Length).Trim();
                return new Tarea(desc, true);
            }
            else if (lineaLimpia.StartsWith("[Pendiente]"))
            {
                string desc = lineaLimpia.Substring("[Pendiente]".Length).Trim();
                return new Tarea(desc, false);

            }
            else
            {
                throw new FormatException("Hay un formato de linea no valido");
            }
        }
    }
}
