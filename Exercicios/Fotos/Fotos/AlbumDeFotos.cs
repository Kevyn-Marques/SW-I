using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotos
{
    public class AlbumDeFotos
    {
        public int TotalDePaginas { get; set; }

        public int TotalDeFotos { get; set; }

        public int NumeroDeFotos
        {
            get
            {
                return NumeroDeFotos;
            }
            set
            {
                if(value > TotalDeFotos)
                {
                    Console.WriteLine("Você passou o limite de fotos");
                }
            }
        }
    }
}
