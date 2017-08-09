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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            int c = Convert.ToInt32(textBox2.Text);
            int c1 = Convert.ToInt32(textBox3.Text);
            dateTimePicker2.MaxDate = DateTime.Now;
            DateTime dt1 = dateTimePicker2.Value;
            DateTime dt2 = DateTime.Now;
            int d = (dt2.Year - dt1.Year) * 365;
            string s = "Вы " + f;
            listBox1.Items.Add(s);
            s = Convert.ToString(d);
            s = "Вы прожили " + s + " дней";
            listBox1.Items.Add(s);
            s = Convert.ToString(c1);
            s = "Вы хотите учиться еще " + s + " дней";
            listBox1.Items.Add(s);
            dt1 = dt1.AddDays(c1);
            s = "Вы станете очень умным " + dt1;
            listBox1.Items.Add(s);
            s = Convert.ToString(dt1.DayOfWeek);
            s = "Это будет в " + s;
            listBox1.Items.Add(s);
            listBox1.Items.Add("Названия месяцев на английском, сорри...");
        }
    }
}
