namespace _11.CalcularCoseno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text = Convert.ToString(new calcular().coseno(Convert.ToDouble(x.Text)));

        }
    }
}
