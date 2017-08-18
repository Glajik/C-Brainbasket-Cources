using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                comboBox1.Items.Add(textBox1.Text);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                comboBox1.Items.Insert(comboBox1.SelectedIndex, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                listBox1.Items.Add(comboBox1.SelectedItem);
        }

    }
}
