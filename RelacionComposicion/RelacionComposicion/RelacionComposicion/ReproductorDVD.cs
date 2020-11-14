using System;

namespace RelacionComposicion
{
    static class ReproductorDVD
    {
        public static void Reproducir(DVD dvd)
        {
            Console.WriteLine("...Reproduciendo {0}",dvd.Nombre);
        }
    }
}