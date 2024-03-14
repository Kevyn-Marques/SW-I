namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();  
            
            conta.ajusta_limite(700);

            conta.deposito(900);

            conta.consulta_saldo());

            conta.sacar(300);

            conta.consulta_saldo());
        }
    }
}