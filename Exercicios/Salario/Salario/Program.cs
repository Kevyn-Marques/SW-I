namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario sal = new Pagamento();
            sal.Nome = "Carlos Da Shell";
            sal.Sal = 1345;
            sal.HED = 0;
            sal.HEN = 64;
            sal.ND = 0;
            sal.Fal = 52;
            sal.DE = 5;
            sal.REF = 5;
            sal.Val = 4;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}
