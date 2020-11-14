namespace ClasesATestear
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string DecirNombre()
        {
            return Nombre;
        }

        public int DecirEdad()
        {
            return Edad;
        }
        
        public static void Main(){
        }
    }
}