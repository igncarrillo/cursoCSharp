using System;
using System.Security;

namespace Proyecto9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int cantidadTriangulos, cantidadAreaSuperior=0;
            float medidaBase, medidaAltura, superficie;
            
            Console.Write("Ingrese la cantidad de triangulos a estudiar: ");
            cantidadTriangulos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cantidadTriangulos; i++)
            {
                Console.Write("Ingrese la altura: ");
                medidaAltura = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la base: ");
                medidaBase = float.Parse(Console.ReadLine());
                superficie = 0.5f * medidaBase * medidaAltura;
                Console.Write("Triangulo ");
                Console.WriteLine(i);
                Console.Write("Altura: ");
                Console.WriteLine(medidaAltura);
                Console.Write("Base: ");
                Console.WriteLine(medidaBase);
                Console.Write("Superficie: ");
                Console.WriteLine(superficie);
                if (superficie > 12)
                {
                    cantidadAreaSuperior++;
                }
            }
            Console.Write("Cantidad de triangulos con area superior a 12: ");
            Console.WriteLine(cantidadAreaSuperior);
            Console.ReadKey();
        }
        
    }
}