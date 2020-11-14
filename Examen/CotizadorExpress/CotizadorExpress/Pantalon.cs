using System;

namespace CotizadorExpress
{
    public class Pantalon : Prenda
    {
        private bool esChupin; //F es comun

        public Pantalon()
        {
            MenuChupin();
            if (esChupin)
            {
                CantidadEnStock = 1500;
            }
            else
            {
                CantidadEnStock = 500;
            }
            Console.WriteLine();
            do
            {
                try
                {
                    Console.Write("Ingrese el precio base del pantalon: ");
                    PrecioPrenda = double.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Precio invalido. Intente nuevamente");
                }

            } while (PrecioPrenda == 0);
        }
        private void MenuChupin()
        {
            char entrada = '0';

            var exit = false;
            do
            {
                Console.Write(@"
                Elija el tipo de corte:
                1- Corte chupin
                2- Corte convencional
                Respuesta: ");
                try
                {
                    entrada = char.Parse(Console.ReadLine());
                    switch (entrada)
                    {
                        case '1':
                            esChupin = true;
                            exit = true;
                            break;
                        case '2':
                            esChupin = false;
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

        public override double calcularPrecio()
        {
            double variacion = 0;
            double variacion2 = 0;
            variacion = base.calcularPrecio();
            if (esChupin)
            {
                 variacion2= PrecioPrenda * 0.12;
            }

            return (PrecioPrenda+variacion-variacion2);
        }
    }
}