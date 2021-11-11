using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerLessonDemo
{
    public partial class Form1 : Form
    {
        int countValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            countValue++;
            counterLabel.Text = $"{countValue}";
            
            if(colorLabel.BackColor == Color.Green)
            {
                colorLabel.BackColor = Color.Red;
            }
            else if(colorLabel.BackColor == Color.Red)
            {
                colorLabel.BackColor = Color.Orange;
            }
            else
            {
                colorLabel.BackColor = Color.Green;
            }
        }
    }
}
