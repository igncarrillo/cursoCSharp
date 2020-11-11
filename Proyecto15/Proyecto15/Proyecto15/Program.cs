using System;

namespace Proyecto15
{
    class TablaRelacional
    {
        private string[] nombres;
        private int[] edades;
        
        public void IngresarDatos()
        {
            int n;
            Console.Write("Ingrese la cantidad de personas a cargar: ");
            n = int.Parse(Console.ReadLine());
            
            nombres=new string[n];
            edades=new int[n];
            
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre de la persona "+(i+1)+": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese la edad de la persona "+(i+1)+": ");
                edades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            
        }

        public void ImprimirDatos()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    Console.WriteLine(nombres[i]+" es mayor de edad");
                }
            }
        }
        
        public static void Main(string[] args)
        {
            TablaRelacional tabla = new TablaRelacional();
            tabla.IngresarDatos();
            tabla.ImprimirDatos();
        }
    }
}