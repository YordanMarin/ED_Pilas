using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    internal class Pila
    {
        private Nodo cima = null;
        private int contador = 0;

        public void push(string nom) //apilar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Siguiente = cima;
            cima = nuevo;
            contador++;
        }
        public void mostrar(ListBox list)
        {
            Nodo actual = cima;
            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }
    }
}
