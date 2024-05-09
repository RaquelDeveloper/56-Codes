namespace _8.CalcularAreaTrianguloConociendo3Lados
{
    public partial class Form1 : Form
    {
        Calcular calcular;
        public Form1()
        {
            InitializeComponent();
            calcular = new Calcular();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.CalcularAreaTriangulo(double.Parse(Lado1.Text), double.Parse(Lado2.Text), double.Parse(Lado3.Text)).ToString();
        }
    }
}
