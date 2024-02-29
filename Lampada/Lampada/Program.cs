namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-------------Objeto--------------
            Lampada lampadanovamlk = new Lampada();

            //--------------Chamando método pra ligar a lampada--------

            //--------------Método------------------
            lampadanovamlk.Ligar();

            lampadanovamlk.QueCor("Rosa");

            lampadanovamlk.TaPotente(120);

            Console.WriteLine("A lampada está ligada? " + lampadanovamlk.TarLigadar());
            Console.WriteLine("A cor da lampada é " + lampadanovamlk.corzinha());
            Console.WriteLine("a Potencia é de " + lampadanovamlk.poder());
        }
    }
}