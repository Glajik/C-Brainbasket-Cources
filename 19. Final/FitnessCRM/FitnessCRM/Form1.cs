using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitnessCRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            // this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }


        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        // Timeout for waiting input
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (toolStripTextBox1.Text.Length != 13)
            {
                MessageBox.Show("Warning - must be 13 symbols in the card");
                return;
            }

            // search card in database

            try
            {
                // realize filter by string - number in plastic card
                label1.Text = "";
                this.customersTableAdapter.FillByCard(this.customersDataSet.Customers, toolStripTextBox1.Text);
                foreach (var value in this.customersDataSet.Customers.Rows[0].ItemArray)
                {
                    label1.Text += value + "\n";
                }

                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error. " + err.Message);
            }
        }


    }
}
