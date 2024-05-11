using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.CalcularSiEsNegativoOPositivo_ResuelveUnaEcuacion
{
    internal class Verificarcs
    {
        public bool VerificarSiEsPositivoONegativo(double numero)
        {
            return numero > 0 ? true : false;
        }

        public double CalcularEcuaicon(double numero, double a) {
            bool verificar = VerificarSiEsPositivoONegativo(numero);
            
            return verificar ? Math.Pow(2,a) : 5+a;
        }

    }
}
