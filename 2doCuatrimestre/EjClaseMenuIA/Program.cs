namespace Ejemplo02_EstructurasNativas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║        Menú de Estructuras Dinámicas           ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Manipular una Pila (Stack)                  ║");
                Console.WriteLine("║ 2. Manipular una Cola (Queue)                  ║");
                Console.WriteLine("║ 3. Manipular una Lista(List)                   ║");
                Console.WriteLine("║ 4. Manipular una Lista Enlazada(LinkedList)    ║");
                Console.WriteLine("║ 5. Manipular un Diccionario (Dictionary)       ║");
                Console.WriteLine("║ 6. Salir                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ManipularPila();
                        break;
                    case "2":
                        ManipularCola();
                        break;
                    case "3":
                        ManipularLista();
                        break;
                    case "4":
                        ManipularListaEnlazada();
                        break;
                    case "5":
                        ManipularDiccionario();
                        break;
                    case "6":
                        salir = true;
                        Console.WriteLine("\nSaliendo del programa. ¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Presione cualquier tecla para continuar...");
                        Pausa();
                        break;
                }
            }
        }

        // --- Opción 1: Manipulación de Pila (Stack) ---
        static void ManipularPila()
        {
            Console.Clear();
            Console.WriteLine("--- Manipulación de Pila (Stack) ---");

            Stack<int> pila = new Stack<int>();

            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Pila actual: " + (pila.Count > 0 ? string.Join(", ", pila) : "vacía"));
                Console.WriteLine("\nOperaciones:");
                Console.WriteLine("1. Apilar (Push)");
                Console.WriteLine("2. Desapilar (Pop)");
                Console.WriteLine("3. Ver Cima (Peek)");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese un número para apilar: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            pila.Push(valor);
                            Console.WriteLine($"Elemento {valor} apilado.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "2":
                        if (pila.Count > 0)
                        {
                            int elemento = pila.Pop();
                            Console.WriteLine($"Elemento desapilado: {elemento}.");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía. No se puede desapilar.");
                        }
                        Pausa();
                        break;
                    case "3":
                        if (pila.Count > 0)
                        {
                            Console.WriteLine($"Elemento en la cima: {pila.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía. No hay elementos para ver.");
                        }
                        Pausa();
                        break;
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }
            }
        }

        // --- Opción 2: Manipulación de Cola (Queue) ---
        static void ManipularCola()
        {
            Console.Clear();
            Console.WriteLine("--- Manipulación de Cola (Queue) ---");

            Queue<int> cola = new Queue<int>();

            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Cola actual: " + (cola.Count > 0 ? string.Join(", ", cola) : "vacía"));
                Console.WriteLine("\nOperaciones:");
                Console.WriteLine("1. Encolar (Enqueue)");
                Console.WriteLine("2. Desencolar (Dequeue)");
                Console.WriteLine("3. Ver Frente (Peek)");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese un número para encolar: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            cola.Enqueue(valor);
                            Console.WriteLine($"Elemento {valor} encolado.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "2":
                        if (cola.Count > 0)
                        {
                            int elemento = cola.Dequeue();
                            Console.WriteLine($"Elemento desencolado: {elemento}.");
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía. No se puede desencolar.");
                        }
                        Pausa();
                        break;
                    case "3":
                        if (cola.Count > 0)
                        {
                            Console.WriteLine($"Elemento en el frente: {cola.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía. No hay elementos para ver.");
                        }
                        Pausa();
                        break;
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }
            }
        }

        // --- Opción 3: Manipulación de Lista(List) ---
        static void ManipularLista()
        {
            Console.Clear();
            Console.WriteLine("--- Manipulación de Lista(List) ---");

            // LinkedList<int> lista = new LinkedList<int>(); // En C# la estructura nativa se llama LinkedList

            List<int> lista = new List<int>(); // Usaremos List<T> ya que es la más común y funcionalmente similar para este ejemplo.

            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Lista actual: " + (lista.Count > 0 ? string.Join(" <-> ", lista) : "vacía"));
                Console.WriteLine("\nOperaciones:");
                Console.WriteLine("1. Agregar al final");
                Console.WriteLine("2. Agregar al principio");
                Console.WriteLine("3. Eliminar por valor");
                Console.WriteLine("4. Buscar elemento");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese un número para agregar al final: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            lista.Add(valor);
                            Console.WriteLine($"Elemento {valor} agregado al final.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "2":
                        Console.Write("Ingrese un número para agregar al principio: ");
                        if (int.TryParse(Console.ReadLine(), out int valorPrincipio))
                        {
                            lista.Insert(0, valorPrincipio);
                            Console.WriteLine($"Elemento {valorPrincipio} agregado al principio.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "3":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorEliminar))
                        {
                            if (lista.Remove(valorEliminar))
                            {
                                Console.WriteLine($"Elemento {valorEliminar} eliminado.");
                            }
                            else
                            {
                                Console.WriteLine("El elemento no se encontró en la lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                        {
                            if (lista.Contains(valorBuscar))
                            {
                                Console.WriteLine($"El valor {valorBuscar} se encontró en la lista.");
                            }
                            else
                            {
                                Console.WriteLine($"El valor {valorBuscar} no se encontró.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        Pausa();
                        break;
                    case "5":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }
            }
        }

        // --- Opción 4: Manipulación de Lista Enlazada (LinkedList<T>) ---
        static void ManipularListaEnlazada()
        {
            Console.Clear();
            Console.WriteLine("--- Manipulación de Lista Enlazada (LinkedList<T>) ---");

            LinkedList<int> listaEnlazada = new LinkedList<int>();
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Lista Enlazada actual:");
                if (listaEnlazada.Count > 0)
                {
                    Console.WriteLine(string.Join(" <-> ", listaEnlazada));
                }
                else
                {
                    Console.WriteLine("La lista está vacía.");
                }

                Console.WriteLine("\nOperaciones:");
                Console.WriteLine("1. Agregar al inicio");
                Console.WriteLine("2. Agregar al final");
                Console.WriteLine("3. Insertar después de un valor");
                Console.WriteLine("4. Insertar antes de un valor");
                Console.WriteLine("5. Eliminar por valor");
                Console.WriteLine("6. Eliminar primer nodo");
                Console.WriteLine("7. Eliminar último nodo");
                Console.WriteLine("8. Buscar nodo");
                Console.WriteLine("9. Contar nodos");
                Console.WriteLine("10. Vaciar lista");
                Console.WriteLine("11. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1": // Agregar al inicio
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out int valInicio))
                        {
                            listaEnlazada.AddFirst(valInicio);
                            Console.WriteLine($"Elemento {valInicio} agregado al inicio.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "2": // Agregar al final
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out int valFinal))
                        {
                            listaEnlazada.AddLast(valFinal);
                            Console.WriteLine($"Elemento {valFinal} agregado al final.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "3": // Insertar después de un valor
                        Console.Write("Ingrese el valor existente: ");
                        if (int.TryParse(Console.ReadLine(), out int valExistente1))
                        {
                            var nodo = listaEnlazada.Find(valExistente1);
                            if (nodo != null)
                            {
                                Console.Write("Ingrese el valor a insertar: ");
                                if (int.TryParse(Console.ReadLine(), out int nuevoVal1))
                                {
                                    listaEnlazada.AddAfter(nodo, nuevoVal1);
                                    Console.WriteLine($"Elemento {nuevoVal1} insertado después de {valExistente1}.");
                                }
                                else Console.WriteLine("Entrada no válida.");
                            }
                            else Console.WriteLine("El valor no se encontró en la lista.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "4": // Insertar antes de un valor
                        Console.Write("Ingrese el valor existente: ");
                        if (int.TryParse(Console.ReadLine(), out int valExistente2))
                        {
                            var nodo = listaEnlazada.Find(valExistente2);
                            if (nodo != null)
                            {
                                Console.Write("Ingrese el valor a insertar: ");
                                if (int.TryParse(Console.ReadLine(), out int nuevoVal2))
                                {
                                    listaEnlazada.AddBefore(nodo, nuevoVal2);
                                    Console.WriteLine($"Elemento {nuevoVal2} insertado antes de {valExistente2}.");
                                }
                                else Console.WriteLine("Entrada no válida.");
                            }
                            else Console.WriteLine("El valor no se encontró en la lista.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "5": // Eliminar por valor
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int valEliminar))
                        {
                            if (listaEnlazada.Remove(valEliminar))
                                Console.WriteLine($"Elemento {valEliminar} eliminado.");
                            else
                                Console.WriteLine("El valor no se encontró en la lista.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "6": // Eliminar primer nodo
                        if (listaEnlazada.Count > 0)
                        {
                            listaEnlazada.RemoveFirst();
                            Console.WriteLine("Primer nodo eliminado.");
                        }
                        else Console.WriteLine("La lista está vacía.");
                        Pausa();
                        break;

                    case "7": // Eliminar último nodo
                        if (listaEnlazada.Count > 0)
                        {
                            listaEnlazada.RemoveLast();
                            Console.WriteLine("Último nodo eliminado.");
                        }
                        else Console.WriteLine("La lista está vacía.");
                        Pausa();
                        break;

                    case "8": // Buscar nodo
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valBuscar))
                        {
                            var nodo = listaEnlazada.Find(valBuscar);
                            if (nodo != null)
                                Console.WriteLine($"Nodo encontrado con valor: {nodo.Value}");
                            else
                                Console.WriteLine("El valor no está en la lista.");
                        }
                        else Console.WriteLine("Entrada no válida.");
                        Pausa();
                        break;

                    case "9": // Contar nodos
                        Console.WriteLine($"La lista contiene {listaEnlazada.Count} nodos.");
                        Pausa();
                        break;

                    case "10": // Vaciar lista
                        listaEnlazada.Clear();
                        Console.WriteLine("La lista fue vaciada.");
                        Pausa();
                        break;

                    case "11": // Volver
                        volver = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }
            }
        }

        // --- Opción 5: Manipulación de Diccionario (Dictionary) ---
        static void ManipularDiccionario()
        {
            Console.Clear();
            Console.WriteLine("--- Manipulación de Diccionario (Dictionary) ---");
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            bool volver = false;

            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Diccionario actual:");
                if (diccionario.Count > 0)
                {
                    foreach (var kvp in diccionario)
                    {
                        Console.WriteLine($"[{kvp.Key}] = {kvp.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("El diccionario está vacío.");
                }

                Console.WriteLine("\nOperaciones:");
                Console.WriteLine("1. Agregar par clave-valor");
                Console.WriteLine("2. Eliminar por clave");
                Console.WriteLine("3. Buscar por clave");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese la clave: ");
                        string clave = Console.ReadLine();
                        Console.Write("Ingrese el valor: ");
                        string valor = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(clave) && !diccionario.ContainsKey(clave))
                        {
                            diccionario.Add(clave, valor);
                            Console.WriteLine("Par agregado.");
                        }
                        else
                        {
                            Console.WriteLine("Clave no válida o ya existe.");
                        }
                        Pausa();
                        break;
                    case "2":
                        Console.Write("Ingrese la clave a eliminar: ");
                        string claveEliminar = Console.ReadLine();
                        if (diccionario.Remove(claveEliminar))
                        {
                            Console.WriteLine("Elemento eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("La clave no se encontró.");
                        }
                        Pausa();
                        break;
                    case "3":
                        Console.Write("Ingrese la clave a buscar: ");
                        string claveBuscar = Console.ReadLine();
                        if (diccionario.ContainsKey(claveBuscar))
                        {
                            Console.WriteLine($"El valor para la clave '{claveBuscar}' es: {diccionario[claveBuscar]}");
                        }
                        else
                        {
                            Console.WriteLine("La clave no se encontró.");
                        }
                        Pausa();
                        break;
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Pausa();
                        break;
                }
            }
        }


        // --- Función auxiliar para pausar la ejecución ---
        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
