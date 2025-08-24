using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    /*Ejercicio nro 10: Una pizzería cocina 6 tipos de pizza que son repartidas 
     por medio de sus 4 motos su numerosa clientela en un radio de 20 cuadras a la redonda de su local.

Cuando el pedido es enviado se controla 
Nro de ticket
Código de pizza
Cantidad
Nro de moto
Monto de la venta
Los datos finalizan con el nro de ticket igual a 0.

Se desea saber
•	Ticket de mayor valor y que moto llevo ese pedido
•	Moto que hizo menos viajes
•	Valor promedio de los tickets
•	Que porcentaje representa la cantidad de pizzas “A” sobre el total de envíos realizados
•	Facturación total del negocio
*/
    internal class Program
    {
        const int FI = 200;
        const int CO = 5;
        const int PIZZAS = 6; //tipos de pizzas
        const int MOT = 4; //cantidad de motos

        static void Main(string[] args)
        {
            int[,] ventas = new int[FI, CO];

            ingresoDeDatos(ventas);
            ticketMayorValor(ventas);
            motoMenosViajes(ventas);
            promedioTickets(ventas);
            porcentajePizzaEnvios(ventas);
            facturacionTotal(ventas);

            Console.ReadKey();
        }

        public static void ingresoDeDatos(int[,] ventas)
        {
            int i = 0;

            Console.WriteLine("---------------INGRESO DE DATOS----------------");

            do
            {
                Console.WriteLine("Ingrese el nro de ticket (0 para finalizar)");
                ventas[i, 0] = int.Parse(Console.ReadLine());

            } while (ventas[i, 0] < 0);

            while (ventas[i, 0] != 0 && i < FI)
            {
                do
                {
                    Console.WriteLine("Ingrese el codigo de pizza: ");
                    ventas[i, 1] = int.Parse(Console.ReadLine());

                } while (ventas[i, 1] < 1 || ventas[i, 1] > PIZZAS);

                do
                {
                    Console.WriteLine("Ingrese la cantidad de pizzas ordenadas: ");
                    ventas[i, 2] = int.Parse(Console.ReadLine());

                } while (ventas[i, 2] < 1);

                do
                {
                    Console.WriteLine("Ingrese el nro de moto que llevara el pedido: ");
                    ventas[i, 3] = int.Parse(Console.ReadLine());

                } while (ventas[i, 3] < 1 || ventas[i, 3] > MOT);

                do
                {
                    Console.WriteLine("Ingrese el monto de la venta: ");
                    ventas[i, 4] = int.Parse(Console.ReadLine());

                } while (ventas[i, 4] < 0);

                i = i + 1;

                do
                {
                    Console.WriteLine("Ingrese el nro de ticket (0 para finalizar)");
                    ventas[i, 0] = int.Parse(Console.ReadLine());

                } while (ventas[i, 0] < 0);
            }

        }

        public static void ticketMayorValor(int[,] ventas)
        {
            int i;
            int maximo = 0, identifMoto = 0, nroTicket = 0;

            Console.WriteLine("---------------TICKET MAYOR MONTO----------------");

            for (i = 0; i < FI; i++)
            {
                if (ventas[i, 4] > maximo)
                {

                    maximo = ventas[i, 4];
                    nroTicket = ventas[i, 0];
                    identifMoto = ventas[i, 3];
                }
            }

            if (maximo != 0)
            {
                Console.WriteLine($"El ticket de mayor monto ({maximo}) fue el nro: {nroTicket} -- Moto: {identifMoto}");
            }
            else
            {
                Console.WriteLine("No se ingresaron datos");
            }


        }

        public static void motoMenosViajes(int[,] ventas)
        {

            int i;
            int[] viajesPorMoto = new int[MOT];

            int minimo = 999, identificador = 0;

            Console.WriteLine("---------------MOTO MENOS VIAJES----------------");


            for (i = 0; i < FI; i++)
            {
                if (ventas[i, 3] != 0)
                {
                    switch (ventas[i, 3])
                    {
                        case 1:
                            viajesPorMoto[0] = viajesPorMoto[0] + 1;
                            break;
                        case 2:
                            viajesPorMoto[1] = viajesPorMoto[1] + 1;
                            break;
                        case 3:
                            viajesPorMoto[2] = viajesPorMoto[2] + 1;
                            break;
                        case 4:
                            viajesPorMoto[3] = viajesPorMoto[3] + 1;
                            break;

                    }
                }

            }

            for (i = 0; i < MOT; i++)
            {
                if (viajesPorMoto[i] < minimo)
                {
                    minimo = viajesPorMoto[i];
                    identificador = i + 1;
                }
            }

            if (minimo != 999)
            {
                Console.WriteLine($"La moto que hizo menos viajes({minimo} viajes) fue la nro {identificador}");
            }
            else
            {
                Console.WriteLine("No se ingresaron datos");
            }

        }

        public static void promedioTickets(int[,] ventas)
        {
            int i;
            int sumador = 0, contador = 0;
            float promedio;

            Console.WriteLine("---------------PROMEDIO TICKETS----------------");


            for (i = 0; i < FI; i++)
            {
                if (ventas[i, 0] != 0)
                {
                    sumador = sumador + ventas[i, 4];
                    contador = contador + 1;
                }
            }

            if (contador != 0)
            {

                promedio = (float)sumador / contador;

                Console.WriteLine($"El valor promedio de los {contador} tickets es: {promedio}");

            }
            else
            {
                Console.WriteLine("No se ingresaron datos");
            }


        }

        public static void porcentajePizzaEnvios(int[,] ventas)
        {
            int i;
            int contador = 0, contPizza = 0;
            float porcentaje;

            Console.WriteLine("---------------PROMEDIO PIZZAS 'A'----------------");

            for (i = 0; i < FI; i++)
            {
                if (ventas[i, 1] != 0)
                {
                    if (ventas[i, 1] == 1)
                    {
                        contPizza = contPizza + 1;
                    }

                    contador = contador + 1;
                }
            }

            if (contador != 0)
            {
                porcentaje = (contPizza * 100) / contador;

                Console.WriteLine("Porcentaje de pizzas 1 sobre el total de pizzas: {0}", porcentaje);

            }
            else
            {
                Console.WriteLine("No se ingresaron datos");
            }

        }

        public static void facturacionTotal(int[,] ventas)
        {
            int i;
            int sumador = 0;

            Console.WriteLine("---------------FACTURACION TOTAL----------------");

            for (i = 0; i < FI; i++)
            {

                if (ventas[i, 0] != 0)
                {

                    sumador = sumador + ventas[i, 4];

                }

            }

            if (sumador != 0)
            {
                Console.WriteLine("Total facturado: {0}", sumador);
            }
            else
            {
                Console.WriteLine("No se ingresaron datos");
            }

        }
    }
}
