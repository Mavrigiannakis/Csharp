namespace SuosikkiNimi
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\mulle\\source\\repos\\Mavrigiannakis\\C-\\SuosikkiNimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\mulle\\source\\repos\\Mavrigiannakis\\C-\\SuosikkiNimi\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;
            foreach (string poju in pojat)
            {
                if (nimi == poju)
                {
                    VastausLB.Text = " Nimesi on " + laskurip + ".suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string friidu in tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ".suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
                VastausLB.Visible = true;
            }
        }
    }
}