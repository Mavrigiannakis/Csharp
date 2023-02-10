namespace Ajastin
{
    public partial class CountDownForm : Form
    {
        private int kokonaisaika; // variable to store the total time 

        public CountDownForm()
        {
            InitializeComponent();
        }

        private void CountDownForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // Disable the Stop button initially

            // Add items (0 to 59) to both combo boxes
            for (int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 0; // Set the selected index of minutes combo box to 0
            SekunnitCB.SelectedIndex = 10; // Set the selected index of seconds combo box to 10
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // Disable the Start button
            StopBT.Enabled = true; // Enable the Stop button
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString()); // Get the selected minutes
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // Get the selected seconds
            kokonaisaika = (minuutit * 60) + sekunnit; // Calculate the total time
            AjastinTM.Enabled = true; // Enable the Timer
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; // Enable the Start button
            StopBT.Enabled= false; // Disable the Stop button
            kokonaisaika = 0; // Reset the total time
            AjastinTM.Enabled = false; // Disable the Timer
            aikaLB.Text = "00:00"; // Reset the display label
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0) // Check if the total time is greater than 0
            {
                kokonaisaika--; // Decrement the total time
                int minuutit = kokonaisaika / 60; // Calculate the minutes
                int sekuntit = kokonaisaika - (minuutit * 60); // Calculate the seconds
                aikaLB.Text = minuutit + ":" + sekuntit; // Display the minutes and seconds
            }
            else
            {
                AjastinTM.Stop(); // Stop the Timer
                MessageBox.Show("Aikasi loppui!"); // Show a message box saying the time is up
            }
        }
    }
}