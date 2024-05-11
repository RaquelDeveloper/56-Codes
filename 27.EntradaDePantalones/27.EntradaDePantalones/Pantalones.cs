using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.EntradaDePantalones
{
    internal class Pantalones
    {
        public double CostoPantalones(double pantalones) {
            double costoPantalones = pantalones > 3 ? 12 : 10 ;
            return costoPantalones * pantalones;
        }

    }
}
