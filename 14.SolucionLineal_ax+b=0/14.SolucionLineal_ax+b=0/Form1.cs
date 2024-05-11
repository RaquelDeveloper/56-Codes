namespace _14.SolucionLineal_ax_b_0
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.CalcularX(double.Parse(a.Text), double.Parse(b.Text)).ToString();
        }
    }
}
