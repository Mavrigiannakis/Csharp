namespace Paivakirja
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\mulle\\source\\repos\\Mavrigiannakis\\C-\\Paivakirja\\demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\mulle\\source\\repos\\Mavrigiannakis\\C-\\Paivakirja\\demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}