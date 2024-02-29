using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private int Potencia { get; set; }
        private string? Cor { get; set; }

        public void Ligar()
        {
            Ligada = true;
        }
        public void Desigar()
        {
            Ligada = false;
        }
        public bool TarLigadar()
        {
            return Ligada;
        }
        public void QueCor(string fussia)
        {
            Cor = fussia;
        }
        public void TaPotente(int potente)
        {
            Potencia = potente;
        }
        public string corzinha()
        {
            return Cor;
        }
        public int poder()
        { 
            return Potencia; 
        }
    }
}
