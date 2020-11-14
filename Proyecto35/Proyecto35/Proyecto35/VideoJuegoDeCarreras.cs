using System.Collections.Generic;

namespace Proyecto35
{
    static class VideoJuegoDeCarreras
    {
       static private List<Icorredor> corredores;

        static VideoJuegoDeCarreras()
        {
            corredores = new List<Icorredor>();
            corredores.Add(new Maratonista());
            corredores.Add(new Caballo());
            corredores.Add(new Ferrari());
            corredores.Add(new Perro());
        }

        static public void IniciarCarrera()
        {
            foreach (var elemento in corredores)
            {
                elemento.Correr();
            }
        }
    }
}