using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EvaluacionDeFuncion
{
    public class Calcular
    {
        public double CalcularFuncion(double x)
        {
            double resultado = Math.Pow(5 * x,4) + Math.Pow(2 * x , 3) + Math.Pow(3 *x ,2) + 7;

            return resultado;
        }

    }
}
