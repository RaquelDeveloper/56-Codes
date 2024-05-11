namespace _20.ParOImpar
{
    public partial class Form1 : Form
    {
        Vericador verificador = new Vericador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            Resultado.Text = verificador.VericadorPar_o_Impar(Convert.ToInt32(Numero.Text));
        }
    }
}
