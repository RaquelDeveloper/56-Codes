using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _12.promedio
{
    internal class Verificador
    {
        public bool verificarTexto(string texto)
        {
            bool resultado;
            string regex = @"^[a-zA-Záéíóú\s]+$";

            if (texto == "")
            {
                resultado = false;
            }

            return resultado = Regex.IsMatch(texto, regex) ? true : false; 
        }

        public bool verificarNumero(string numero)
        {
            if (numero == "")
            {
                return false;
            }

            foreach (char c in numero.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
