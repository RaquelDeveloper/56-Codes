namespace _19.VotanteONO
{
    public partial class Form1 : Form
    {
        Verificar verificar = new Verificar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            Resultado.Text = verificar.VerificarEdad(Convert.ToInt32(Edad.Text));
        }
    }
}
