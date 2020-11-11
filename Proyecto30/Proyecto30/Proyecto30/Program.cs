using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Proyecto30
{
    class Producto
    {
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        
    }

    class Programa{
        static void Main(string[] args)
        {
            Dictionary<int,Producto> listaProductos = new Dictionary<int, Producto>();
            for (int i = 1; i < 10; i++)
            {
                listaProductos.Add(i,new Producto{Descripcion="Producto "+i, Precio =(i*100)});
            }

            int ingreso = 1;
            
            while (ingreso!=0)
            {
                Console.Write("Ingrese el codigo del producto a averiguar: ");
                ingreso = int.Parse(Console.ReadLine());

                if (listaProductos.ContainsKey(ingreso))
                {
                    Console.WriteLine(listaProductos[ingreso].Descripcion+" Precio: "+listaProductos[ingreso].Precio);
                }
                else
                {
                    Console.WriteLine("El producto especificado no existe");
                }
            }

        }
    }
}