namespace Proyecto36
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Impresora impresoraHP = new Impresora();
            impresoraHP.AgregarImprimible(new Contrato());
            impresoraHP.AgregarImprimible(new Foto());
            impresoraHP.AgregarImprimible(new Documento());
            
            impresoraHP.ImprimirTodo();
        }
    }
}