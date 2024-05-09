namespace _12.promedio
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        Verificador verificador = new Verificador();

        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                if (verificador.verificarTexto(nombreNota.Text))
                {
                    if (verificador.verificarNumero(ValorNota.Text))
                    {
                        tabla.Rows.Add(nombreNota.Text, ValorNota.Text);

                    }
                    else
                    {
                        MessageBox.Show("El valor de la nota no es un número");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de la nota no es válido");
                }
            }
            else
            {
                MessageBox.Show("Ya se ha calculado el promedio");
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            var notas = tabla.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => row.Cells["Nota"].Value.ToString())
                .ToList();

            double[] numeros = new double[notas.Count];
            for (int i = 0; i < notas.Count; i++)
            {
                numeros[i] = Convert.ToDouble(notas[i]);
            }

            if (numeros.Length == 0)
            {
                MessageBox.Show("No hay notas para calcular");
            }
            else
            {

                if (contador == 0)
                {
                    calcular.Promedio(numeros);
                    tabla.Rows.Add("Promedio", calcular.Promedio(numeros));
                    contador++;
                }
                else
                {
                    MessageBox.Show("Ya se ha calculado el promedio");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();

            if (contador == 1)
            {
                contador = 0;
            }
        }
    }
}
