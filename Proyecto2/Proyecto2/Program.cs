using System;

namespace Proyecto2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float lado;
            float superficie;
            
            Console.Write("Ingrese la longitud del lado del cuadrado: ");
            lado = float.Parse(Console.ReadLine());

            superficie = lado*lado;
            
            Console.Write("La superficie del cuadrado es: ");
            Console.WriteLine(superficie);
            Console.ReadKey();
            
        }
    }
}