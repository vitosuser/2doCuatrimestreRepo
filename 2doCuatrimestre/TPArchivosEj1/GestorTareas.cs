using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj1
{
    public class GestorTareas
    {
        private const string TAREA_FILE = "tareas.txt";

        public GestorTareas()
        {
            if (!File.Exists(TAREA_FILE))
            {
                File.Create(TAREA_FILE).Close();
            }
        }

        private List<Tarea> LeerTareas()
        {
            var tareas = new List<Tarea>();

            string[] lineas = File.ReadAllLines(TAREA_FILE);


            foreach (string linea in lineas)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                try
                {
                    Tarea tarea = Tarea.Parse(linea);
                    tareas.Add(tarea);
                }
                catch(FormatException)
                {
                    Console.WriteLine("ERROR de Formato");
                }
            }

            return tareas;
        }

        private void GuardarTareas(List<Tarea> tareas)
        {
           var lineasParaGuardar = new List<string>();

            foreach (var tarea in tareas)
            {
                lineasParaGuardar.Add(tarea.ToString());
            }

            File.WriteAllLines(TAREA_FILE, lineasParaGuardar);
        }

        public void AgregarTarea(string descripcion)
        {
            if (!string.IsNullOrEmpty(descripcion))
            {
                List<Tarea> tareas = LeerTareas();
                tareas.Add(new Tarea(descripcion, false));
                GuardarTareas(tareas);
                Console.WriteLine("Se agrego la tarea exitosamente");
            }
            else
            {
                Console.WriteLine("La descripción no puede estar vacía.");
            }
        }

        public void ListarTareas()
        {
            List<Tarea> tareas = LeerTareas();

            int cantTareas = tareas.Count;

            if(cantTareas != 0)
            {
                Console.WriteLine("--------------LISTA DE TAREAS-----------------");
                int i;
                for(i = 0; i < cantTareas; i ++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
            else
            {
                Console.WriteLine("La lista de tareas esta vacia");
            }

        }

        public void TareaCompletada(int numero)
        {
            List<Tarea> tareas = LeerTareas();

            int cantTareas = tareas.Count;

            if (numero >= 1 && numero <= cantTareas)
            {
                int indice = numero - 1;

                if (tareas[indice].Completada == true)
                {
                    Console.WriteLine("La tarea ya estaba completada");
                }
                else
                {
                    tareas[indice].Completada = true;
                    GuardarTareas(tareas);
                    Console.WriteLine("Tarea marcada como completada");
                }
            }
            else
            {
                Console.WriteLine($"Indice fuera del rango (no existe tarea numero {numero})");
            }
        }

        public void EliminarTarea(int numero)
        {
            List<Tarea> tareas = LeerTareas();

            int cantTareas = tareas.Count;

            if (numero >= 1 && numero <= cantTareas)
            {
                int indice = numero - 1;

                tareas.RemoveAt(indice);
                GuardarTareas(tareas);
                Console.WriteLine("Tarea eliminada");
            }
            else
            {
                Console.WriteLine($"Indice fuera del rango (no existe tarea numero {numero})");
            }

        }
    }
}
