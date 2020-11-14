using System;
using System.Collections.Generic;

namespace Relaciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Profesor> lista = new List<Profesor>();
            lista.Add(new Profesor("Ignacio"));
            lista.Add(new Profesor("Pedro"));
            
            lista[0].AñadirMateria(new Materia {Nombre = "Matematica"});
            lista[0].AñadirMateria(new Materia {Nombre = "Lengua"});
            
            Materia informatica = new Materia{Nombre = "Informatica"};
            lista[1].AñadirMateria(informatica);
            
            Tema tema1 = new Tema{Nombre = "OOP"};
            Tema tema2 = new Tema{Nombre = "C#"};
            
            informatica.AgregarTema(tema1,tema2);

            foreach (var profesor in lista)
            {
                Console.WriteLine($"Materias Dictadas por el profesor {profesor.Nombre}: ");
                foreach (var materia in profesor.MateriasDictadas)
                {
                    Console.WriteLine($"{materia.Nombre}");
                    if (materia.TemasEnMateria.Count != 0)
                    {
                        foreach (var tema in materia.TemasEnMateria)
                        {
                            Console.WriteLine($"Tema: {tema.Nombre}");   
                        }
                    }
                }   
            }
            
            Console.WriteLine($"Profesor titular de la materia {informatica.Nombre}: {informatica.Profesor.Nombre}");
            
        }
    }
}