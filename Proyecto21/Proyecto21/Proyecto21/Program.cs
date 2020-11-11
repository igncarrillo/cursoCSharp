using System;

namespace Proyecto21
{
    internal class MatrizDentada
    {
        private int[][] matrizDentada;

        public void CargarDatos()
        {
            int f,c;
            Console.Write("Ingrese la cantidad de filas de la matriz: ");
            f = int.Parse(Console.ReadLine());
            
            matrizDentada = new int[f][];
            for (int i = 0; i < f; i++)
            {
                Console.Write("Ingrese la cantidad de columnas de la fila "+(i+1)+": ");
                c = int.Parse(Console.ReadLine());
                matrizDentada[i] = new int[c];
                for (int j = 0; j < matrizDentada[i].Length; j++)
                {
                    Console.Write("Ingrese el valor de la componente "+(i+1)+","+(j+1)+": ");
                    matrizDentada[i][j] = int.Parse(Console.ReadLine());
                }
            }
            
            
        }

        public void ImprimirDatos()
        {
            Console.WriteLine();
            for (int i = 0; i < matrizDentada.Length; i++)
            {
                for (int j = 0; j <matrizDentada[i].Length; j++)
                {
                    Console.Write(matrizDentada[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            MatrizDentada matriz1 = new MatrizDentada();
            matriz1.CargarDatos();
            matriz1.ImprimirDatos();
        }
    }
}