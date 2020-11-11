using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Proyecto27
{ 
  class Pila
  {
    private Stack<char> pila;

    public Pila()
    {
      pila = new Stack<char>();
    }

    public void InsertarElemento(char x)
    {
      pila.Push(x);
    }

    public char BorrarElemento()
    {
      if(pila.Count>0){
        return pila.Pop();
      }
      else
      {
        return Char.MaxValue;
      }
    }

    public void ImprimirPila()
    {
      foreach (var elemento in pila)
      {
        Console.Write("---"+elemento);
      }
      Console.WriteLine();
    }

    public int ContarElementos()
    {
      return pila.Count;
    }

    public bool PilaVacia()
    {
      if (pila.Count==0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public char ObtenerCima()
    {
      return pila.Peek();
    }
  }

  class Formula
  {
    private Pila pila;
    private string form;

    public Formula()
    {
      pila=new Pila();
      
      Console.WriteLine("Ingrese la formula: ");
      form = Console.ReadLine();
    }

    public void AnalizarFormula()
    {
      for (int f = 0; f < form.Length; f++)
      {
        if (form.ElementAt(f) == '(' | form.ElementAt(f) == '{' | form.ElementAt(f) == '[')
        {
          pila.InsertarElemento(form.ElementAt(f));
        }
        else
        {
          if (form.ElementAt(f) == ')')
          {
            if (pila.BorrarElemento() != '(')
            {
              Console.WriteLine("Formula erronea");
              return;
            }
          }
          else
          {
            if (form.ElementAt(f) == '}')
            {
              if (pila.BorrarElemento() != '{')
              {
                Console.WriteLine("Formula erronea");
                return;
              }
            }
            else
            {
              if (form.ElementAt(f) == ']')
              {
                if (pila.BorrarElemento() != '[')
                {
                  Console.WriteLine("Formula erronea");
                  return;
                }
              }
            }
          }
        }
      }

      if (pila.PilaVacia())
      {
        Console.WriteLine("Correcta");
      }
      else
      {
        Console.WriteLine("Incorrecta");
      }
    }

    public static void Main()
    {
      Formula formula = new Formula();
      formula.AnalizarFormula();
    }
  }
}