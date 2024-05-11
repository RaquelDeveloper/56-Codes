using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor.models
{
    internal class ConversionMedidas
    {


        public double ConvertirYardasACentimetros(double yardas)
        {
            try
            {
                double centimetros = yardas * 91.44;
                return centimetros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double ConvertirCentimetrosAYardas(double centimetros)
        {
            try
            {
                double yardas = centimetros / 91.44;
                return yardas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double ConertirPiesACentimetros(double pies)
        {
            try
            {
                double centimetros = pies * 30.48;
                return centimetros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double ConvertirCentimetrosAPies(double centimetros)
        {
            try
            {
                double pies = centimetros / 30.48;
                return pies;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double ConvertirPulgadasACentimetros(double pulgadas)
        {
            try
            {
                double centimetros = pulgadas * 2.54;
                return centimetros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double ConvertirCentimetrosAPulgadas(double centimetros)
        {
            try
            {
                double pulgadas = centimetros / 2.54;
                return pulgadas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
