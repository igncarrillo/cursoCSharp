using System;

namespace Proyecto23
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

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

        public int Antiguedad
        {
            get
            {
                return antiguedad;
            }
            set
            {
                if(value>=0)
                {
                    antiguedad = value;
                }
                else
                {
                    Console.WriteLine("\nNo se puede tener una antiguedad negativa");
                }
            }
        }
    }
    
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1=new Socio();
            socio1.Nombre = "Ignacio";
            socio1.Antiguedad = 3;
            socio2=new Socio();
            socio2.Nombre = "Pedro";
            socio2.Antiguedad = 5;
            socio3=new Socio();
            socio3.Nombre = "Florencia";
            socio3.Antiguedad = -4;
            socio3.Antiguedad = 6;
        }

        public void ImprimirSocioMasAntiguo()
        {
            if (socio1.Antiguedad>socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("\nEl socio con mayor antiguedad es " + socio1.Nombre +
                                  " con una antiguedad de " + socio1.Antiguedad + " años");
            }
            else
            {
                if (socio2.Antiguedad > socio3.Antiguedad)
                {
                    Console.WriteLine("\nEl socio con mayor antiguedad es " + socio2.Nombre +
                                      " con una antiguedad de " + socio2.Antiguedad + " años");
                }
                else
                {
                    Console.WriteLine("\nEl socio con mayor antiguedad es " + socio3.Nombre +
                                      " con una antiguedad de " + socio3.Antiguedad + " años");
                }
            }
        }
        
        public static void Main(string[] args)
        {
            Club club1 = new Club();
            club1.ImprimirSocioMasAntiguo();
        }
    }
}