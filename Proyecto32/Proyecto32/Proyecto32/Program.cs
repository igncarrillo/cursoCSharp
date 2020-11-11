using System;


namespace Proyecto32
{
    delegate bool Imprimir(int x);
    class Estudiante
    {
        private string nombre;
        private int nota;

        public int Nota { get;  set; }
        public string Nombre { get;  set; }
        
    }

    class Curso
    {
        private Estudiante[] estudiantes;

        public Curso()
        {
            estudiantes = new Estudiante[5];

            for (int i = 0 ; i < estudiantes.Length ; i++){
                Estudiante estudiante = new Estudiante();
                Console.Write("Ingrese el nombre del estudiante: ");
                estudiante.Nombre = Console.ReadLine();
                Console.Write("Ingrese la nota del estudiante "+estudiante.Nombre+" : ");
                estudiante.Nota = int.Parse(Console.ReadLine());
                estudiantes[i] = estudiante;
            }
        }

        public void ImprimirEstudiantes(Imprimir delegado)
        {
            foreach (var estudiante in estudiantes)
            {
                if (delegado(estudiante.Nota))
                {
                    Console.WriteLine("Nombre: "+estudiante.Nombre+"| Nota: "+estudiante.Nota);
                }
            }
        }
        
    }
    

    class Programa
    {
        public static void Main(string[] args)
        {
            Curso curso1 = new Curso();
            Console.WriteLine("Todos: ");
            curso1.ImprimirEstudiantes((x)=> true);
            Console.WriteLine("Aprobados: ");
            curso1.ImprimirEstudiantes((x) => x >= 7);
            Console.WriteLine("NOTA 2: ");
            curso1.ImprimirEstudiantes((x) => x == 2);

        }
    }
}