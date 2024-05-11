using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.LeerCalificacionDeAlumno
{
    internal class Verificar
    {

        public string LeerCalificacionDeAlumno(double nota) { 
            return nota >= 60 ? "Aprobado" : "Reprobado";
        }

    }
}
