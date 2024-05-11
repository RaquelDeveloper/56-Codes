namespace _15.EncontrarValorDelDeterminanteDeSegundoOrden
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


            double[,] matriz =
            {
                {Convert.ToInt64(a_11.Text) , Convert.ToInt64(a_12.Text)  },
                {Convert.ToInt64(a_21.Text) , Convert.ToInt64(a_22.Text) }
            };

            Resultado.Text = calcular.Mostrar(matriz).ToString();
        }
    }
}
