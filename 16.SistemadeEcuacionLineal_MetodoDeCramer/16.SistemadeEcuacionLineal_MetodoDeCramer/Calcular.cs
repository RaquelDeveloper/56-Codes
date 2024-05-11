using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SistemadeEcuacionLineal_MetodoDeCramer
{
    public class Calcular
    {
        public double calcularDeterminante(double[,] matriz)
        {
            double determinante = 0;
            if (matriz.GetLength(0) == 2)
            {
                determinante = (matriz[0, 0] * matriz[1, 1]) - (matriz[0, 1] * matriz[1, 0]);
            }
            else
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double[,] matrizAux = new double[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1];
                    
                    for (int j = 1; j < matriz.GetLength(0); j++)
                    {
                        for (int k = 0; k < matriz.GetLength(1); k++)
                        {
                            if (k < i)
                            {
                                matrizAux[j - 1, k] = matriz[j, k];
                            }
                            else if (k > i)
                            {
                                matrizAux[j - 1, k - 1] = matriz[j, k];
                            }
                        }
                    }
                    determinante += Math.Pow(-1, i) * matriz[0, i] * calcularDeterminante(matrizAux);
                }
            }
            return determinante;
        }

        public double calcularEcuacionMetodoCramer(double[,] matriz, double[] resultados)
        {
            double determinante = calcularDeterminante(matriz);
            double[] resultadosCramer = new double[resultados.Length];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                double[,] matrizAux = new double[matriz.GetLength(0), matriz.GetLength(1)];

                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    for (int k = 0; k < matriz.GetLength(1); k++)
                    {
                        matrizAux[j, k] = matriz[j, k];
                    }
                }

                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    matrizAux[j, i] = resultados[j];
                }
                resultadosCramer[i] = calcularDeterminante(matrizAux) / determinante;
            }
            return resultadosCramer[0];
        }

       

    }
}
