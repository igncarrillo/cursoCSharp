using System;

namespace Proyecto31
{

        delegate int Operar(int x, int y);
        
        class Operacion
        {
            public int Sumar(int x, int y)
            {
                return x + y;
            }
            
            public int Restar(int x, int y)
            {
                return x - y;
            }

            public int Operar(Operar delegado, int x, int y)
            {
                return delegado(x, y);
            }
        }

        class Programa
        {
            public static void Main(string[] args)
            {
                Operacion operacion = new Operacion();
                Console.WriteLine(operacion.Restar(3, 4));
                Console.WriteLine(operacion.Sumar(3, 4));
                Operar delegado = operacion.Sumar;
                Console.WriteLine(delegado(3, 4));
                delegado = operacion.Restar;
                Console.WriteLine(delegado(3, 4));
                Console.WriteLine(operacion.Operar(delegado,3, 4));
            }
        }
}