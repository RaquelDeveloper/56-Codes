using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.VotanteONO
{
    internal class Verificar
    {
        public string VerificarEdad(int edad) {

            return edad > 16 ? "Votante" : "No es Votante";
        }
    }
}
