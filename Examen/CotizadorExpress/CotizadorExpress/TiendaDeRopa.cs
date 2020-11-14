using System;
using System.Collections.Generic;

namespace CotizadorExpress
{
    public class TiendaDeRopa
    {
        public string Nombre { get; }
        public string Direccion { get; }
        private List<Vendedor> Vendedores { get;}
        
        private List<Prenda> prendasParaVender { get;}

        public TiendaDeRopa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Vendedores = new List<Vendedor>();
            prendasParaVender = new List<Prenda>();
        }

        public void AgregarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        
    }
}