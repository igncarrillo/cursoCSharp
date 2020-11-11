using System;

namespace Proyecto1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            
            Console.Write("Ingrese las horas trabajadas este mes: ");
            horasTrabajadas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el costo de la hora: ");
            costoHora = float.Parse(Console.ReadLine());

            sueldo = horasTrabajadas * costoHora;
            
            Console.Write("El sueldo correspondiente del operario es: "); 
            Console.WriteLine(sueldo);

            Console.ReadKey();
        }
    }
}