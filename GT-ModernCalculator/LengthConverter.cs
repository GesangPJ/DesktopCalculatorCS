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
        private void TxtMilimeter_Changed(object sender, EventArgs e)
        {
            TextBox sourceTextBox = (TextBox)sender;
            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(TxtCentimeter.Text))
            {
                double inputValue;
                if(double.TryParse(sourceTextBox.Text, out inputValue))
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
    }
}
