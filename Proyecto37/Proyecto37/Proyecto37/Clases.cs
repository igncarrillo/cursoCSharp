using System;
using System.Collections.Generic;

namespace Proyecto37
{
    public class Pato : Ivolador
    {
        public int energia;

        public void Volar()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡cuack!");
        }
    }

    public class Boeing : Ivolador
    {
        private int horasDeVuelo;

        public void Volar()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un avion");
        }
    }

    public class Superman : Ivolador
    {
        private int experiencia;

        public void Volar()
        {
            experiencia += 3;
            Console.WriteLine("Estoy volando como un campeon");
        }
    }

    public class TorreDeControl
    {
        private List<Ivolador> voladores;

        public TorreDeControl()
        {
            voladores=new List<Ivolador>();
        }

        public void VuelenTodos()
        {
            foreach (var volador in voladores)
            {
                volador.Volar();
            }
        }

        public void AgregarVolador(Ivolador volador)
        {
            voladores.Add(volador);
        }
    }

    public interface Ivolador
    {
        void Volar();
    }
}