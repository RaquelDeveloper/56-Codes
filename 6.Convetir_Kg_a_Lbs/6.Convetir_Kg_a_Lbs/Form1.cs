namespace _6.Convetir_Kg_a_Lbs
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
            Resultado.Text = calcular.ConvertirLbs(double.Parse(Kg.Text)).ToString();
        }
    }
}
