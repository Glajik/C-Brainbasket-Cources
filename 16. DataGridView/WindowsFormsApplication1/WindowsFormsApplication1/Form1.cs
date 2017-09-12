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
        double rate_eur = 0.83575;
        double rate_gbp = 0.75295;
        double rate_chf = 0.95985;
        double rate_pln = 3.55883;
        double rate_uah = 26.0730;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(4);
            dataGridView1.Rows[0].Cells[0].Value = "EUR - Euro";
            dataGridView1.Rows[0].Cells[1].Value = rate_eur.ToString();

            dataGridView1.Rows[1].Cells[0].Value = "GBP - British Pound";
            dataGridView1.Rows[1].Cells[1].Value = rate_gbp.ToString();

            dataGridView1.Rows[2].Cells[0].Value = "CHF - Swiss Franc";
            dataGridView1.Rows[2].Cells[1].Value = rate_chf.ToString();

            dataGridView1.Rows[3].Cells[0].Value = "PLN - Polish Zloty";
            dataGridView1.Rows[3].Cells[1].Value = rate_pln.ToString();

            dataGridView1.Rows[4].Cells[0].Value = "UAH - Ukrainian Hrivna";
            dataGridView1.Rows[4].Cells[1].Value = rate_uah.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox1.Text);
            double commission = Convert.ToDouble(textBox2.Text);
            double fee, result;

            fee = amount * rate_eur / 100 * commission;
            result = amount * rate_eur - fee;
            dataGridView1.Rows[0].Cells[2].Value = amount.ToString();
            dataGridView1.Rows[0].Cells[3].Value = fee.ToString();
            dataGridView1.Rows[0].Cells[4].Value = result.ToString();

            fee = amount * rate_gbp / 100 * commission;
            result = amount * rate_gbp - fee;
            dataGridView1.Rows[1].Cells[2].Value = amount.ToString();
            dataGridView1.Rows[1].Cells[3].Value = fee.ToString();
            dataGridView1.Rows[1].Cells[4].Value = result.ToString();

            fee = amount * rate_chf / 100 * commission;
            result = amount * rate_chf - fee;
            dataGridView1.Rows[2].Cells[2].Value = amount.ToString();
            dataGridView1.Rows[2].Cells[3].Value = fee.ToString();
            dataGridView1.Rows[2].Cells[4].Value = result.ToString();

            fee = amount * rate_pln / 100 * commission;
            result = amount * rate_pln - fee;
            dataGridView1.Rows[3].Cells[2].Value = amount.ToString();
            dataGridView1.Rows[3].Cells[3].Value = fee.ToString();
            dataGridView1.Rows[3].Cells[4].Value = result.ToString();

            fee = amount * rate_uah / 100 * commission;
            result = amount * rate_uah - fee;
            dataGridView1.Rows[4].Cells[2].Value = amount.ToString();
            dataGridView1.Rows[4].Cells[3].Value = fee.ToString();
            dataGridView1.Rows[4].Cells[4].Value = result.ToString();
        }
    }
}
