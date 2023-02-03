namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTemperature.Text))
            {
                double temperature = double.Parse(textBoxTemperature.Text);

                if (radioButtonFahrenheit.Checked)
                {
                    double celsius = (temperature - 32) * 5 / 9;
                    labelResult.Text = celsius.ToString() + "°C";
                }
                else if (radioButtonCelsius.Checked)
                {
                    double fahrenheit = temperature * 9 / 5 + 32;
                    labelResult.Text = fahrenheit.ToString() + "°F";
                }
            }
        }

        private void radioButtonCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}