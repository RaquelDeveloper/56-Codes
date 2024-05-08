namespace _56_codes
{
    public partial class Vista : Form
    {
        Calculo calculo;
        public Vista()
        {
            InitializeComponent();
            calculo = new Calculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo.baseTriangulo = double.Parse(Base.Text);
            calculo.alturaTriangulo = double.Parse(Altura.Text);
            Resultado.Text = calculo.areaTriangulo().ToString();
        }

    }
}
