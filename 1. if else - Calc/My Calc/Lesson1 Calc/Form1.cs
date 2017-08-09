using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lesson1_Calc
{
    public partial class Form1 : Form
    {

        double result = 0.0;
        double num = 0.0;
        bool action = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            //Power
            reset_button();
            button_power.Enabled = false; //
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(num, 2);
            textBox1.Text = result.ToString();
        }


        private void button_reset_Click(object sender, EventArgs e)
        {
            //Reset
            textBox1.Text = "0";
            reset_button(); 
            action = true;
            result = 0;

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "0";
            else
            {
                textBox1.Text = "0";
                action = false;
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "1";
            else
            {
                textBox1.Text = "1";
                action = false;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "2";
            else
            {
                textBox1.Text = "2";
                action = false;
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "3";
            else
            {
                textBox1.Text = "3";
                action = false;
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "4";
            else
            {
                textBox1.Text = "4";
                action = false;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "5";
            else
            {
                textBox1.Text = "5";
                action = false;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "6";
            else
            {
                textBox1.Text = "6";
                action = false;
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "7";
            else
            {
                textBox1.Text = "7";
                action = false;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "8";
            else
            {
                textBox1.Text = "8";
                action = false;
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (!action) textBox1.Text += "9";
            else
            {
                textBox1.Text = "9";
                action = false;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            // Plus
            reset_button();
            button_plus.Enabled = false; //
            num = Convert.ToDouble(textBox1.Text);
            action = true;            
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (button_point.Enabled)
            {
                if (!action) textBox1.Text += ",";
                else
                {
                    textBox1.Text = "0,";
                    action = false;
                }
                button_point.Enabled = false;
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            // Equals
            if (!action)
            {
                if (!button_plus.Enabled) result = num + Convert.ToDouble(textBox1.Text);
                if (!button_minus.Enabled) result = num - Convert.ToDouble(textBox1.Text);
                if (!button_multiply.Enabled) result = num * Convert.ToDouble(textBox1.Text);
                if (!button_divide.Enabled) result = num / Convert.ToDouble(textBox1.Text);
                if (!button_powerxy.Enabled) result = Math.Pow(num, Convert.ToDouble(textBox1.Text));
                if (!button_log.Enabled) result = Math.Log(Convert.ToDouble(textBox1.Text)) / Math.Log(num);
                // логарифм с произвольным основанием = Math.Log(number) / Math.Log(log_base)
                reset_button();
                action = false;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            //Minus
            reset_button();
            button_minus.Enabled = false; //
            action = true;
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            //Multiply
            reset_button();
            button_multiply.Enabled = false; //
            action = true;
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            //Divide
            reset_button(); 
            button_divide.Enabled = false; //
            action = true;
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button_sqr_Click(object sender, EventArgs e)
        {
            //Square
            reset_button(); 
            button_sqr.Enabled = false; //
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(num);
            textBox1.Text = result.ToString();
        }

        private void button_sinx_Click(object sender, EventArgs e)
        {
            //Sin
            reset_button();
            button_sinx.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Sin(num);
            textBox1.Text = result.ToString();
        }

        private void reset_button()
        {
            button_plus.Enabled = true;
            button_minus.Enabled = true;
            button_multiply.Enabled = true;
            button_divide.Enabled = true;
            button_point.Enabled = true;
            button_power.Enabled = true;
            button_sqr.Enabled = true;
            button_sinx.Enabled = true;
            button_cosx.Enabled = true;
            button_tgx.Enabled = true;
            button_powerxy.Enabled = true;
            button_pi.Enabled = true;
            button_ln.Enabled = true;
            button_arcsin.Enabled = true;
            button_arccos.Enabled = true;
            button_arctg.Enabled = true;
            button_chunk.Enabled = true;
            button_e.Enabled = true;
            button_log.Enabled = true;
        }

        private void button_cosx_Click(object sender, EventArgs e)
        {
            reset_button();
            button_cosx.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Cos (num);
            textBox1.Text = result.ToString();
        }

        private void button_tgx_Click(object sender, EventArgs e)
        {
            reset_button();
            button_tgx.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Tan(num);
            textBox1.Text = result.ToString();
        }

        private void button_arcsin_Click(object sender, EventArgs e)
        {
            reset_button();
            button_arcsin.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Asin(num);
            textBox1.Text = result.ToString();
        }

        private void button_arccos_Click(object sender, EventArgs e)
        {
            reset_button();
            button_arccos.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Acos(num);
            textBox1.Text = result.ToString();
        }

        private void button_arctg_Click(object sender, EventArgs e)
        {
            reset_button();
            button_arctg.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Atan(num);
            textBox1.Text = result.ToString();
        }

        private void button_powerxy_Click(object sender, EventArgs e)
        {
            reset_button();
            button_powerxy.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);

        }

        private void button_log_Click(object sender, EventArgs e)
        {
            reset_button();
            button_log.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button_chunk_Click(object sender, EventArgs e)
        {
            reset_button();
            button_chunk.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = 1/num;
            textBox1.Text = result.ToString();
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            reset_button();
            button_pi.Enabled = false;
            action = true;
            //num = Convert.ToDouble(textBox1.Text);
            result = Math.PI;
            textBox1.Text = result.ToString();
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            reset_button();
            button_e.Enabled = false;
            action = true;
            //num = Convert.ToDouble(textBox1.Text);
            result = Math.E;
            textBox1.Text = result.ToString();
        }

        private void button_ln_Click(object sender, EventArgs e)
        {
            reset_button();
            button_ln.Enabled = false;
            action = true;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Log(num);
            textBox1.Text = result.ToString();
        }
    }
}
