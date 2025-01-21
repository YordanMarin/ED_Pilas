using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Nodo
    {
        private string nombre;
        private Nodo siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
