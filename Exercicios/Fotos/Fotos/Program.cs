namespace Fotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlbumDeFotos fotas1 = new AlbumDeFotos();
            Console.WriteLine("Situação 1");
            fotas1.TotalDeFotos = 40;
            fotas1.NumeroDeFotos= 60;
            fotas1.TotalDePaginas= 30;
            Console.WriteLine("Limite de Fotos:40,Quantia de Fotos:60");

            AlbumDeFotos fotas2 = new AlbumDeFotos();
            Console.WriteLine("Situação 2");
            fotas1.TotalDeFotos = 96;
            fotas1.NumeroDeFotos = 20;
            fotas1.TotalDePaginas = 30;
            Console.WriteLine("Limite de Fotos:20,Quantia de Fotos:96");
        }
    }
}