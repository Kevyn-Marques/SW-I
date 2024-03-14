using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class Conta
    {
        public string? num_conta { get; set; }                          
        public float saldo { get; set; }        
        private float limite { get; set; }

        public float consulta_saldo()
        {
            return saldo;
        }
        public void deposito(float dep)
        {
            saldo += dep;
            Console.WriteLine("Seu saldo após o deposito é de:R$ " + saldo);
            Console.WriteLine("Você pode sacar até R$" + (saldo + limite));
        }

        public void ajusta_limite(float lim)
        {
            limite = lim;
            Console.WriteLine("Seu limite é de R$ " + limite);
        }
        public void sacar(float saque)
        {
            if (saque <= saldo + limite)
            {
                saldo -= saque;
            }
            else
            {
                Console.WriteLine("Você não possui saldo o suficiente para sacar");
            }
        }
    }
}
