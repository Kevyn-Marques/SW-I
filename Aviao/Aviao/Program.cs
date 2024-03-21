namespace Aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao = new Aviao();

            aviao.Marca = "Airbus";
            aviao.Modelo = "a380";

            aviao.Acelerar(8);
            aviao.Subir(420);

            Console.WriteLine($"A altura do avião é: {aviao.Altitude}m, A velocidade é: {aviao.Velocidade}km/h, A marca é: {aviao.Marca}, e o modelo é: {aviao.Modelo}");
        }
    }
}