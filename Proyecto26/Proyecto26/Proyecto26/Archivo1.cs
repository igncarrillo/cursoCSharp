using System;

namespace Proyecto26
{
    class Programa
    {
        static void Main()
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base1 = 10;
            rectangulo.Altura2 = 2;
            Console.WriteLine("Perimetro: " + rectangulo.RetornarPerimetro());
            Console.WriteLine("Area: " + rectangulo.RetornarSuperficie());
        }
    }
}