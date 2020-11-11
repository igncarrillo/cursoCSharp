using System;
using System.Security.AccessControl;

namespace Proyecto22
{
    class Operarios
    {
        private string[] nombres;
        private int[] sueldos;

        public Operarios()
        {
            int n;
            Console.Write("Ingrese la cantidad de operarios a cargar: ");
            n = int.Parse(Console.ReadLine());
            
            nombres = new string[n];
            sueldos = new int[n];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese el nombre del operario "+(i+1)+": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese el sueldo del operario "+nombres[i]+": ");
                sueldos[i] =int.Parse(Console.ReadLine());
            }
        }

        public void ImprimirDatos()
        {
            Console.WriteLine();
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Nombre: "+(nombres[i]+"--Sueldo:"+sueldos[i]));
            }
        }
        public static void Main(string[] args)
        {
            Operarios operarios1= new Operarios();
            operarios1.ImprimirDatos();
        }
    }
}