namespace RelacionComposicion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mesa mesa = new Mesa();
            foreach (var pata in mesa.Patas)
            {
                pata.Imprimir();
            }
            DVD dvd1 = new DVD{Nombre = "Tierra de osos"};
            ReproductorDVD.Reproducir(dvd1);
        }
    }
}