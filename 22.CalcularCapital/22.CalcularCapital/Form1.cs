namespace _22.CalcularCapital
{
    public partial class Form1 : Form
    {
        CalcularCapital CalcularCapital = new CalcularCapital();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = CalcularCapital.CalcularInteresDeCapital(Convert.ToDouble(Numero.Text)).ToString() + " $";
        }
    }
}
