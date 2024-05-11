namespace _24.CalcularSiEsNegativoOPositivo_ResuelveUnaEcuacion
{
    public partial class Form1 : Form
    {
        Verificarcs verificar = new Verificarcs();
        
        public Form1()
        {
            InitializeComponent();
            
            Estado.Visible = false;
            A.Visible = false;
            CalcularEcuacion.Visible = false;
            Resultado.Visible = false;
            Ecuacion.Visible = false;
          

        }

        private void CalcularNumero_Click(object sender, EventArgs e)
        {
            bool estadoNumero = verificar.VerificarSiEsPositivoONegativo(Convert.ToDouble(Numero.Text));
           
            HacerVisibleComponentes();

            if (estadoNumero)
            {
                Estado.Text = "Positivo";
                Ecuacion.Text = "Y=2^A";
            }
            else {
                Estado.Text = "Negativo";
                Ecuacion.Text = "Y=A+5";
            }

        }

        private void CalcularEcuacion_Click(object sender, EventArgs e)
        {
            bool estadoNumero = verificar.VerificarSiEsPositivoONegativo(Convert.ToDouble(Numero.Text));
            Resultado.Text = verificar.CalcularEcuaicon(Convert.ToDouble(Numero.Text), Convert.ToDouble(A.Text)).ToString();
        }

        public void HacerVisibleComponentes() {
            Estado.Visible = true;
            A.Visible = true;
            CalcularEcuacion.Visible = true;
            Resultado.Visible = true;
            Ecuacion.Visible = true;
        }

    }
}
