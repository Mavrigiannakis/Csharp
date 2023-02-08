namespace NopanHeitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + dice1);

            // check for doubles
            if (dice1 == dice2)
            {
                // generate a new random value for dice2
                dice2 = random.Next(1, 7);

                // check again for doubles
                if (dice1 == dice2)
                {
                    // generate a new random value for dice2
                    dice2 = random.Next(1, 7);
                }
            }
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + dice2);

        }
    }
}