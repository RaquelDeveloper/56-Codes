using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ParOImpar
{
    internal class Vericador
    {

        public string VericadorPar_o_Impar(int numero) {

            return numero % 2 == 0 ? "Es par" : "Es impar";
        }

    }
}
