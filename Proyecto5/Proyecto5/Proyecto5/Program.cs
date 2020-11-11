using System;

namespace Proyecto5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numero1, numero2;
            
            Console.Write("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("El numero mayor es: ");
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1);
            }
            else
            {
                Console.WriteLine(numero2);
            }

            Console.ReadKey();
        }
    }
}