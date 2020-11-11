using System;

namespace Proyecto18
{
    class OrdenarStrings
    {
        private string[] paises;

        public void CargarDatos()
        {
            int n;
            Console.Write("Ingrese la cantidad de paises a cargar: ");
            n = int.Parse(Console.ReadLine());
            
            paises=new string[n];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del pais " + (i + 1) + ": ");
                paises[i]= Console.ReadLine();
            }
        }

        public void OrdenarDatos()
        {
            string aux;
            for (int i = 0; i < paises.Length-1; i++)
            {
                for (int j = 0; j < paises.Length-1-i; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) < 0)
                    {
                        aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Paises ordenados alfabeticamente inversos: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }
        
        public static void Main(string[] args)
        {
            OrdenarStrings ordenador = new OrdenarStrings();
            ordenador.CargarDatos();
            ordenador.OrdenarDatos();
            ordenador.ImprimirDatos();
        }
    }
}