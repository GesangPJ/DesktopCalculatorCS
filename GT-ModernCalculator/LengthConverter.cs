using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_ModernCalculator
{
    public partial class LengthConverter : Form
    {
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

    }
}
