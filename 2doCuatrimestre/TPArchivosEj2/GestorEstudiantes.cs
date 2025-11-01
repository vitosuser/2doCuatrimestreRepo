using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj2
{
    public class GestorEstudiantes
    {
        private const string ESTUDIANTES_FILE = "estudiantes.txt";
        private const string REPORTE_FILE = "reporte.txt";

        public GestorEstudiantes()
        {
            if (!File.Exists(ESTUDIANTES_FILE))
            {
                File.Create(ESTUDIANTES_FILE).Close();
            }
        }

        private List<Estudiante> LeerEstudiantes()
        {
            var estudiantes = new List<Estudiante>();
            string[] lineas = File.ReadAllLines(ESTUDIANTES_FILE);

            foreach(string linea in lineas)
            {
                if(string.IsNullOrEmpty(linea)) continue;

                try
                {
                    Estudiante estudiante = Estudiante.Parse(linea);
                    estudiantes.Add(estudiante);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"ERROR al leer línea: {linea}");
                    Console.WriteLine($"Detalle: {ex.Message}");
                }
            }

            return estudiantes;
        }

        private void GuardarEstudiantes(List<Estudiante> estudiantes)
        {
            var lineasParaGuardar = new List<string>();
            foreach(var estudiante in estudiantes)
            {
                lineasParaGuardar.Add(estudiante.ToString());
            }

            File.WriteAllLines(ESTUDIANTES_FILE, lineasParaGuardar);
        }


        public void AgregarEstudiante(string nombre, int edad, float promedio)
        {
            List<Estudiante> estudiantes = LeerEstudiantes();

            estudiantes.Add(new Estudiante(nombre, edad, promedio));
            GuardarEstudiantes(estudiantes);
            Console.WriteLine("Estudiante agregado exitosamente");
        }

        public void Listar()
        {
            List<Estudiante> estudiantes = LeerEstudiantes();
            int cantEstudiantes = estudiantes.Count;

            if (cantEstudiantes > 0)
            {
                Console.WriteLine("--------------LISTA DE ESTUDIANTES-----------------");

                int i;
                for(i = 0; i < cantEstudiantes; i++)
                {
                    Console.WriteLine($"{i + 1}. {estudiantes[i]}");
                }

            }
            else
            {
                Console.WriteLine("La lista de estudiantes esta vacia");
            }

        }

        public void BuscarPorNombre(string buscado)
        {
            List<Estudiante> estudiantes = LeerEstudiantes();
            var encontrados = new List<Estudiante>();

            string nombreBuscado = buscado.ToLower();

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Nombre.ToLower().Contains(nombreBuscado))
                {
                    encontrados.Add(estudiante);
                }
            }

            if (encontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron estudiantes con el nombre '{nombreBuscado}'");
                return;
            }

            Console.WriteLine($"\nSe encontraron {encontrados.Count} estudiantes:\n");

            for (int i = 0; i < encontrados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {encontrados[i]}");
            }
        }

        public void ExportarReporte()
        {
            List<Estudiante> estudiantes = LeerEstudiantes();
            int i, j;

            int cantEstudiantes = estudiantes.Count;

            if( cantEstudiantes == 0)
            {
                Console.WriteLine("La lista de estudiantes esta vacia. No hay datos que exportar");
                return;
            }

            for (i = 0; i < cantEstudiantes - 1; i++)
            {
                for (j = 0; j < cantEstudiantes - i - 1; j++)
                {
                    if (estudiantes[j].Promedio < estudiantes[j + 1].Promedio)
                    {
                        Estudiante temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }

            try
            {
                var lineasReporte = new List<string>();

                for(i = 0; i < cantEstudiantes; i++)
                {
                    lineasReporte.Add($"{i + 1}. {estudiantes[i].ToString()}");

                }
                File.WriteAllLines(REPORTE_FILE, lineasReporte);

                Console.WriteLine("Reporte exportado exitosamente");
            }
            catch(Exception)
            {
                Console.WriteLine("Error al exportar el reporte");
            }
        }
    }
}
