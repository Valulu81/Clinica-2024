using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Clases
{
    public class ABB
    {
        private NodoABB raiz;

        // Método para insertar un nodo en el ABB
        public void Insertar(int valor, string nombre)
        {
            NodoABB nuevoNodo = new NodoABB() { Valor = valor, Nombre = nombre };

            if (raiz == null)
            {
                raiz = nuevoNodo;
            }
            else
            {
                InsertarRecursivo(raiz, nuevoNodo);
            }
        }

        private void InsertarRecursivo(NodoABB raizActual, NodoABB nuevoNodo)
        {
            if (nuevoNodo.Valor < raizActual.Valor)
            {
                if (raizActual.Izquierdo == null)
                {
                    raizActual.Izquierdo = nuevoNodo;
                }
                else
                {
                    InsertarRecursivo(raizActual.Izquierdo, nuevoNodo);
                }
            }
            else
            {
                if (raizActual.Derecho == null)
                {
                    raizActual.Derecho = nuevoNodo;
                }
                else
                {
                    InsertarRecursivo(raizActual.Derecho, nuevoNodo);
                }
            }
        }

        public void Limpiar()
        {
            raiz = null;
        }

        public bool EstaVacio()
        {
            return raiz == null;
        }

        // Método para recorrer el árbol en orden (inorden)
        public string RecorridoInorden()
        {
            return RecorridoInorden(raiz);
        }

        private string RecorridoInorden(NodoABB nodo)
        {
            if (nodo == null)
                return "";

            string izquierdo = RecorridoInorden(nodo.Izquierdo);
            string actual = $"{nodo.Nombre}: {nodo.Valor}\n";
            string derecho = RecorridoInorden(nodo.Derecho);

            return izquierdo + actual + derecho;
        }

        public string RecorridoInordenFiltro()
        {
            return RecorridoInordenFiltro(raiz);
        }

        private string RecorridoInordenFiltro(NodoABB nodo)
        {
            if (nodo == null)
                return "";

            string izquierdo = RecorridoInordenFiltro(nodo.Izquierdo);
            string actual = $"{nodo.Nombre} ";
            string derecho = RecorridoInordenFiltro(nodo.Derecho);

            return izquierdo + actual + derecho;
        }


        public string RecorridoInordenValor()
        {
            return RecorridoInordenValor(raiz);
        }

        private string RecorridoInordenValor(NodoABB nodo)
        {
            if (nodo == null)
                return "";

            string izquierdo = RecorridoInordenValor(nodo.Izquierdo);
            string actual = $"{nodo.Valor} ";
            string derecho = RecorridoInordenValor(nodo.Derecho);

            return izquierdo + actual + derecho;
        }

    }
}
