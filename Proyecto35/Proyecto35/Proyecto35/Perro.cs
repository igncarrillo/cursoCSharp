using System;

namespace Proyecto35
{
    class Perro : Animal, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El perro comienza a correr...");
        }
    }
}