using System;

namespace Proyecto35
{
    class Caballo : Animal, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El caballo comienza a correr...");
        }
    }
}