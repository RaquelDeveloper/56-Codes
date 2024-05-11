using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conversor.models
{
    internal class Selection
    {

        public double temperatureSelection(String Medida1,String Medida2,  double value)
        {
            ConversionMedidas temperaturecalculations = new ConversionMedidas();
            double result = 0;
            String content = Medida1 + Medida2;

            switch (content)
            {
                case "YC":
                    result = temperaturecalculations.ConvertirYardasACentimetros(value);     
                    break;
                case "CY":
                   result = temperaturecalculations.ConvertirCentimetrosAYardas(value);
                    break;
                case "FC":
                    result = temperaturecalculations.ConertirPiesACentimetros(value);
                    break;
                case "CF":
                    result = temperaturecalculations.ConvertirCentimetrosAPies(value);
                    break;
                case "IC":
                    result = temperaturecalculations.ConvertirPulgadasACentimetros(value);
                    break;
                case "CI":
                    result = temperaturecalculations.ConvertirCentimetrosAPulgadas(value);
                    break;
                case "YY":
                    result = value;
                    break;
                case "FF":
                    result = value;
                    break;
                case "II":
                    result = value;
                    break;
                case "CC":
                    result = value;
                    break;
                default:
                    break;
                
            }

            return result;
        }


    }
}
