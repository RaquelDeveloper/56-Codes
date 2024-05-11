namespace _16.EnergiaTotalQueAlmacenaNuestroCuerpo
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
            Resultado.Text = calcular.CalcularEnergiaTotal(Convert.ToDouble(Masa.Text),
                                                           Convert.ToDouble(Velocidad.Text),
                                                           Convert.ToDouble(Altura.Text))
                                                           .ToString();
        }
    }
}
