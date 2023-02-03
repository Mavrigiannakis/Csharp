namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(heightTextBox.Text);
            double weight = double.Parse(weightTextBox.Text);

            double bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                bmiLabel.ForeColor = System.Drawing.Color.LightCyan;
                bmiLabel.Text = "Alipaino (BMI: " + bmi.ToString("0.00") + ")";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiLabel.ForeColor = System.Drawing.Color.Green;
                bmiLabel.Text = "Normaalipaino  (BMI: " + bmi.ToString("0.00") + ")";
            }
            else if (bmi >= 25 && bmi <= 39.9)
            {
                bmiLabel.ForeColor = System.Drawing.Color.DarkOrange;
                bmiLabel.Text = "Ylipaino (BMI: " + bmi.ToString("0.00") + ")";
            }
            else
            {
                bmiLabel.ForeColor = System.Drawing.Color.Red;
                bmiLabel.Text = "Merkittävä lihavuus (BMI: " + bmi.ToString("0.00") + ")";
            }
        }
    }
}