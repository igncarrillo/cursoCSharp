using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace CotizadorExpress
{
    class Program
    {
        public static void Main(string[] args)
        {
            TiendaDeRopa tienda = new TiendaDeRopa("The geek clothes house", "Paso de los Andes 541, Mendoza");
            Vendedor vendedor = new Vendedor("Juan", "Perez", tienda);
            
            Console.WriteLine("\n***Programa calculador de cotizaciones***");
            EjecutarPrograma(tienda, vendedor);

            //La interfaz se realiza para un vendedor, pero posteriormente podria ser ampliada para utilizar varios.
        }

        public static void ImprimirEncabezado(TiendaDeRopa tienda, Vendedor vendedor)
        {
            Console.WriteLine($"\n{vendedor.Tienda.Nombre} | Direccion: {vendedor.Tienda.Direccion}");
            Console.WriteLine($"Usuario: {vendedor.Apellido},{vendedor.Nombre}    | Codigo vendedor: {vendedor.CodigoVendedor}");
        }

        public static void ImprimirMenu()
        {
            Console.Write(@"
            Menu:
            1- Ingresar nueva cotizacion 
            2- Imprimir ultima cotizacion 
            3- Imprimir historial de cotizacion
            Q- Salir

            Que desea realizar: ");
        }

        public static void EjecutarPrograma(TiendaDeRopa tienda, Vendedor vendedor)
        {
            var exit = false;
            do
            {
                ImprimirEncabezado(vendedor.Tienda, vendedor);
                ImprimirMenu();
                try
                {
                    var entrada = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                    switch (entrada)
                    {
                        case '1':
                            vendedor.RealizarCotizacion();
                            break;
                        case '2':
                            try
                            {
                                vendedor.HistorialVendedor.Peek().Imprimir();
                                break;
                            }
                            catch (System.InvalidOperationException e)
                            {
                                Console.WriteLine("No existen cotizaciones disponibles");
                                break;
                            }

                        case '3':
                            if (vendedor.HistorialVendedor.Count == 0)
                            {
                                Console.WriteLine("No existen cotizaciones disponibles");
                            }
                            else
                            {
                                foreach (var cotizacion in vendedor.HistorialVendedor)
                                {
                                    cotizacion.Imprimir();
                                }
                            }
                            break;

                        case 'Q':
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Entrada erronea, intente nuevamente..");
                            break;
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("\nERROR ..." + e.Message);
                }
                Console.Write("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (!exit);
        }
        
    }
}