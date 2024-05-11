namespace Conversor
{
    using WinBlur;
    using MetroSet_UI.Forms;
    using static WinBlur.UI;
    using Conversor.templates;
    using System.Windows.Forms;

    public partial class WelcomePages : Form
    {
        public WelcomePages()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetBlurStyle(cntrl: this, blurType: BlurType.Tabbed, designMode: Mode.DarkMode);
        }

        private void ComenzarBtn_Click(object sender, EventArgs e)
        {
            String nombre = nombreTxt.Text;

            ConvertPages convertPages = new ConvertPages(nombre);
            this.Hide();
            convertPages.ShowDialog();
            this.Show();
        }
    }
}
