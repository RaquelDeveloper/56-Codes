namespace _3.funcionLineal
{
    public partial class vista : Form
    {
        calcular calcular;
        public vista()
        {
            InitializeComponent();
            calcular = new calcular();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.calcularEcuacionLineal(Convert.ToDouble(X.Text)).ToString();
        }
    }
}
