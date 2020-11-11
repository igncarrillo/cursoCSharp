using System;

namespace Proyecto13
{
    class AnalizadorDeValores
    {
        public void Inicializar()
        {
            int valor1, valor2, valor3;
            Console.Write("Ingrese el valor 1: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor 2: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor 3: ");
            valor3 = int.Parse(Console.ReadLine());
            Imprimir(CalcularMayor(valor1,valor2,valor3),CalcularMenor(valor1,valor2,valor3));
        }

        public void Imprimir(int mayor, int menor)
        {
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
        }
        public int CalcularMayor(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 > v3)
            {
                return v1;
            }
            else
            {
                if (v2 > v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }
        
        public int CalcularMenor(int v1, int v2, int v3)
        {
            if (v1 < v2 && v1 < v3)
            {
                return v1;
            }
            else
            {
                if (v2 < v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            AnalizadorDeValores analizador1 = new AnalizadorDeValores();
            analizador1.Inicializar();
        }
    }
}