using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.EntradaDeDosNumerosX
{
    internal class Calculos
    {

        public string verificarSigos(double numero1, double numero2) { 
            
            if(numero1 < 0 && numero2 < 0 ){ 
                return $"{Math.Pow(numero1, 2) + Math.Pow(numero2, 2)}";
            }
            else if(numero1 < 0 && numero2 >= 0)
            {
                return $"{numero1 + numero2}";
            }
            else if (numero1 >= 0 &&  numero2 < 0) {
                return $"{numero1 / numero2}";
            }
            else if (numero1 >= 0 && numero2 >= 0)
            {
                double condicion = numero1 > numero2 ? numero1 + numero2 : Math.Sqrt(numero1);
                return condicion.ToString() ;
            }
            return "";
        }

    }
}
