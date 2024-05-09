using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.promedio
{
    public class Calcular
    {
        public double Promedio(double[] numeros)
        {
            double suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            return suma / numeros.Length;
        }
    }
}
