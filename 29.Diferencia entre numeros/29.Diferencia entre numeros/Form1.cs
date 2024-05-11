namespace _29.Diferencia_entre_numeros
{
    public partial class Form1 : Form
    {
        Diferencia diferencia = new Diferencia();
        public Form1()
        {
            InitializeComponent();
        }

        private void Encontrar_Click(object sender, EventArgs e)
        {
            Resultado.Text = diferencia.DiferenciaEntreDosNumeros(Convert.ToInt32(Numero1.Text),
                                                                  Convert.ToInt32(Numero2.Text))
                                                                  .ToString();
        }
    }
}
