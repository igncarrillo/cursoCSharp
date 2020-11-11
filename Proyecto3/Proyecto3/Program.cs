using System;

namespace Proyecto3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float numero1, numero2;
            float suma;
            float producto;
            
            Console.Write("Ingrese el primer numero: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            producto = numero1 * numero2;
            
            Console.Write("El valor de la suma es: ");
            Console.WriteLine(suma);
            Console.Write("El valor del producto es: ");
            Console.WriteLine(producto);

            Console.ReadKey();
        }
    }
}