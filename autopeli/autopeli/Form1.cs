using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autopeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameoverLB.Visible=false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ajastin_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            viholinen(gamespeed);
            gameover();
            koliko(gamespeed);
            kolikotcollection();
        }

        int collectedkoliko = 0;

        Random r = new Random();
        int x, y;
        void viholinen(int speed)
        {
            if (viholinen1.Top >=500)
            {
                x = r.Next(0, 200);
                viholinen1.Location = new Point(x, 0);
            }
            else
            {
                viholinen1.Top += speed;
            }
            if (viholinen2.Top >=500)
            {
                x = r.Next(0, 400);
                viholinen2.Location = new Point(x, 0);
            }
            else
            {
                viholinen2.Top += speed;
            }
            if (viholinen3.Top >=500)
            {
                x = r.Next(200, 350);
                viholinen3.Location = new Point(x, 0);
            }
            else
            {
                viholinen3.Top += speed;
            }

        }

        void koliko(int speed)
        {
            if (koliko1.Top >=500)
            {
                x = r.Next(0, 200);
                koliko1.Location = new Point(x, 0);
            }
            else
            {
                koliko1.Top += speed;
            }
            if (koliko2.Top >=500)
            {
                x = r.Next(0, 200);
                koliko2.Location = new Point(x, 0);
            }
            else
            {
                koliko2.Top += speed;
            }
            if (koliko3.Top >=500)
            {
                x = r.Next(50, 300);
                koliko3.Location = new Point(x, 0);
            }
            else
            {
                koliko3.Top += speed;
            }
            if (koliko4.Top >=500)
            {
                x = r.Next(0, 200);
                koliko4.Location = new Point(x, 0);
            }
            else
            {
                koliko4.Top += speed;
            }

        }
    void gameover()
        {
            if(oranssiauto.Bounds.IntersectsWith(viholinen1.Bounds))
                {
                ajastin.Enabled=false;
                gameoverLB.Visible=true;
                }
            if (oranssiauto.Bounds.IntersectsWith(viholinen2.Bounds))
            {
                ajastin.Enabled=false;
                gameoverLB.Visible=true;
            }
            if (oranssiauto.Bounds.IntersectsWith(viholinen3.Bounds))
            {
                ajastin.Enabled=false;
                gameoverLB.Visible=true;
            }
        }
        void moveline(int speed)
        {
            if (viiva1.Top >= 500)
            {
                viiva1.Top = 0;
            }
            else
            {
                viiva1.Top += speed;
            }

            if (viiva2.Top >= 500)
            {
                viiva2.Top = 0;
            }
            else
            {
                viiva2.Top += speed;
            }

            if (viiva3.Top >= 500)
            {
                viiva3.Top = 0;
            }
            else
            {
                viiva3.Top += speed;
            }

            if (viiva4.Top >= 500)
            {
                viiva4.Top = 0;
            }
            else
            {
                viiva4.Top += speed;
            }

        }

        void kolikotcollection()
        {
             if (oranssiauto.Bounds.IntersectsWith(koliko1.Bounds))
                {
                    collectedkoliko++;
                    kolikotLB.Text = "Kolikot=" + collectedkoliko.ToString();
                    koliko1.Location = new Point(x, 0);
                }
            if (oranssiauto.Bounds.IntersectsWith(koliko2.Bounds))
                {
                    collectedkoliko++;
                    kolikotLB.Text = "Kolikot=" + collectedkoliko.ToString();
                    koliko2.Location = new Point(x, 0);
                }
            if (oranssiauto.Bounds.IntersectsWith(koliko3.Bounds))
                {
                    collectedkoliko++;
                    kolikotLB.Text = "Kolikot=" + collectedkoliko.ToString();
                    koliko3.Location = new Point(x, 0);
                }
            if (oranssiauto.Bounds.IntersectsWith(koliko4.Bounds))
                {
                    collectedkoliko++;
                    kolikotLB.Text = "Kolikot=" + collectedkoliko.ToString();
                    koliko4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                {
                    if(oranssiauto.Left>0)
                    oranssiauto.Left += -8;
                }
            if (e.KeyCode == Keys.Right)
                {
                    if(oranssiauto.Right<380)
                    oranssiauto.Left += 8;
                }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }    
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed < 0)
                {
                    gamespeed++;
                }
            }
        }
    }
}
