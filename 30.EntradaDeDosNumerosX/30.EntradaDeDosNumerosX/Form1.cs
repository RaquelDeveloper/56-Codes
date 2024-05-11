namespace _30.EntradaDeDosNumerosX
{
    public partial class Form1 : Form
    {
        Calculos calculos = new Calculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = calculos.verificarSigos(Convert.ToDouble(numero1.Text),
                                                     Convert.ToDouble(numero2.Text));
        }
    }
}
