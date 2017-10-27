using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Graphics hwnd;
        Pen pen = new Pen(Color.Black);
        Brush brush = Brushes.Blue;
        

        public Form1()
        {
            InitializeComponent();

            // Take handle for draw
            hwnd = Graphics.FromHwnd(this.panel1.Handle);

            addparam_panel.Enabled = false;

            // Fill Comboboxes

            // FIGURES
            /*
            hwnd.DrawArc;
            hwnd.DrawBezier;
            hwnd.DrawClosedCurve;
            hwnd.DrawCurve;
            hwnd.DrawEllipse;
            hwnd.DrawLine;
            hwnd.DrawPie;
            hwnd.DrawRectangle;
            hwnd.DrawString;

            hwnd.FillClosedCurve;
            hwnd.FillRectange;
            hwnd.FillEllipse;
            hwnd.FillPie;
            hwnd.FillPolygon;
            */
            string[] items = new string[] { "DrawArc", "DrawBezier", "DrawCurve", "DrawClosedCurve", 
                                             "DrawEllipse", "DrawLine", "DrawPie", "DrawRectangle", "DrawString",
                                             "FillClosedCurve", "FillRectange", "FillEllipse", "FillPie", "FillPolygon"
            };

            foreach (string item in items) 
                   comboBox1.Items.Add(item);

            
            // STORKE STYLES
            // pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid

            items = new string[] { "Dash", "DashDot", "DashDotDot", "Dot", "Solid" };
            
            foreach (string item in items)
                comboBox2.Items.Add(item);

            // FILL METHODS
            

            // FILL STYLES
            /*
            System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.Cross;
            System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.DarkHorizontal;
            System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            System.Drawing.Drawing2D.HatchStyle.DashedDownwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.DashedHorizontal;
            System.Drawing.Drawing2D.HatchStyle.DashedUpwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.DashedVertical;
            System.Drawing.Drawing2D.HatchStyle.DiagonalBrick;
            System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
            System.Drawing.Drawing2D.HatchStyle.Divot;
            System.Drawing.Drawing2D.HatchStyle.DottedDiamond;
            System.Drawing.Drawing2D.HatchStyle.DottedGrid;
            System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.Horizontal;
            System.Drawing.Drawing2D.HatchStyle.HorizontalBrick;
            System.Drawing.Drawing2D.HatchStyle.LargeCheckerBoard;
            System.Drawing.Drawing2D.HatchStyle.LargeConfetti;
            System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.LightHorizontal;
            System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.LightVertical;
            System.Drawing.Drawing2D.HatchStyle.Max;
            System.Drawing.Drawing2D.HatchStyle.Min;
            System.Drawing.Drawing2D.HatchStyle.NarrowHorizontal;
            System.Drawing.Drawing2D.HatchStyle.NarrowVertical;
            System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            System.Drawing.Drawing2D.HatchStyle.Percent05;
            System.Drawing.Drawing2D.HatchStyle.Percent10;
            System.Drawing.Drawing2D.HatchStyle.Percent20;
            System.Drawing.Drawing2D.HatchStyle.Percent25;
            System.Drawing.Drawing2D.HatchStyle.Percent30;
            System.Drawing.Drawing2D.HatchStyle.Percent40;
            System.Drawing.Drawing2D.HatchStyle.Percent50;
            System.Drawing.Drawing2D.HatchStyle.Percent60;
            System.Drawing.Drawing2D.HatchStyle.Percent70;
            System.Drawing.Drawing2D.HatchStyle.Percent75;
            System.Drawing.Drawing2D.HatchStyle.Percent80;
            System.Drawing.Drawing2D.HatchStyle.Percent90;
            System.Drawing.Drawing2D.HatchStyle.Plaid;
            System.Drawing.Drawing2D.HatchStyle.Shingle;
            System.Drawing.Drawing2D.HatchStyle.SmallCheckerBoard;
            System.Drawing.Drawing2D.HatchStyle.SmallConfetti;
            System.Drawing.Drawing2D.HatchStyle.SmallGrid;
            System.Drawing.Drawing2D.HatchStyle.SolidDiamond;
            System.Drawing.Drawing2D.HatchStyle.Sphere;
            System.Drawing.Drawing2D.HatchStyle.Trellis;
            System.Drawing.Drawing2D.HatchStyle.Vertical;
            System.Drawing.Drawing2D.HatchStyle.Wave;
            System.Drawing.Drawing2D.HatchStyle.Weave;
            System.Drawing.Drawing2D.HatchStyle.WideDownwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.WideUpwardDiagonal;
            System.Drawing.Drawing2D.HatchStyle.ZigZag;
            */

            items = new string[] {"BackwardDiagonal", 
            "Cross", 
            "DarkDownwardDiagonal", 
            "DarkHorizontal", 
            "DarkUpwardDiagonal", 
            "DarkVertical", 
            "DashedDownwardDiagonal", 
            "DashedHorizontal", 
            "DashedUpwardDiagonal", 
            "DashedVertical", 
            "DiagonalBrick", 
            "DiagonalCross", 
            "Divot", 
            "DottedDiamond", 
            "DottedGrid", 
            "ForwardDiagonal", 
            "Horizontal", 
            "HorizontalBrick", 
            "LargeCheckerBoard", 
            "LargeConfetti", 
            "LargeGrid", 
            "LightDownwardDiagonal", 
            "LightHorizontal", 
            "LightUpwardDiagonal", 
            "LightVertical", 
            "Max", 
            "Min", 
            "NarrowHorizontal", 
            "NarrowVertical", 
            "OutlinedDiamond", 
            "Percent05", 
            "Percent10", 
            "Percent20", 
            "Percent25", 
            "Percent30", 
            "Percent40", 
            "Percent50", 
            "Percent60", 
            "Percent70", 
            "Percent75", 
            "Percent80", 
            "Percent90", 
            "Plaid", 
            "Shingle", 
            "SmallCheckerBoard", 
            "SmallConfetti", 
            "SmallGrid", 
            "SolidDiamond", 
            "Sphere", 
            "Trellis", 
            "Vertical", 
            "Wave", 
            "Weave", 
            "WideDownwardDiagonal", 
            "WideUpwardDiagonal", 
            "ZigZag"};

            foreach (string item in items)
                comboBox4.Items.Add(item.ToString());

           
        }


        private void Render(object sender, EventArgs e)
        {
            hwnd.Clear(Color.White);

            switch (comboBox1.SelectedItem.ToString())
            {
                case "DrawArc": MyDrawArc(); break;
                case "DrawBezier": break;
                case "DrawClosedCurve": break;
                case "DrawCurve": break;
                case "DrawEllipse": break;
                case "DrawLine": break;
                case "DrawPie": break;
                case "DrawRectangle": break;
                case "DrawString": break;
                default: break;
            }
        }

        private void MyDrawArc()
        {
            // Configure additional parameter window, and show it
            if (!addparam_panel.Enabled)
            {
                numericUpDown_width.Minimum = 10;
                numericUpDown_width.Maximum = panel1.Width - 3;
                numericUpDown_width.Value = (decimal)panel1.Width / 2;
                
                numericUpDown_height.Minimum = 10;
                numericUpDown_height.Maximum = panel1.Height - 3;
                numericUpDown_height.Value = (decimal)panel1.Height / 2;                
                
                numericUpDown_x.Minimum = 0;
                numericUpDown_x.Maximum = panel1.Width - 10; 
                numericUpDown_x.Value = (decimal)panel1.Width / 4;

                numericUpDown_y.Minimum = 0;
                numericUpDown_y.Maximum = panel1.Height - 10;
                numericUpDown_y.Value = (decimal)panel1.Height / 4;
                

                label_param1.Text = "start angle:";
                numericUpDown_param1.Minimum = 0;
                numericUpDown_param1.Maximum = 360;                
                numericUpDown_param1.Value = 0;


                label_param2.Text = "sweep angle:";
                numericUpDown_param2.Minimum = 0;
                numericUpDown_param2.Maximum = 360;                
                numericUpDown_param2.Value = 270;

                addparam_panel.Enabled = true;
            }

            //setup initial parameter
            pen.Width = (float)numericUpDown1.Value;
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            float startAngle = (float)numericUpDown_param1.Value;
            float sweepAngle = (float)numericUpDown_param2.Value;

            // Draw figure
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            hwnd.DrawArc(pen, rect, startAngle, sweepAngle);

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
