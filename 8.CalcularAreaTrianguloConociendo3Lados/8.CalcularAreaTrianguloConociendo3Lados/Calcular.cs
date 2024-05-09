using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CalcularAreaTrianguloConociendo3Lados
{
    public  class Calcular
    {

        public double CalcularAreaTriangulo(double lado1, double lado2, double lado3)
        {
            double s = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
            return area;
        }

    }
}
