using System;

namespace Proyecto12
{
    class Triangulo
    {
        private float lado1;
        private float lado2;
        private float lado3;
        private bool esEquilatero=false;
        
        public void Inicilizar()
        {
            Console.Write("Ingrese el valor del lado 1: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del lado 2: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del lado 3: ");
            lado3 = float.Parse(Console.ReadLine());
        }

        public void ImprimirLadoMayor()
        {
            if (lado1 == lado2 && lado1==lado3)
            {
                Console.WriteLine("Los lados son iguales");
                esEquilatero = true;
            }
            else
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    Console.WriteLine("El lado 1 es el mayor");
                    
                }
                else
                {
                    if (lado2 > lado3)
                    {
                        Console.WriteLine("El lado 2 es el mayor");
                    }
                    else
                    {
                        Console.WriteLine("El lado 3 es el mayor");
                    }
                }
            }
            
        }

        public void EsEquilatero()
        {
            if (esEquilatero)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else
            {
                Console.WriteLine("El triangulo NO es equilatero");
            }
        }
        
        public static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.Inicilizar();
            triangulo1.ImprimirLadoMayor();
            triangulo1.EsEquilatero();
        }
    }
}