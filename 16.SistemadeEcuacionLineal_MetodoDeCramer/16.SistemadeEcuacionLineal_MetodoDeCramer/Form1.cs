namespace _16.SistemadeEcuacionLineal_MetodoDeCramer
{
    public partial class Form1 : Form
    {
        Calcular Calculator = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double[,] matriz = 
            {
                { Convert.ToDouble(a.Text), Convert.ToDouble(b.Text) },
                { Convert.ToDouble(d.Text), Convert.ToDouble(E.Text) }
            };

            double[] matrizResultado = { Convert.ToDouble(c.Text), Convert.ToDouble(f.Text)};
            
            Resultado.Text = Calculator.calcularEcuacionMetodoCramer(matriz, matrizResultado).ToString();
        }
    }
}
