namespace AutoKulu
{
    public partial class KustanusForm : Form
    {
        public KustanusForm()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustanukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);    
            pesut = Convert.ToDouble(PestutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(PolttonestTB.Text);
            kustanukset = (laina + nesteet+ vakuutus + pesut + huollot+ renkaat + kilometrit + muut) / (kilometrit / 12);
            VastausLB.Text = "kustanukset kilometria kohti ovat: " + kustanukset;
            VastausLB.Visible = true;
        }
    }
}