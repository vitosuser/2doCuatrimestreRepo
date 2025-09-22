using Nodo;

namespace Nodo //cambiar por tp lista enlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregar elementos
            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);

            Console.WriteLine("Lista actual:");
            lista.Mostrar(); // 10 -> 20 -> 30 -> null

            // Buscar un elemento
            Console.WriteLine("\n¿Existe 20?: " + lista.Buscar(20)); // true
            Console.WriteLine("¿Existe 50?: " + lista.Buscar(50)); // false

            // Insertar después de un valor
            lista.InsertarDespuesDe(20, 25);
            Console.WriteLine("\nDespués de insertar 25 después de 20:");
            lista.Mostrar(); // 10 -> 20 -> 25 -> 30 -> null

            // Eliminar un valor
            lista.Eliminar(25);
            Console.WriteLine("\nDespués de eliminar 25:");
            lista.Mostrar(); // 10 -> 20 -> 30 -> null

            // Eliminar cabeza
            lista.Eliminar(10);
            Console.WriteLine("\nDespués de eliminar 10 (inicio):");
            lista.Mostrar(); // 20 -> 30 -> null

            Console.ReadKey();
        }
    }
}