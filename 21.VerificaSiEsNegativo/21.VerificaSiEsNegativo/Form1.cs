namespace _21.VerificaSiEsNegativo
{
    public partial class Form1 : Form
    {
        Class1 verificar = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Resultado.Text = verificar.verificarSiEsNegativo(Convert.ToDouble(Numero.Text)).ToString();
        }
    }
}
