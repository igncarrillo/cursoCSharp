using System;

namespace Proyecto6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            
            Console.Write("Ingrese la primer nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercer nota: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.Write("Promedio: ");
            Console.WriteLine(promedio);
            
            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (promedio >= 4)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }

            Console.ReadKey();
        }
    }
}