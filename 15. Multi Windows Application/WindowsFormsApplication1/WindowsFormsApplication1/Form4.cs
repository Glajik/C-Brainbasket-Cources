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
    public partial class Form4 : Form
    {
        private readonly IMainForm MainForm; // тут создаем переменную для интерфейса того же типа что и в Form1

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(IMainForm mainform)// Тут по идее мы должны получить "значение" интерфейса
        {
            InitializeComponent();
            this.MainForm = mainform;// Get access to interface in Form1 module
        }
        
        // Set Players name
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1 && textBox2.Text.Length > 1)
            {
                MainForm.SetNameP1(textBox1.Text);
                MainForm.SetNameP2(textBox2.Text);
                Form4.ActiveForm.Close();
            }
            else
                MessageBox.Show("One or two fields are blank. Please enter more than one symbol.");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.Focus();

        }
    }
}
