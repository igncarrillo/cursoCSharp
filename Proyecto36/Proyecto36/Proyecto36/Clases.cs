using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Proyecto36
{
    public class Contrato : Iimprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
    public class Foto : Iimprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
    public class Documento : Iimprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }

    public class Impresora
    {
        private List<Iimprimible> colaDeImpresion;

        public Impresora()
        {
            colaDeImpresion = new List<Iimprimible>();
        }

        public void AgregarImprimible(Iimprimible imprimible)
        {
            colaDeImpresion.Add(imprimible);
        }

        public void ImprimirTodo()
        {
            foreach (var impresion in colaDeImpresion)
            {
                impresion.Imprimir();
            }
        }
    }

    public interface Iimprimible
    {
        void Imprimir();
    }
}