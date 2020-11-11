using System;
using System.Collections.Generic;

namespace Proyecto29
{
    class Programa
    {
        public void Ordenar(ref int v1, ref int v2, ref int v3)
        {           
            int menor;
            int intermedio;
            int mayor;
            if (v1 <= v2 & v1 <= v3)
            {
                menor = v1;
                if (v2 < v3)
                {
                    intermedio = v2;
                    mayor = v3;
                }
                else
                {
                    intermedio = v3;
                    mayor = v2;
                }
            }
            else
            {
                if (v2 <= v3)
                {
                    menor = v2;
                    if (v1 < v3)
                    {
                        intermedio = v1;
                        mayor = v3;
                    }
                    else
                    {
                        intermedio = v3;
                        mayor = v1;
                    }
                }
                else
                {
                    menor = v3;
                    if (v1 < v2)
                    {
                        intermedio = v1;
                        mayor = v2;
                    }
                    else
                    {
                        intermedio = v2;
                        mayor = v1;
                    }
                }
            }
            v1 = menor;
            v2 = intermedio;
            v3 = mayor;
        }

        public static void Main(string[] args)
        {
            Programa programa = new Programa();
            int x1 = 15;
            int x2 = 20;
            int x3 = 17;
            programa.Ordenar(ref x1, ref x2, ref x3);
            Console.WriteLine("x1: {0}, x2: {1}, x3: {2}",x1,x2,x3);
        }
    }
}