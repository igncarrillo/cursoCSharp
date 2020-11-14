using System;
using System.Collections.Generic;

namespace Proyecto38
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Inmuebles> alquilables = new List<Inmuebles>();
            alquilables.Add(new Pisos());

            foreach (var alquilable in alquilables)
            {
                Console.WriteLine($"EL precio del {alquilable.GetType()} es: ${alquilable.CalcularPrecio()}");
            }
        }
    }
}