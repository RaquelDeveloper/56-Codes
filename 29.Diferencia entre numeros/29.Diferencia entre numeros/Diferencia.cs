using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Diferencia_entre_numeros
{
    internal class Diferencia
    {

        public int DiferenciaEntreDosNumeros(int numero1, int numero2) { 
            int diferencia = 0;

            if (numero1 > numero2)
            {
                diferencia = numero1 - numero2;
            }
            else {
                diferencia = numero2 - numero1;
            }

            return diferencia;
        }

    }
}
