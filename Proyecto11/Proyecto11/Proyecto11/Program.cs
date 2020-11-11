using System;

namespace Proyecto11
{
    class Persona
    {
        private int edad;
        private string nombre;

        public void Inicilizar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre=Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
        }
        
        public void Imprimir()
        {
            Console.WriteLine("Datos de la persona");
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void VerificarEdad()
        {
            if (edad >= 18)
            {
                Console.Write("La persona es mayor de edad");
            }
        }
        
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Inicilizar();
            persona1.Imprimir();
            persona1.VerificarEdad();
        }
    }
}