using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.SignosOpuestos
{
    internal class Calcular
    {
        public string verificarSiAmbosNumerosSonPositivos(int numero1 , int numero2) {
            string resultado = numero1 < 0 && numero2 > 0 || numero1 > 0 && numero2 < 0 ? "Signos opuestos" : "Son del mismo signo";
            return resultado;
        }
    }
}
