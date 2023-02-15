using System.Drawing.Printing;
using System.Windows.Forms;

namespace Muistio
{
    public partial class Form1 : Form
    {
        string tiedostoPolku = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiedostoPolku = "";
            rikasTB.Text = "";
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog() { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;

                    }

                }
            }
        }

        private void tallenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {


                using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog()==DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                        /*using (StreamWriter vk = new StreamWriter(ttk.FileName))
                        {
                            vk.WriteLineAsync(rikasTB.Rtf);
                        }    */
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Voimme kopioida koodin ylt‰
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter vk = new StreamWriter(ttk.FileName))
                    {
                        vk.WriteLineAsync(rikasTB.Text);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ohjelman sulkeminen
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Text, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if (rikasTB.Text.Length > 0)
            {
                leikkaaToolStripMenuItem.Enabled = true;
                kopioiToolStripMenuItem.Enabled = true;
            }
            else
            {
                leikkaaToolStripMenuItem.Enabled = false;
                kopioiToolStripMenuItem.Enabled = false;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                rikasTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tehnyt Stelios Mavrigiannakis");
        }
    }
}