namespace _10.DeterminarFuerzaDeUnObjeto
{
    public partial class Form1 : Form
    {
        Calcular Calcular = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
             Resultado.Text = Calcular.Fuerza(Convert.ToDouble(masa.Text), Convert.ToDouble(aceleracion.Text)).ToString();
        }
    }
}
