using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Variable for Timer in 1/10 of second
        const int SET_TIMER = 3 * 60 * 10;
        int TimerValue = SET_TIMER;
        
        public Form1()
        {
            InitializeComponent();
            initProgram();
        }

        // Init or reset timer on start program or press reset button
        private void initProgram()
        {
            TimerValue = SET_TIMER;
            timer1.Enabled = false;
            timer1.Interval = 100;
            button1.Text = "Start";
            button1.Enabled = true;
            progressBar1.Value = 0;
            label1.Text = ShowTime(TimerValue);
           
        }

        // function convert seconds to formatted string like "2:58" or "0:03"
        private String ShowTime(int t) {
            int m = t / 600;
            int s = t % 600 / 10;
            int ms = t % 10;
            String a = m.ToString("0") + ":" + s.ToString("00") + "_" + ms.ToString("0");
            return a;
        }

        // Start/Stop Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";

            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
            }
        }

        // Reset Button
        private void button2_Click(object sender, EventArgs e)
        {
            initProgram();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimerValue--;

            if (TimerValue <= 0) {
                timer1.Enabled = false;
                progressBar1.Value = 100;
                label1.Text = "0:00_0";
                button1.Enabled = false;
                MessageBox.Show ("Time is over!");
            }

            label1.Text = ShowTime(TimerValue);

            // Convert remaining time into percents
            double a = 100.0 / SET_TIMER * (SET_TIMER - TimerValue);

            progressBar1.Value = (int) a;

        }
    }
}
