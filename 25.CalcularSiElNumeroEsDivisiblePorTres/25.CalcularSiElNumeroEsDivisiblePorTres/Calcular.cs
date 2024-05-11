using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.CalcularSiElNumeroEsDivisiblePorTres
{
    internal class Calcular
    {

        public string CalcularSiEsDivisiblePorTres(double numero) {
            return numero % 3 == 0 ? "Es divisible por tres" : "No es divisible por tres";
        }

    }
}
