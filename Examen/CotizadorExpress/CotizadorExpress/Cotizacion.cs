using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace CotizadorExpress
{
    public class Cotizacion : Iimprimible
    {
        public string NumeroIdentificacion { get; }
        public DateTime FechaHora { get; }
        public string CodigoVendedor { get; }

        public Prenda PrendaCotizada { get;}
        
        public int CantidadUnidades { get; }
        public double ResultadoCotizacion { get; set; }
        
        private static int numeroGenerador=1; //Generador de codigo sucesivos para cotizaciones
            
        public Cotizacion(Vendedor vendedor)
        {
            this.CodigoVendedor = vendedor.CodigoVendedor;
            FechaHora = DateTime.Now;
            NumeroIdentificacion = (numeroGenerador++).ToString();
            if (menuCotizacion() == 1)
            {
                PrendaCotizada = new Pantalon();
            }
            else
            {
                PrendaCotizada = new Camisa();
            }
            do
            {
                try
                {
                    Console.Write("Ingrese la cantidad de unidades deseadas: ");
                    CantidadUnidades = int.Parse(Console.ReadLine());
                    if (CantidadUnidades <= 0)
                    {
                        Console.WriteLine("Debe ingresar una cantidad superior a cero");
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (CantidadUnidades <= 0);
        }

        public void RealizarCalculo()
        {
            ResultadoCotizacion = PrendaCotizada.calcularPrecio() * CantidadUnidades;
        }
        public int menuCotizacion()
        {
            char entrada = 'a';
            var exit = false;
            do
            {
                Console.Write(@"
                Que prenda desea cotizar?
                1- Pantalon
                2- Camisa
                Respuesta: ");
                try
                {
                    entrada = char.Parse(Console.ReadLine());
                    if (entrada != '1' & entrada != '2')
                    {
                        Console.WriteLine("Orden invalida, intente nuevamente");
                    }
                    else
                    {
                        exit = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message+"Intente nuevamente");
                }
            } while (!exit);

            return int.Parse(entrada.ToString());
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cotizacion {NumeroIdentificacion}, realizada el dia {FechaHora}hs");
            Console.WriteLine($"Producto: {PrendaCotizada.GetType()} | Precio Inicial: {PrendaCotizada.PrecioPrenda}  | Cantidad de unidades: {CantidadUnidades} | Precio Final: {ResultadoCotizacion}");
            Console.WriteLine();
        }
    }

}