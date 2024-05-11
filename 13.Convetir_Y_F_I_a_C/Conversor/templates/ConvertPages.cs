using Conversor.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinBlur.UI;

namespace Conversor.templates
{
    public partial class ConvertPages : Form
    {
        String nombre;
        public ConvertPages(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetBlurStyle(cntrl: this, blurType: BlurType.Acrylic, designMode: Mode.DarkMode);
            this.nombre = nombre;

            nombrerecibido.Text = "Bienvenido " + this.nombre;

        }


        private void Value_TextChanged(object sender, EventArgs e)
        {
            Selection selection = new Selection();
             try
             {
                Result.Text = selection.temperatureSelection(Selection1.Text, Selection2.Text, Convert.ToDouble(Value.Text)).ToString();
             }
             catch (Exception) {
                Result.Text = "0";
             }   
        }
    }


}
