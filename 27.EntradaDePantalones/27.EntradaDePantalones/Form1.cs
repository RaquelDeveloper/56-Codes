namespace _27.EntradaDePantalones
{
    public partial class Form1 : Form
    {
        Pantalones pantalones = new Pantalones();
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularCosto_Click(object sender, EventArgs e)
        {
            Resultado.Text = pantalones.CostoPantalones(Convert.ToDouble(Numero.Text)).ToString();
        }
    }
}
