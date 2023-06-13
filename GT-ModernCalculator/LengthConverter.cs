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

namespace GT_ModernCalculator
{
    public partial class LengthConverter : Form
    {
        private bool updatingTextProgrammatically = false;
        private bool switchingToAnotherForm = false;
        public LengthConverter()
        {
            InitializeComponent();

        }
        // Length Converter Function
        private void ConvertLength(double length, string fromUnit, TextBox targetTextBox)
        {
            double result = 0;

            switch (fromUnit.ToLower())
            {
                case "milimeter":
                    result = length / 1000;
                    break;
                case "centimeter":
                    result = length / 100;
                    break;
                case "foot":
                    result = length * 0.3048;
                    break;
                case "inch":
                    result = length * 0.0254;
                    break;
                case "meter":
                    result = length;
                    break;
                case "kilometer":
                    result = length * 1000;
                    break;
                case "mile":
                    result = length * 1609.34;
                    break;
                default:
                    targetTextBox.Text = "";
                    return;
            }
        }
        // Clear conversion
        private void ClearConversionResult()
        {
            TxtMilimeter.Text = "0";
            TxtCentimeter.Text = "0";
            TxtFoot.Text = "0";
            TxtInch.Text = "0";
            TxtMeter.Text = "0";
            TxtKilometer.Text = "0";
            TxtMile.Text = "0";
        }
        // Textbox change function
        private void textBox_Changed(object sender, EventArgs e)
        {
            TextBox sourceTextBox = (TextBox)sender;
            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(TxtCentimeter.Text))
            {
                double inputValue;
                if (double.TryParse(sourceTextBox.Text, out inputValue))
                {
                    string sourceunit = sourceTextBox.Name.Substring(3);

                    ConvertLength(inputValue, sourceunit, TxtMilimeter);
                    ConvertLength(inputValue, sourceunit, TxtCentimeter);
                    ConvertLength(inputValue, sourceunit, TxtFoot);
                    ConvertLength(inputValue, sourceunit, TxtInch);
                    ConvertLength(inputValue, sourceunit, TxtMeter);
                    ConvertLength(inputValue, sourceunit, TxtKilometer);
                    ConvertLength(inputValue, sourceunit, TxtMile);
                }
                else
                {
                    ClearConversionResult();
                }
            }
            else if (!updatingTextProgrammatically)
            {
                ClearConversionResult();
            }
        }
        // Form Switching

        private void BtnScience_Click(object sender, EventArgs e)
        {
            // Create a new instance of the ScienceCalculator form
            ScienceCalculator scienceCalculatorForm = new ScienceCalculator();

            // Hide the current form
            this.Hide();

            // Show the ScienceCalculator form
            scienceCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();
        }
        private void BtnTemperature_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            this.Hide();

            temperatureConverter.ShowDialog();

            this.Close();
        }
        private void BtnStandard_Click(object sender, EventArgs e)
        {
            switchingToAnotherForm = true;
            // Create an instance of the ScienceCalculator form
            StandardCalculator standardCalculatorForm = new StandardCalculator();

            this.Hide();

            // Show the ScienceCalculator form
            standardCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();

        }
    }
}
