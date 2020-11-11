using System;
using System.Runtime.ConstrainedExecution;

namespace Proyecto24
{
    class Persona
    {
        protected string nombre;
        protected int edad;
        
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        
        public void Imprimir()
        {
            Console.WriteLine("Nombre: "+Nombre+" | Edad: "+Edad);
        }
    }

    class Empleado : Persona
    {
        private int sueldo;

        public int Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El sueldo es: "+Sueldo);
        }
    }
    
    class Prueba{
    public static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Agus";
            persona1.Edad = 26;
            Console.WriteLine("Persona:");
            persona1.Imprimir();
            
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Ignacio";
            empleado1.Edad = 26;
            empleado1.Sueldo = 85000;
            Console.WriteLine("Empleado:");
            empleado1.Imprimir();
        }
    }
    
}