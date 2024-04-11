namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Àrea Quadrado/Retângulo");

            Area pimparino = new Area();
            Console.WriteLine(pimparino.Calcular());
            Console.WriteLine(pimparino.Dados());
        }
    }
}