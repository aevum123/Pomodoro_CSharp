using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_CSharp
{
    public partial class Pomodoro : Form
    {
        string soundToPlay = "C:\\Windows\\Media\\chimes.wav"; // this would set default to Chimes.wav

        //Global variable for number of seconds that will be converted into mm:ss
        double seconds = 0;
        const int SECS_PER_MINUTE = 60;

        public Pomodoro()
        {
            InitializeComponent();
        } 

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            TimeSpan span = TimeSpan.FromSeconds(seconds);
            lblTimeLeft.Text = span.ToString(@"mm\:ss");
            if (seconds == 0)
            {
                countdownTimer.Stop();
                using (var soundPlayer = new SoundPlayer(soundToPlay))
                {
                    soundPlayer.Play();
                }
                MessageBox.Show("You're done!");

            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            seconds = 5 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            seconds = 10 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            seconds = 15 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            seconds = 20 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            seconds = 25 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            seconds = 30 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            seconds = 35 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            seconds = 40 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            seconds = 45 * SECS_PER_MINUTE;
            countdownTimer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundToPlay = "C:\\Windows\\Media\\chimes.wav";
        }
    }
}
