using System;

namespace Proyecto14
{
    class CalculadoraAltura
    {
        private float[] altura;

        public void IntroducirAltura()
        {
            altura = new float[5];
            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Introduzca la altura de la persona "+(i+1)+": ");
                altura[i] = float.Parse(Console.ReadLine());
            }
        }

        public float CalcularPromedio()
        {
            float promedio = 0;
            for (int i = 0; i < 5; i++)
            {
                promedio += altura[i];
            }

            promedio = promedio / 5;
            Console.WriteLine("La altura promedio es: "+promedio);

            return promedio;
        }

        public void CalcularDesviacion(float promedio)
        {
            int masAltaQuePromedio=0, masBajaQuePromedio=0;
            for (int i = 0; i < altura.Length; i++)
            {
                if (altura[i] > promedio)
                {
                    masAltaQuePromedio++;
                }
                else
                {
                    if (altura[i] < promedio)
                    {
                        masBajaQuePromedio++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mas altas que el promedio: "+masAltaQuePromedio);
            Console.WriteLine("Cantidad de personas mas bajas que el promedio: " + masBajaQuePromedio);
        }
        
        public static void Main(string[] args)
        {
            CalculadoraAltura altura= new CalculadoraAltura();
            altura.IntroducirAltura();
            altura.CalcularDesviacion(altura.CalcularPromedio());
        }
    }
}