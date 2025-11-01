using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArchivosEj3
{
    public class GestorVentas
    {
        private const string VENTAS_FILE = "ventas.txt";
        private const string RESUMEN_FILE = "resumen.txt";

        public GestorVentas()
        {
            if (!File.Exists(VENTAS_FILE))
            {
                File.Create(VENTAS_FILE).Close();
            }
        }

        private List<Venta> LeerVentas()
        {
            var ventas = new List<Venta>();

            string[] lineas = File.ReadAllLines(VENTAS_FILE);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                try
                {
                    Venta venta = Venta.Parse(linea);
                    ventas.Add(venta);

                }
                catch (FormatException)
                {
                    Console.WriteLine($"ERROR al leer linea: {linea}");
                }
            }
            return ventas;
        }

        private void GuardarVentas(List<Venta> ventas)
        {
            var lineasParaGuardar = new List<string>();

            foreach (var venta in ventas)
            {
                lineasParaGuardar.Add(venta.ToString());
            }

            File.WriteAllLines(VENTAS_FILE, lineasParaGuardar);
        }

        public class ResumenProducto
        {
            public string NombreProducto { get; set; }
            public int CantidadTotal { get; set; }
            public float VentaTotal { get; set; }
            public int NumeroVentas { get; set; }
        }

        public void RegistrarVenta(DateTime fecha, string nombre, int cantidad, float precio)
        {
            List<Venta> ventas = LeerVentas();
            ventas.Add(new Venta(fecha, nombre, cantidad, precio));
            GuardarVentas(ventas);

        }

        public void Listar()
        {
            List<Venta> ventas = LeerVentas();

            int cantVentas = ventas.Count;

            if (cantVentas > 0)
            {
                Console.WriteLine("-------------VENTAS----------------");

                int i;

                for (i = 0; i < cantVentas; i++)
                {
                    Console.WriteLine($"{i + 1}. {ventas[i].ToString()}");
                }

            }
            else
            {
                Console.WriteLine("No se registraron ventas");
            }

        }

        public void CalcularTotalDia(DateTime fecha)
        {
            List<Venta> ventas = LeerVentas();
            int cantVentas = ventas.Count;

            if(cantVentas > 0)
            {
                float totalDia = 0;
                int cantVendida = 0;

                foreach (var venta in ventas)
                {
                    if(venta.Fecha.Date == fecha.Date)
                    {
                        totalDia = totalDia + venta.Precio;
                        cantVendida = cantVendida + 1;
                    }
                }

                if(cantVendida > 0)
                {
                    Console.WriteLine($"-------------VENTAS {fecha:dd/MM/yyyy}----------------");
                    Console.WriteLine($"Cantidad Vendida: {cantVendida}");
                    Console.WriteLine($"Total Vendido: {totalDia}");

                }
                else
                {
                    Console.WriteLine($"No se registraron ventas en el dia {fecha:dd/MM/yyyy}");
                }
            }
            else
            {
                Console.WriteLine("No existen ventas registradas");
            }

        } 

        public void GenerarArchivo()
        {
            List<Venta> ventas = LeerVentas();

            if( ventas.Count > 0 )
            {
                var resumenProductos = new Dictionary<string, ResumenProducto>();

                foreach (var venta in ventas)
                {
                    string productoLimpio = venta.Nombre.ToLower();

                    if (resumenProductos.ContainsKey(productoLimpio))
                    {
                        resumenProductos[productoLimpio].CantidadTotal += venta.Cantidad;
                        resumenProductos[productoLimpio].VentaTotal += venta.Precio;
                        resumenProductos[productoLimpio].NumeroVentas++;
                    }
                    else
                    {
                        resumenProductos[productoLimpio] = new ResumenProducto
                        {
                            NombreProducto = venta.Nombre,
                            CantidadTotal = venta.Cantidad,
                            VentaTotal = venta.Precio,
                            NumeroVentas = 1
                        };
                    }
                }

                // convierto diccionario a lista para ordenar
                var listaResumen = new List<ResumenProducto>();

                foreach (var kvp in resumenProductos)
                {
                    listaResumen.Add(kvp.Value);
                }

                // ordeno por venta total de forma descendente
                int listaCant = listaResumen.Count;
                
                for (int i = 0; i < listaCant - 1; i++)
                {
                    for (int j = 0; j < listaCant - i - 1; j++)
                    {
                        if (listaResumen[j].VentaTotal < listaResumen[j + 1].VentaTotal)
                        {

                        ResumenProducto temp = listaResumen[j];
                        listaResumen[j] = listaResumen[j + 1];
                        listaResumen[j + 1] = temp;

                        }
                    }
                }

                try
                {
                    var lineasResumen = new List<string>();

                    Console.WriteLine("----------------RESUMEN VENTAS EN ORDEN DESCENDENTE-------------");

                    for (int i = 0; i < listaResumen.Count; i++)
                    {
                        ResumenProducto resumen = listaResumen[i];

                        lineasResumen.Add($"{i + 1}. Producto: {resumen.NombreProducto} - Cantidad vendida: {resumen.CantidadTotal} - Ventas: {resumen.NumeroVentas} | Total: ${resumen.VentaTotal}");
                    }

                    File.WriteAllLines(RESUMEN_FILE, lineasResumen);

                    Console.WriteLine($"Resumen exportado exitosamente a '{RESUMEN_FILE}'");
                   
                }
                catch (Exception)
                {
                    Console.WriteLine($"Error al generar el resumen");
                }
            }
            else
            {
                Console.WriteLine("No hay ventas para generar el resumen");
            }
        }

    }
}
