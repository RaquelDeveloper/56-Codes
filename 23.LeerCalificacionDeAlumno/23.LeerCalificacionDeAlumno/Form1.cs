namespace _23.LeerCalificacionDeAlumno
{
    public partial class Form1 : Form
    {
        Verificar verificar = new Verificar();
        public Form1()
        {
            InitializeComponent();
        }

        private void VerificarNota_Click(object sender, EventArgs e)
        {
            Resultado.Text = verificar.LeerCalificacionDeAlumno(Convert.ToDouble(Nota.Text));
            Color color = Resultado.Text == "Aprobado" ? Resultado.ForeColor = Color.Green : Resultado.ForeColor = Color.Red;
            Resultado.ForeColor = color;
        }
    }
}
