namespace _4.raizCuadrada
{
    public partial class Vista : Form
    {
        Calcular calcular;
        public Vista()
        {
            InitializeComponent();
            calcular = new Calcular();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
           Resultado.Text = calcular.RaizCuadrada(Convert.ToDouble(valor.Text)).ToString();
        }
    }
}
