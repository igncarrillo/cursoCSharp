using System;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml;

namespace Proyecto34
{
  class Operacion
  {
    public int Valor1 { get; private set; }
    public int Valor2 { get; private set; }

    public Operacion(int x=10, int y=0)
    {
      Valor1 = x;
      Valor2 = y;
    }

    public int Sumar()
    {
      return Valor1 + Valor2;
    }

    public int Restar()
    {
      return Valor1 - Valor2;
    }

    public int Multiplicar()
    {
      return Valor1 * Valor2;
    }

    public float Dividir()
    {
      if (Valor2 == 0)
      {
        throw new Exception("No se puede dividir por cero");
      }
      return ((float)Valor1 / (float)Valor2);
    }
  }

  class Programa
  { 
    static void Main()
    {
      try
      {
        Operacion operacion = new Operacion(4, 8);
        Console.WriteLine(operacion.Sumar());
        Console.WriteLine(operacion.Restar());
        Console.WriteLine(operacion.Multiplicar());
        Console.WriteLine(operacion.Dividir());
        Operacion operacion1 = new Operacion(5);
        Console.WriteLine(operacion1.Sumar());
        Console.WriteLine(operacion1.Restar());
        Console.WriteLine(operacion1.Multiplicar());
        Console.WriteLine(operacion1.Dividir());
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      
    }
  }
  
}