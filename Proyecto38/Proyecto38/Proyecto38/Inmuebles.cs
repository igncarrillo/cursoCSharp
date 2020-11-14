using System;

namespace Proyecto38
{
    public abstract class Inmuebles
    {
        private string direccion;
        private int metrosCuadrados;
        private double precioBase;
        private bool nuevo = true;

        #region Getters y Setters
        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public int MetrosCuadrados
        {
            get => metrosCuadrados;
            set => metrosCuadrados = value;
        }

        public double PrecioBase
        {
            get => precioBase;
            set => precioBase = value;
        }

        public bool Nuevo
        {
            get => nuevo;
            set => nuevo = value;
        }
        #endregion
        
        public Inmuebles()
        {
            Console.Write("Ingrese la direccion del inmueble: ");
            Direccion = Console.ReadLine();
            
            Console.Write("Ingrese los metros cuadrados del inmueble: ");
            MetrosCuadrados = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el precio del inmueble: ");
            PrecioBase = double.Parse(Console.ReadLine());
            
            Console.Write("Ingrese la antiguedad del inmueble: ");
            var antiguedad = int.Parse(Console.ReadLine());
            if (antiguedad > 15)
            {
                Nuevo = false;
            }
        }

        public virtual double CalcularPrecio()
        {
            double precio = 0;
            
            if (Nuevo)
            {
                 precio= precioBase * 0.99;
            }
            else
            {
                precio = precioBase * 0.98;
            }

            return precio;
        }
    }    
}