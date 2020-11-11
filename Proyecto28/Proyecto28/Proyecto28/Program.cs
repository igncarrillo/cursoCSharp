using System;
using System.Collections.Generic;

namespace Proyecto28
{
    class Cola
    {
        private Queue<char> cola;
        
        public Cola()
        {
            cola=new Queue<char>();
        }

        public void Insertar(char elemento)
        {
            cola.Enqueue(elemento);
        }

        public char Eliminar()
        {
            if (cola.Count > 0)
            {
                return cola.Dequeue();
            }
            else
            {
                return Char.MaxValue;
            }
        }

        public bool EstaVacia()
        {
            if (cola.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Imprimir()
        {
            foreach (var elemento in cola)
            {
                Console.Write(elemento+", ");
            }
            Console.WriteLine();
        }

        public char ObtenerCima()
        {
            return cola.Peek();
        }
        
    }

    class Prueba
    {
        public static void Main()
        {
            
        }
    }
}