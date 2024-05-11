using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.VerificaSiEsNegativo
{
    internal class Class1
    {
        public double verificarSiEsNegativo(double numero) {
            return numero >= 0 ? Math.Pow(numero, 2) : Math.Pow(numero, 4);
        }
    }
}
