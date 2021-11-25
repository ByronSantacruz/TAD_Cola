using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_TADCola
{
    class Cola
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Cola()
        {
            primero = null;
            ultimo = null;
        }
        //Aqui ingresamos los datos
        public void ingresar()
        {
            Console.Clear();
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese un nuevo dato a la cola: ");
            nuevo.dato = Console.ReadLine();
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }
        //Aqui mostramos los datos guardados
        public void Mostrar()
        {
            Console.Clear();
            Nodo Actual = new Nodo();
            Console.Write("Los datos ingresado en la cola son:\n");
            Actual = primero;
            if (primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("" + Actual.dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La cola esta vacia");
            }
        }
    }
}
