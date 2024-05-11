namespace _28.SignosOpuestos
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            Resultado.Text = calcular
                .verificarSiAmbosNumerosSonPositivos(Convert.ToInt32(Numero1.Text),
                                                    Convert.ToInt32(Numero2.Text));
        }
    }
}
