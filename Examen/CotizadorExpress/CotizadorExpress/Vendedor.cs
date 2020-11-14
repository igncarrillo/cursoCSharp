using System;
using System.Collections.Generic;

namespace CotizadorExpress
{
    public class Vendedor
    {
        public string Nombre { get;}
        public string Apellido { get;}
        public string CodigoVendedor { get; }

        private Random generadorCodigo = new Random(); //Generador de codigo aleatorio para vendedor
        public Stack<Cotizacion> HistorialVendedor { get;}
        public TiendaDeRopa Tienda { get;}
        public Vendedor(string nombre, string apellido, TiendaDeRopa tienda)
        {
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = generadorCodigo.Next(0, 100).ToString();
            HistorialVendedor = new Stack<Cotizacion>();
            Tienda = tienda;
            tienda.AgregarVendedor(this);
        }

        public void RealizarCotizacion()
        {
            HistorialVendedor.Push(new Cotizacion(this));
        }
    }
    
}