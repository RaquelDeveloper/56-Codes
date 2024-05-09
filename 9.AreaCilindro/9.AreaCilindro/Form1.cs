namespace _9.AreaCilindro
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
            Resultado.Text = calcular.Area(double.Parse(Radio.Text), double.Parse(Altura.Text)).ToString();
        }
    }
}
