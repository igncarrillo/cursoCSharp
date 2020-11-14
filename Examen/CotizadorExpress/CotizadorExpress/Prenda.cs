using System;
using System.Dynamic;

namespace CotizadorExpress
{
    public class Prenda
    {
        protected string CalidadPrenda { get;}
        public double PrecioPrenda { get; protected set; }
        public int CantidadEnStock { get; protected set; }

        public virtual double calcularPrecio()
        {
            double variacionPrecio = 0;
            if (CalidadPrenda == "Premium")
            {
                variacionPrecio = PrecioPrenda * 0.3;
            }

            return variacionPrecio;
        }
        
        public Prenda()
        {
            char entrada = '0';

            var exit = false;
            do
            {
                Console.Write(@"
                Elija el tipo de prenda:
                1- Standar
                2- Premium
                Respuesta: ");
                try
                {
                    entrada = char.Parse(Console.ReadLine());
                    switch (entrada)
                    {
                        case '1':
                            CalidadPrenda = "Standar";
                            exit = true;
                            break;
                        case '2':
                            CalidadPrenda = "Premium";
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("La orden no existe, intente nuevamente");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Intente nuevamente");
                }
            } while (!exit);
        }
            
    }
}