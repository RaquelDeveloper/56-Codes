namespace _7.Convertir_F_a_C
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
            Resultado.Text = calcular.Convertir(double.Parse(F.Text)).ToString();
        }
    }
}
