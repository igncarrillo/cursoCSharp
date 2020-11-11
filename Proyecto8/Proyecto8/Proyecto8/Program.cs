using System;

namespace Proyecto8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int piezasParaProcesar, piezasAptas=0, contador=1;
            float longitudPieza;
            
            Console.Write("Ingrese el numero de piezas a analizar: ");
            piezasParaProcesar = int.Parse(Console.ReadLine());
            while (contador<=piezasParaProcesar)
            {
                Console.Write("Ingrese la longitud de la pieza: ");
                longitudPieza = float.Parse(Console.ReadLine());
                if (longitudPieza>=1.2f && longitudPieza <=1.3f)
                {
                    piezasAptas++;
                }
                contador++;
            }
            
            Console.Write("Cantidad de piezas aptas: ");
            Console.WriteLine(piezasAptas);
        }
    }
}