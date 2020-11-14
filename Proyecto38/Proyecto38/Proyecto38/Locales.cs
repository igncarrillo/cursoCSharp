using System;

namespace Proyecto38
{
    public class Locales : Inmuebles
    {
        private int numeroVentanas;

        public Locales()
        {
            Console.Write("Ingrese el numero de ventanas del local: ");
            numeroVentanas = int.Parse(Console.ReadLine());
        }
        public override double CalcularPrecio()
        {
            double precio=base.CalcularPrecio();
            double precio1 = 0;
            double precio2 = 0;
            if (MetrosCuadrados > 50)
            {
                precio1+=PrecioBase * 0.01;
            }

            if (numeroVentanas > 4)
            {
                precio2 +=PrecioBase * 0.02;
            }
            else
            {
                if (numeroVentanas == 1 | numeroVentanas == 0)
                {
                    precio2 -= PrecioBase * 0.02;
                }
            }

            return precio + precio1 + precio2;
        }
    }
}