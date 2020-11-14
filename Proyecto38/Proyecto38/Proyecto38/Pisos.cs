using System;

namespace Proyecto38
{
    public class Pisos : Inmuebles
    {
        private int numeroPiso;

        public Pisos()
        {
            Console.Write("Ingrese el numero de piso del Piso: ");
            numeroPiso = int.Parse(Console.ReadLine());
        }

        public override double CalcularPrecio()
        {
            double  precio2 = 0;
            double precio = base.CalcularPrecio();
            if (numeroPiso >= 3)
            {
                precio2 = PrecioBase * 0.03;
            }
            
            return precio + precio2 ;
        }
    }
}