using System;

namespace Proyecto35
{
    class Ferrari : Vehiculo, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("La ferrari acelera y comienza a correr...");
        }
    }
}