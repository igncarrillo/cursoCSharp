using System;
using System.Collections.Generic;

namespace RelacionComposicion
{
    public class Mesa
    {
        internal List<Pata> Patas { get;}

        public Mesa()
        {
            Patas = new List<Pata>();
            this.AgregarPatas();
        }

        public void AgregarPatas()
        {
            Console.Write("Ingrese la cantidad de patas que desea agregar a la mesa: ");
            int cantidadPatas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cantidadPatas; i++)
            {
                Patas.Add(new Pata(i.ToString()));
                Patas[i-1].Mesa = this;
            }
        }
        
        internal class Pata
        {
            public string Nombre { get; }
            public Mesa Mesa { get; set; }

            public Pata(string nombre)
            {
                Nombre = nombre;
            }

            public void Imprimir()
            {
                Console.WriteLine("Soy la pata: {0}", this.Nombre);
            }
        }
    }
}