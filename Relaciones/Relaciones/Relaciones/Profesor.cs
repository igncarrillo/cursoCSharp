using System.Collections.Generic;

namespace Relaciones
{
    public class Profesor
    {
        public string Nombre { get;}
        public List<Materia> MateriasDictadas { get; }
        
        public Profesor(string nombre)
        {
            Nombre = nombre;
            MateriasDictadas = new List<Materia>();
        }

        public void AñadirMateria( Materia materia)
        {
            MateriasDictadas.Add(materia);
            materia.Profesor = this;
        }
    }
}