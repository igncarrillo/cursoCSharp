namespace Proyecto37
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TorreDeControl torreMendoza = new TorreDeControl();
            torreMendoza.AgregarVolador(new Boeing());
            torreMendoza.AgregarVolador(new Pato());
            torreMendoza.AgregarVolador(new Superman());
            torreMendoza.VuelenTodos();
        }
    }
}