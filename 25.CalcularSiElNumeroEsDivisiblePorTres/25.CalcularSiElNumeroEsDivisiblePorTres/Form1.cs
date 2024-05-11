namespace _25.CalcularSiElNumeroEsDivisiblePorTres
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.CalcularSiEsDivisiblePorTres(Convert.ToDouble(numero.Text));
        }
    }
}
