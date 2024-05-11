using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.EnergiaTotalQueAlmacenaNuestroCuerpo
{
    internal class Calcular
    {
        //ET = EC + EP

        public double calcularEnergiaCinetica(double masa, double velocidad) {
            return masa * Math.Pow(velocidad,2) /2;
        }
        public double calcularEnergiaPotencial(double masa, double altura) {
            double gravedad = 9.81;
            return masa*gravedad*altura;
        }

        public double CalcularEnergiaTotal(double masa, double velocidad, double altura) {
            return calcularEnergiaCinetica(masa, velocidad) + calcularEnergiaPotencial(masa, altura);
        }
    }
}
