namespace _5.EvaluacionDeFuncion
{
    public partial class vista : Form
    {
        Calcular calcular;
        public vista()
        {
            InitializeComponent();
            calcular = new Calcular();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.CalcularFuncion(double.Parse(X.Text)).ToString();
        }
    }
}
