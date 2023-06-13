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
    public partial class TimerForm : Form
    {
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

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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
                }
            };

            timer.Start();
        }


    }
}
