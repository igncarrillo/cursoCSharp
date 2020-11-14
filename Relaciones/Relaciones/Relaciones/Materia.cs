using System.Collections.Generic;

namespace Relaciones
{
    public class Materia
    {
        public string Nombre { get;  set; }
        public Profesor Profesor { get; set; }

        public List<Tema> TemasEnMateria { get; }

        public Materia()
        {
            TemasEnMateria = new List<Tema>();
        }

        public void AgregarTema(params Tema[] t)
        {
            foreach (var elemento in t)
            {
                TemasEnMateria.Add(elemento);
                elemento.Materia = this;  
            }
        }
    }
}