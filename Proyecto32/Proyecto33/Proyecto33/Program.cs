using System;
using System.Collections.Generic;

namespace Proyecto33
{
    static class Extension
    {
        public static void  Imprimir<T>(this List<T> lista)
        {
            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }

        public static void Imprimir(this int entero, int x2)
        {
            while (entero <= x2)
            {
                Console.WriteLine(entero);
                entero++;
            }
        }
        public static void Main(string[] args)
        {
            List<int> entero = new List<int>(){3,4,5,6,7};
            entero.Imprimir();
            List<string> cadenas = new List<string>{"hola","como","te","va?"};
            cadenas.Imprimir();
            3.Imprimir(10);

        }
    }
}