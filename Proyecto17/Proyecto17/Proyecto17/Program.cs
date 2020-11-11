using System;

namespace Proyecto17
{
    class Empleados
    {
        private int[] sueldos;
        private string[] nombres;
        
        public void CargarDatos()
        {
            int n;
            Console.Write("Indique la cantidad de empleados a cargar: ");
            n = int.Parse(Console.ReadLine());
            
            sueldos=new int[n];
            nombres=new string[n];
            
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese el nombre del empleado "+(i+1)+": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese el sueldo del empleado "+(nombres[i])+": $");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarSueldos()
        {
            int aux;
            string aux2;
            
            for (int i = 0; i < sueldos.Length-1; i++)
            {
                for (int j = 0; j < sueldos.Length-1-i; j++)
                {
                    if (sueldos[j] < sueldos[j + 1])
                    {
                        aux = sueldos[j];
                        aux2 = nombres[j];
                        sueldos[j] = sueldos[j + 1];
                        nombres[j] = nombres[j + 1];
                        sueldos[j + 1] = aux;
                        nombres[j + 1] = aux2;
                    }
                }
            }
            this.ImprimirSueldos();
        }

        public void OrdenarNombres()
        {
            int aux;
            string aux2;
            
            for (int i = 0; i < sueldos.Length-1; i++)
            {
                for (int j = 0; j < sueldos.Length-1-i; j++)
                {
                    if (nombres[j].CompareTo(nombres[j+1])>0)
                    {
                        aux = sueldos[j];
                        aux2 = nombres[j];
                        sueldos[j] = sueldos[j + 1];
                        nombres[j] = nombres[j + 1];
                        sueldos[j + 1] = aux;
                        nombres[j + 1] = aux2;
                    }
                }
            }
            
            this.ImprimirNombres();
        }

        public void ImprimirSueldos()
        {
            Console.WriteLine();
            Console.WriteLine("Los sueldos ordenados de mayor a menor son: ");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(nombres[i]+" -- ");
                Console.WriteLine("$"+sueldos[i]);
            }
        }
        
        public void ImprimirNombres()
        {
            Console.WriteLine();
            Console.WriteLine("Los nombres ordenados de menor a mayor son: ");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(nombres[i]+" -- ");
                Console.WriteLine("$"+sueldos[i]);
            }
        }
        
        public static void Main(string[] args)
        {
            Empleados empleados = new Empleados();
            empleados.CargarDatos();
            empleados.OrdenarSueldos();
            empleados.OrdenarNombres();
        }
    }
}