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
    public partial class MainMenu : Form
    {
        // Form Switching Need
        private bool switchingToAnotherForm = false;
        private bool isClosing = false;

        public MainMenu()
        {
            InitializeComponent();
        }
        // Form Switching

        // Length Converter Form
        private void LengthConverter_Click(object sender, EventArgs e)
        {
            // LengthConverter Form
            LengthConverter lengthConverterForm = new LengthConverter();

            this.Hide();

            lengthConverterForm.ShowDialog();

            this.Close();
        }

        // Standard Calculator Form
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

        // Science Calculator Form
        private void BtnScience_Click(object sender, EventArgs e)
        {

            ScienceCalculator scienceCalculatorForm = new ScienceCalculator();

            // Hide the current form
            this.Hide();

            // Show the ScienceCalculator form
            scienceCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();
        }

        //Temperature Converter Form
        private void BtnTemperature_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            this.Hide();

            temperatureConverter.ShowDialog();

            this.Close();
        }

        // Timer Form

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm();

            this.Hide();

            timerForm.ShowDialog();

            this.Close();
        }

        // Exit Function

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
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
