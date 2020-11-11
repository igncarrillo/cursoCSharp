using System;
using System.Security.Cryptography.X509Certificates;

namespace Proyecto20
{
    internal class Plantilla
    {
        private string[] nombresEmpleados;
        private int[,] sueldos;
        private int[] sueldosAcumulados;

        public void CargarDatos()
        {
            int n;
            Console.Write("Ingrese la cantidad de empleados a cargar: ");
            n = int.Parse(Console.ReadLine());
            
            nombresEmpleados=new string[n];
            sueldos=new int[n,3];
            sueldosAcumulados=new int[n];

            for (int i = 0; i < nombresEmpleados.Length; i++)
            {
                Console.Write("Ingrese el nombre del empleado "+(i+1)+": ");
                nombresEmpleados[i] = Console.ReadLine();
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    Console.Write("Ingrese el sueldo "+(j+1)+" del empleado "+nombresEmpleados[i]+": ");
                    sueldos[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void calcularAcumulado()
        {
            for (int i = 0; i < nombresEmpleados.Length; i++)
            {
                int acumulado = 0;
                for (int j = 0; j <sueldos.GetLength(1); j++)
                {
                    acumulado += sueldos[i,j];
                }

                sueldosAcumulados[i] = acumulado;
            }
        }

        public void CalcularTotalAbonado()
        {
            int acumulado = 0;
            for (int i = 0; i < nombresEmpleados.Length; i++)
            {
                acumulado += sueldosAcumulados[i];
            }
            Console.WriteLine("El valor abonado por la empresa fue: "+acumulado);
        }

        public void ObtenerMayorAcumulado()
        {
            int mayor = 0;
            int indice = 0;
            for (int i = 0; i < nombresEmpleados.Length; i++)
            {
                if (sueldosAcumulados[i] > mayor)
                {
                    mayor = sueldosAcumulados[i];
                    indice = i;
                }
            }
            
            Console.WriteLine("El empleado con el mayor sueldo es: "+nombresEmpleados[indice]+", con un sueldo acumulado de: "+sueldosAcumulados[indice]);
        }
        
        public static void Main(string[] args)
        {
            Plantilla plantilla1 = new Plantilla();
            plantilla1.CargarDatos();
            plantilla1.calcularAcumulado();
            plantilla1.CalcularTotalAbonado();
            plantilla1.ObtenerMayorAcumulado();
        }
    }
}