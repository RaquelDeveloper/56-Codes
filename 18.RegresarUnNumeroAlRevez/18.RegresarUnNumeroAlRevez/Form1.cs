namespace _18.RegresarUnNumeroAlRevez
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Invertir_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular.InvertirString(Palabra.Text);
        }
    }
}
