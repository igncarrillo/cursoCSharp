using System;

namespace Proyecto16
{
    class Empleados
    {
        private int[] sueldos;
        private string[] nombres;

        public void CargarDatos()
        {
            int cantidadEmpleados;
            
            Console.Write("Indique la cantidad de empleados a cargar: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());
            
            sueldos=new int[cantidadEmpleados];
            nombres=new string[cantidadEmpleados];
            
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Introduzca el nombre del empleado "+(i+1)+": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Introduzca el sueldo del empleado "+(nombres[i])+": ");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
        }

        public int CalcularMayor()
        {
            int indice=0;
            
            for (int i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[indice] < sueldos[i])
                {
                    indice = i;
                }    
            }

            return indice;
        }

        public void ImprimirDatos(int i)
        {
            Console.Write("El empleado con el mayor sueldo es: " + nombres[i] + " -- Con un sueldo de $" + sueldos[i]);
        }
        
        public static void Main(string[] args)
        {
            Empleados empleados = new Empleados();
            empleados.CargarDatos();
            empleados.ImprimirDatos(empleados.CalcularMayor());
        }
    }
}