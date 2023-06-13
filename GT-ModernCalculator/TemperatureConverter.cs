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
        private bool switchingToAnotherForm = false;
        private bool isClosing = false;
        //Sidebar animation
        private bool isAnimating = false;
        private int targetWidth;
        private System.Windows.Forms.Timer animationTimer;

        public TemperatureConverter()
        {
            InitializeComponent();
            //Display App Product Version
            LabelVersionT.Text = "V." + ProductVersion + "-Release";
            //Sidebar Animation render
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Adjust this value to control the animation speed
            animationTimer.Tick += AnimationTimer_Tick;
        }
        // Form Switching Function
        private void LengthConverter_Click(object sender, EventArgs e)
        {
            // LengthConverter Form
            LengthConverter lengthConverterForm = new LengthConverter();

            this.Hide();

            lengthConverterForm.ShowDialog();

            this.Close();
        }
        private void BtnStandard_Click(object sender, EventArgs e)
        {
            //switchingToAnotherForm = true;
            // Create an instance of the ScienceCalculator form
            StandardCalculator standardCalculatorForm = new StandardCalculator();

            this.Hide();

            // Show the ScienceCalculator form
            standardCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();

        }
        private void BtnScience_Click(object sender, EventArgs e)
        {
            switchingToAnotherForm = true;
            // Create a new instance of the ScienceCalculator form
            ScienceCalculator scienceCalculatorForm = new ScienceCalculator();

            // Hide the current form
            this.Hide();

            // Show the ScienceCalculator form
            scienceCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();
        }

        //Temperature Converter Function
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


        // Sidebar Function
        private void BtnTMenu_Click(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                if (panelSidebarT.Visible)
                {
                    // Close the sidebar
                    StartSidebarAnimation(false);
                }
                else
                {
                    // Open the sidebar
                    panelSidebarT.Visible = true;
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
                if (control is Button && control != BtnTMenu)
                    control.Click += CloseSidebarOnClick;
            }
        }
        private void SubscribeFormClickEvent()
        {
            this.Click += CloseSidebarOnClick;
        }
        private void CloseSidebarOnClick(object? sender, EventArgs e)
        {
            panelSidebarT.Visible = false;
            UnsubscribeEvents();
        }
        private void UnsubscribeEvents()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != BtnTMenu)
                    control.Click -= CloseSidebarOnClick;
            }
            this.Click -= CloseSidebarOnClick;
        }
        //Sidebar Animation
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

            if (open && panelSidebarT.Width < targetWidth)
            {
                panelSidebarT.Width += 5; // Adjust the increment value for a smooth animation
            }
            else if (!open && panelSidebarT.Width > targetWidth)
            {
                panelSidebarT.Width -= 5; // Adjust the increment value for a smooth animation
            }
            else
            {
                animationTimer.Stop(); // Stop the timer when the animation is complete
                UnsubscribeEvents(); // Unsubscribe the events

                if (!open)
                {
                    panelSidebarT.Visible = false; // Hide the sidebar after closing animation
                }

                isAnimating = false; // Reset the flag when the animation is complete
            }
        }
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
