using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;


namespace TimerLessonDemo
{
    public partial class Form1 : Form
    {
        int countValue = 0;
        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            countValue++;
            counterLabel.Text = $"{countValue}";

            /// change color once a second while the timer ticks at normal speed
            if (countValue % 4 == 0)
            {
                if (colorLabel.BackColor == Color.Green)
                {
                    colorLabel.BackColor = Color.Red;
                }
                else if (colorLabel.BackColor == Color.Red)
                {
                    colorLabel.BackColor = Color.Orange;
                }
                else
                {
                    colorLabel.BackColor = Color.Green;
                }
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // pause button timer
            if(countTimer.Enabled == false)
            {
                countTimer.Enabled = true;
                startButton.Text = "Stop";

                
                myWatch.Start();
                stopwatchLabel.Text = myWatch.Elapsed + "";
            }
            else
            {
                countTimer.Enabled = false;
                startButton.Text = "Start";
                myWatch.Stop();
            }
        }
    }
}
