using System;

namespace Proyecto4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sueldo;
            
            Console.Write("Ingrese el sueldo del empleado: ");
            sueldo = int.Parse(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }

            Console.ReadKey();
        }
    }
}