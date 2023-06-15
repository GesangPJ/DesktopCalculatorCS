using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace GT_ModernCalculator
{
    public partial class TimerForm : Form
    {
        // Audio player
        private WaveOutEvent timerWaveOut;

        //Form Closing need
        private bool isClosing = false;
        public TimerForm()
        {
            InitializeComponent();
            //Show product version

            VersionLabelTM.Text = "V." + ProductVersion;
        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(TxtHour.Text);
            int minutes = int.Parse(TxtMinute.Text);
            int seconds = int.Parse(TxtSecond.Text);

            int totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            Timer timer = new Timer();
            timer.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            timer.Tick += (s, args) =>
            {
                if (totalTimeInSeconds > 0)
                {
                    totalTimeInSeconds--;

                    int remainingHours = totalTimeInSeconds / 3600;
                    int remainingMinutes = (totalTimeInSeconds % 3600) / 60;
                    int remainingSeconds = (totalTimeInSeconds % 60);

                    TxtHour.Text = remainingHours.ToString("D2");
                    TxtMinute.Text = remainingMinutes.ToString("D2");
                    TxtSecond.Text = remainingSeconds.ToString("D2");
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Timer completed!");

                    // Play timer sound
                    string soundFilePath = @"C:\Users\Gesang Paudra Jaya\source\repos\GT-ModernCalculator\GT-ModernCalculator\sound\kitchen-timer.wav";

                    timerWaveOut = new WaveOutEvent();
                    AudioFileReader audioFileReader = new AudioFileReader(soundFilePath);
                    timerWaveOut.Init(audioFileReader);
                    timerWaveOut.Play();
                }
            };

            timer.Start();
        }

        private void MessageBox_OK_Click(object sender, EventArgs e)
        {
            // Stop timer sound
            timerWaveOut?.Stop();
        }
        // Switch to Main Menu
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();

            this.Hide();

            mainMenuForm.ShowDialog();

            this.Close();
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
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
