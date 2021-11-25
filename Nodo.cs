using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_TADCola
{
    class Nodo
    {
        private string Dato;
        private Nodo siguiente;

        public string dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
