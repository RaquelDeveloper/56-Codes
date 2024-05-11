using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.EncontrarValorDelDeterminanteDeSegundoOrden
{
    internal class Calcular
    {

        public double Determinante(double[,] matriz)
        {
            double determinante = 0;
            determinante = (matriz[0, 0] * matriz[1, 1]) - (matriz[0, 1] * matriz[1, 0]);
            return determinante;
        }

        public string Mostrar(double[,] matriz)
        {
            string saltoDeLinea = Environment.NewLine;
            return $"|{matriz[0, 0]}  {matriz[0, 1]}|{saltoDeLinea}|{matriz[1, 0]}  {matriz[1, 1]}|"
                   +$"{saltoDeLinea} {saltoDeLinea}"
                   +$" = {matriz[0, 0] * matriz[1, 1]} - {matriz[0, 1] * matriz[1, 0]} {saltoDeLinea} {saltoDeLinea}"
                   +$" = {Determinante(matriz)}"
           ;
            
        }

    }
}
