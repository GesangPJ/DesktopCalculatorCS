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
using System.Security.Policy;
using System.Windows.Documents;

namespace GT_ModernCalculator
{
    public partial class TimerForm : Form
    {
        // sound file
        private string soundfile = @"C:\Users\Gesang Paudra Jaya\source\repos\GT-ModernCalculator\GT-ModernCalculator\sound\kitchen-timer.wav";
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
        // Determine if timer is completed
        private bool isTimerCompleted = false;

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
                    // Play timer sound
                    timerWaveOut = new WaveOutEvent();
                    AudioFileReader audioFileReader = new AudioFileReader(soundfile);
                    timerWaveOut.Init(audioFileReader);
                    timerWaveOut.Play();

                    // Show dialog box
                    using (var messageForm = new Form())
                    {
                        messageForm.Text = "Timer Completed!";
                        messageForm.StartPosition = FormStartPosition.CenterParent;
                        messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                        messageForm.MinimizeBox = false;
                        messageForm.MaximizeBox = false;

                        Button okButton = new Button();
                        okButton.Text = "OK";
                        okButton.DialogResult = DialogResult.OK;
                        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                        okButton.Click += (sender, args) =>
                        {
                            // Stop timer sound when the OK button is clicked
                            timerWaveOut.Stop();
                            timerWaveOut.Dispose();
                            messageForm.Close();
                        };
                        int buttonWidth = 75;
                        int buttonHeight = 30;
                        int buttonTop = (messageForm.ClientSize.Height - buttonHeight) / 2;
                        int buttonLeft = (messageForm.ClientSize.Width - buttonWidth) / 2;
                        okButton.Size = new Size(buttonWidth, buttonHeight);
                        okButton.Location = new Point(buttonLeft, buttonTop);

                        messageForm.Controls.Add(okButton);

                        messageForm.ShowDialog();
                    }
                }
            };

            timer.Start();
        }

        private void MessageBox_OK_Click(object sender, EventArgs e)
        {
            // Stop timer sound if the timer has completed
            if (isTimerCompleted)
            {
                timerWaveOut?.Stop();
                isTimerCompleted = false; // Reset the flag for subsequent timer runs
            }
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
