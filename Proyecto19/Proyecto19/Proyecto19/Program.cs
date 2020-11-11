/*Crear y cargar una matriz de 3 filas por 4 columnas. 
Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna.*/

using System;

namespace Proyecto19
{
    class Matriz
    {
        private int[,] matriz;

        public void CargarMatriz()
        {
            int f, c;
            Console.Write("Ingrese el numero de filas de la matriz: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas de la matriz: ");
            c = int.Parse(Console.ReadLine());
            
            matriz=new int[f,c];
            
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Ingrese la componente "+i+","+j+" de la matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("\nImpresion de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void ImprimirFila(int fila)
        {
            Console.WriteLine("\nImpresion de la fila "+fila);
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
               Console.Write(matriz[fila,j]+" "); 
            }
            Console.WriteLine();
        }
        
        public void ImprimirColumna(int columna)
        {
            Console.WriteLine("\nImpresion de la columna "+columna);
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i,columna]+" "); 
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz();
            matriz1.CargarMatriz();
            matriz1.ImprimirMatriz();
            matriz1.ImprimirFila(2);
            matriz1.ImprimirFila(0);
            matriz1.ImprimirColumna(2);
        }
    }
}