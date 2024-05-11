using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CalcularCapital
{
    internal class CalcularCapital
    {
        public double CalcularInteresDeCapital(double numero) { 
            return numero > 10000 ? numero*0.07 : numero*0.06;
        }
    }
}
