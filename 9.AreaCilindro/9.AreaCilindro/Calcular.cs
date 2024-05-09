using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AreaCilindro
{
    internal class Calcular
    {
        public double Area(double radio, double altura)
        {
            double area = 2 * Math.PI * radio * (radio + altura);
            return area;
        }
    }
}
