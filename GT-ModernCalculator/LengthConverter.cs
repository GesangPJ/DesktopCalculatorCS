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
        // Sidebar animation need
        private bool isAnimating = false;
        private int targetWidth;
        private int currentWidth;
        private System.Windows.Forms.Timer animationTimer;

        // Form Switching need
        private bool switchingToAnotherForm = false;

        // Form Closing need
        private bool isClosing = false;

        public LengthConverter()
        {
            InitializeComponent();
            TxtMillimeter.Text = "0";
            TxtCentimeter.Text = "0";
            TxtFoot.Text = "0";
            TxtInch.Text = "0";
            TxtMeter.Text = "0";
            TxtKilometer.Text = "0";
            TxtMile.Text = "0";
            // Show product version
            LabelVersionL.Text = "V." + ProductVersion;

            // Sidebar animation init
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Adjust this value to control the animation speed
            animationTimer.Tick += AnimationTimer_Tick;

        }
        // Length Converter Function
        private bool updatingTextProgrammatically = false;

        private void LengthTextChanged(object sender, EventArgs e)
        {
            TextBox sourceTextBox = (TextBox)sender;

            if (!updatingTextProgrammatically && !string.IsNullOrEmpty(sourceTextBox.Text))
            {
                double inputValue;
                if (double.TryParse(sourceTextBox.Text, out inputValue))
                {
                    // Determine the source unit based on the textbox name
                    string sourceUnit = sourceTextBox.Name.Substring(3); // Remove "Txt" prefix from textbox name

                    // Convert the input value to all other units and update the respective textboxes
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox targetTextBox && targetTextBox.Name.StartsWith("Txt") && targetTextBox != sourceTextBox)
                        {
                            string targetUnit = targetTextBox.Name.Substring(3);

                            // Perform conversion from source unit to target unit
                            double convertedValue = ConvertLength(inputValue, sourceUnit, targetUnit);

                            // Update the target textbox with the converted value
                            updatingTextProgrammatically = true;
                            targetTextBox.Text = convertedValue.ToString();
                            updatingTextProgrammatically = false;
                        }
                    }
                }
                else
                {
                    // Handle invalid input
                    ClearConversionResult();
                }
            }
            else if (!updatingTextProgrammatically)
            {
                ClearConversionResult();
            }
        }

        private void ClearConversionResult()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox targetTextBox && targetTextBox.Name.StartsWith("Txt"))
                {
                    targetTextBox.Text = "0";
                }
            }
        }


        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            double result = 0;

            switch (fromUnit.ToLower())
            {
                case "millimeter":
                    result = value / 1000;
                    break;
                case "centimeter":
                    result = value / 100;
                    break;
                case "inch":
                    result = value * 0.0254;
                    break;
                case "meter":
                    result = value;
                    break;
                case "foot":
                    result = value * 0.3048;
                    break;
                case "kilometer":
                    result = value * 1000;
                    break;
                case "mile":
                    result = value * 1609.34;
                    break;
                default:
                    break;
            }

            switch (toUnit.ToLower())
            {
                case "millimeter":
                    result *= 1000;
                    break;
                case "centimeter":
                    result *= 100;
                    break;
                case "inch":
                    result /= 0.0254;
                    break;
                case "meter":
                    break;
                case "foot":
                    result /= 0.3048;
                    break;
                case "kilometer":
                    result /= 1000;
                    break;
                case "mile":
                    result /= 1609.34;
                    break;
                default:
                    break;
            }

            return result;
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
        // Sidebar function
        private void BtnMenuL_Click(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                if (panelSidebarL.Visible)
                {
                    // Close the sidebar
                    StartSidebarAnimation(false);
                }
                else
                {
                    // Open the sidebar
                    panelSidebarL.Visible = true;
                    SubscribeButtonClickEvents();
                    SubscribeFormClickEvent();
                    StartSidebarAnimation(true);
                }
            }
        }
        private void SubscribeButtonClickEvents()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != BtnMenuL)
                    control.Click += CloseSidebarOnClick;
            }
        }
        private void SubscribeFormClickEvent()
        {
            this.Click += CloseSidebarOnClick;
        }
        private void CloseSidebarOnClick(object? sender, EventArgs e)
        {
            panelSidebarL.Visible = false;
            UnsubscribeEvents();
        }
        private void UnsubscribeEvents()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != BtnMenuL)
                    control.Click -= CloseSidebarOnClick;
            }
            this.Click -= CloseSidebarOnClick;
        }
        // Sidebar Animation
        private void StartSidebarAnimation(bool open)
        {
            targetWidth = open ? 60 : 0; // Adjust the target width based on open or close
            animationTimer.Tag = open;
            animationTimer.Start();
            isAnimating = true; // Set the flag to true when the animation starts
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            bool open = (bool)animationTimer.Tag;

            if (open && panelSidebarL.Width < targetWidth)
            {
                panelSidebarL.Width += 5; // Adjust the increment value for a smooth animation
            }
            else if (!open && panelSidebarL.Width > targetWidth)
            {
                panelSidebarL.Width -= 5; // Adjust the increment value for a smooth animation
            }
            else
            {
                animationTimer.Stop(); // Stop the timer when the animation is complete
                UnsubscribeEvents(); // Unsubscribe the events

                if (!open)
                {
                    panelSidebarL.Visible = false; // Hide the sidebar after closing animation
                }

                isAnimating = false; // Reset the flag when the animation is complete
            }
        }
        // Exit confirmation
        private void LengthConverter_FormClosing(object sender, FormClosingEventArgs e)
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
