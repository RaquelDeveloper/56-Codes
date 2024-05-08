using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56_codes._2.perimetroCirculo
{
    public partial class Vista : Form
    {
        calculo calculo;
        public Vista()
        {
            InitializeComponent();
            calculo = new calculo();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
           Resultado.Text = calculo.perimetro(Convert.ToDouble(Radio.Text)).ToString();
        }

    }
}
