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
    public partial class TemperatureConverter : Form
    {
        //Form handle
        private bool isClosing = false;


        public TemperatureConverter()
        {
            InitializeComponent();
            //Display App Product Version
            LabelVersionT.Text = "V." + ProductVersion + "-Release";
        }
        // Form Switching Function
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();

            this.Hide();

            mainMenuForm.ShowDialog();

            this.Close();
        }

        #region TemperatureConverter Function
        //Celcius Calculation
        private bool updatingTextProgrammatically = false;
        private void TxtCelcius_TextChanged(object sender, EventArgs e)
        {
            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(TxtCelcius.Text))
            {
                double celcius;
                if (double.TryParse(TxtCelcius.Text, out celcius))
                {
                    // Convert Celsius to Fahrenheit
                    double fahrenheit = (celcius * 9 / 5) + 32;
                    updatingTextProgrammatically = true;
                    TxtFarenheit.Text = fahrenheit.ToString();
                    updatingTextProgrammatically = false;

                    // Convert Celsius to Kelvin
                    double kelvin = celcius + 273.15;
                    updatingTextProgrammatically = true;
                    TxtKelvin.Text = kelvin.ToString();
                    updatingTextProgrammatically = false;
                }
                else
                {
                    // Handle invalid input
                    TxtFarenheit.Text = "";
                    TxtKelvin.Text = "";
                }
            }
            else if (!updatingTextProgrammatically)
            {
                TxtFarenheit.Text = "";
                TxtKelvin.Text = "";
            }
        }

        private void TxtFarenheit_TextChanged(object sender, EventArgs e)
        {
            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(TxtFarenheit.Text))
            {
                double fahrenheit;
                if (double.TryParse(TxtFarenheit.Text, out fahrenheit))
                {
                    // Convert Fahrenheit to Celsius
                    double celcius = (fahrenheit - 32) * 5 / 9;
                    updatingTextProgrammatically = true;
                    TxtCelcius.Text = celcius.ToString();
                    updatingTextProgrammatically = false;

                    // Convert Celsius to Kelvin
                    double kelvin = (fahrenheit + 459.67) * 5 / 9;
                    updatingTextProgrammatically = true;
                    TxtKelvin.Text = kelvin.ToString();
                    updatingTextProgrammatically = false;
                }
                else
                {
                    // Handle invalid input
                    TxtCelcius.Text = "";
                    TxtKelvin.Text = "";
                }
            }
            else if (!updatingTextProgrammatically)
            {
                TxtCelcius.Text = "";
                TxtKelvin.Text = "";
            }
        }

        private void TxtKelvin_TextChanged(object sender, EventArgs e)
        {
            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(TxtKelvin.Text))
            {
                double kelvin;
                if (double.TryParse(TxtKelvin.Text, out kelvin))
                {
                    // Convert Kelvin to Celsius
                    double celcius = kelvin - 273.15;
                    updatingTextProgrammatically = true;
                    TxtCelcius.Text = celcius.ToString();
                    updatingTextProgrammatically = false;

                    // Convert Celsius to Fahrenheit
                    double fahrenheit = (kelvin * 9 / 5) - 459.67;
                    updatingTextProgrammatically = true;
                    TxtFarenheit.Text = fahrenheit.ToString();
                    updatingTextProgrammatically = false;
                }
                else
                {
                    // Handle invalid input
                    TxtCelcius.Text = "";
                    TxtFarenheit.Text = "";
                }
            }
            else if (!updatingTextProgrammatically)
            {
                TxtCelcius.Text = "";
                TxtFarenheit.Text = "";
            }
        }
        #endregion

        // Exit Confirmation
        private void TemperatureConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing && e.CloseReason == CloseReason.UserClosing)
            {
                isClosing = true;

                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;  // Allow the form to close
                    isClosing = false; // Reset the flag

                    // Exit the application
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;   // Cancel the closing action
                    isClosing = false; // Reset the flag
                }
            }
        }
    }
}
