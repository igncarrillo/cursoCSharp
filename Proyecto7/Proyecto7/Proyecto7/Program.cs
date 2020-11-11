using System;

namespace Proyecto7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int contador = 1, valor;
            float suma = 0, promedio = 0;

            while (contador<=10)
            {
                Console.Write("Ingrese un valor: ");
                valor = int.Parse(Console.ReadLine());
                suma += valor;
                contador++;
            }
            promedio = suma / 4;
            Console.Write("El valor de la suma es: ");
            Console.WriteLine(suma);
            Console.Write("El valor del promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}