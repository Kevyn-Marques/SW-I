using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public float Base { get; set; }

        public float Altura { get; set; }   

        public float AreaTotal { get; set; }

        public string Calcular()
        {
            Console.WriteLine("Digite a base:");
            Base = float.Parse(Console.ReadLine() );
            Console.WriteLine("Digite a altura:");
            Altura= float.Parse(Console.ReadLine() );

            AreaTotal = Base * Altura;

            string tipo = " ";

            if(Base == Altura)
            {
                 tipo = " e é um Quadrado";
            }
            else
            {
                tipo = " e é um Retângulo";
            }

            string resultado = "A Àrea é " + AreaTotal;
            resultado += tipo; 

            return resultado;

        }
        public string Dados()
        {
            string informacao = "O valor da Base é:" + Base ;
            informacao += "\nO Valor Altura é:" + Altura ;
            return informacao;
        }
    }
}
