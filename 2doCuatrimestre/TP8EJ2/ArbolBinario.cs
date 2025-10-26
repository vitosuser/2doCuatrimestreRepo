using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8EJ2
{
    public class ArbolBinario
    {
        public Nodo? raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public bool AgregarRaiz(string nombre)
        {
            if(raiz != null)
            {
                return false;
            }
            else
            {
                raiz = new Nodo(nombre);
                return true;
            }
        }

        public bool AgregarIzquierda(string padre, string hijo)
        {
            return InsertarIzquierdaRecursivo(raiz, padre, hijo);
            
        }
        public bool InsertarIzquierdaRecursivo(Nodo? nodo, string padre, string hijo)
        {
            if(nodo != null)
            {
                if(nodo.Nombre == padre)
                {
                    if(nodo.Izquierdo == null)
                    {
                        nodo.Izquierdo = new Nodo(hijo);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            bool insertado = InsertarIzquierdaRecursivo(nodo.Izquierdo, padre, hijo);

            if (!insertado)
            {
                insertado = InsertarIzquierdaRecursivo(nodo.Derecho, padre, hijo);
            }

            return insertado;
        }

        public bool AgregarDerecha(string padre, string hijo)
        {
            return InsertarDerechaRecursivo(raiz, padre, hijo);

        }
        public bool InsertarDerechaRecursivo(Nodo? nodo, string padre, string hijo)
        {
            if (nodo != null)
            {
                if (nodo.Nombre == padre)
                {
                    if (nodo.Derecho == null)
                    {
                        nodo.Derecho = new Nodo(hijo);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            bool insertado = InsertarDerechaRecursivo(nodo.Derecho, padre, hijo);

            if (!insertado)
            {
                insertado = InsertarDerechaRecursivo(nodo.Izquierdo, padre, hijo);
            }

            return insertado;
        }

        public string RecorridoPreorden()
        {
            return RecorridoPreordenRecursivo(raiz).TrimEnd('-');
        }

        private string RecorridoPreordenRecursivo(Nodo? nodo)
        {
            if (nodo == null)
            {
                return "";
            }

            // Raíz - Izquierda - Derecha
            string resultado = nodo.Nombre + "-";
            resultado += RecorridoPreordenRecursivo(nodo.Izquierdo);
            resultado += RecorridoPreordenRecursivo(nodo.Derecho);
            return resultado;
        }


        public string RecorridoInorden()
        {
            return RecorridoInordenRecursivo(raiz).TrimEnd('-');
        }

        private string RecorridoInordenRecursivo(Nodo? nodo)
        {
            if (nodo == null)
            {
                return "";
            }

            // Izquierda - Raíz - Derecha
            string resultado = "";
            resultado += RecorridoInordenRecursivo(nodo.Izquierdo);
            resultado += nodo.Nombre + "-";
            resultado += RecorridoInordenRecursivo(nodo.Derecho);
            return resultado;
        }


        public string RecorridoPostorden()
        {
            return RecorridoPostordenRecursivo(raiz).TrimEnd('-');
        }

        private string RecorridoPostordenRecursivo(Nodo? nodo)
        {
            if (nodo == null)
            {
                return "";
            }

            // Izquierda - Derecha - Raíz
            string resultado = "";
            resultado += RecorridoPostordenRecursivo(nodo.Izquierdo);
            resultado += RecorridoPostordenRecursivo(nodo.Derecho);
            resultado += nodo.Nombre + "-";
            return resultado;
        }
        public void Limpiar() // metodo para limpiar la raiz del ctxmenu
        {
            raiz = null;
        }
    }
}
