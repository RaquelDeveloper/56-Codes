using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_codes
{
    public class Calculo
    {
        public double baseTriangulo { get; set; }
        public double alturaTriangulo { get; set; }

        public double areaTriangulo()
        {
            return baseTriangulo * alturaTriangulo / 2;
        }
    }
}
