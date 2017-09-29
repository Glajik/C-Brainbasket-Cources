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


        // private class for plot graphic

        private class cPlotFunction
        {
            public struct sWindow // struct for coordinates of space to plot
            {
                public int top;
                public int left;
                public int width;
                public int height;
            }
            
            sWindow window;

            static int max_points_at_period = 100;
            static int count_periods = 2;
            public double[] plotArray = new double[max_points_at_period * count_periods];
            public System.Drawing.Point[] plotArraySDP = new System.Drawing.Point[max_points_at_period * count_periods];
            public int last_i = max_points_at_period * count_periods - 1;



            public void SinX(sWindow window)
            {
                int amplitude = window.height;
                int x0 = window.top;
                int y0 = window.left;
                int x1 = window.width;
                int y1 = window.height;
                float y_center = (this.Height - uptab - downtab) / 2 + uptab;  

                for (int i = 0; i <= last_i; i++)
                {
            
                    plotArray[i] = amplitude * Math.Sin(2 * Math.PI / max_points_at_period * i);
                    plotArraySDP[i].X = i;
                    plotArraySDP[i].Y = (int)(amplitude * Math.Sin(2 * Math.PI / max_points_at_period * i));
                }
            }
        }
        
        // Get handle of main window
        Graphics hwnd;

        public Form1()
        {
            InitializeComponent();
            hwnd = Graphics.FromHwnd(this.Handle);

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            1. Sin (x)
            2. Cos (x)
            3. Sin (x) + Sin (2x)
            4. Sin (x) - Sin (2x)
            5. Sin (x) + Cos (2x)
            6. Sin (x) - Cos (2x)
            7. Sin (x) * Exp (x)
            8. Cos (x) * Exp (x)
            9. Sin (x) * Exp (-x)
            10.  Cos (x) * Exp (-x)             
             */

            // init class cPlotFunction
            cPlotFunction PlotFunction = new cPlotFunction();

            // Clean window
            hwnd.Clear(this.BackColor);

            // Select a color of pen
            Pen pen_border = Pens.Black;
            Pen pen_axis = Pens.Gray;
            Pen pen_plotter = Pens.DarkBlue;

            // Caption
            string s = comboBox1.SelectedItem.ToString();

            int uptab = 25;
            int downtab = 40;
            int lefttab = 10;
            int righttab = 10;
            float amplitude = (this.Height - uptab - downtab) / 2;
            float x0 = lefttab;
            float y0 = uptab;//this.Height / 2;
            float x1 = this.Width - righttab;
            float y1 = this.Height - downtab;
            float y_center = (this.Height - uptab - downtab) / 2 + uptab;

            // Draw info
            hwnd.DrawString(s,
                            new Font("Arial", 14),
                            Brushes.Red,
                            x0,
                            y1 + 5);

            // plot axis
            // hwnd.DrawLine(pen, x0, y0, x1, y0);
            //hwnd.DrawLine(pen, x0, y0 - amplitude, x0, y0 + amplitude);
            
            // Draw Borders
            hwnd.DrawLine(pen_border, x0, y0, x0, y1);
            hwnd.DrawLine(pen_border, x0, y1, x1, y1);
            hwnd.DrawLine(pen_border, x1, y1, x1, y0);
            hwnd.DrawLine(pen_border, x1, y0, x0, y0);

            // Draw Axis
            hwnd.DrawLine(pen_axis, x0, y_center, x1, y_center);
            hwnd.DrawLine(pen_axis, x0, y0, x0, y1);

            int imax = 100, t = 2; // число точек в периоде и число периодов.
            double[] f = new double[imax*t + 10];

            cPlotFunction.sWindow window;
            window.left = lefttab;
            window.top = uptab;
            window.width = this.Width - lefttab - righttab;
            window.height = this.Height - uptab - downtab;

            // Draw selected function
            switch (comboBox1.SelectedItem.ToString()) {
                case "1. Sin (x)": { PlotFunction.SinX(window); break; }
                /*case "2. Cos (x)":
                case "3. Sin (x) + Sin (2x)":
                case "4. Sin (x) - Sin (2x)":
                case "5. Sin (x) + Cos (2x)":
                case "6. Sin (x) - Cos (2x)":
                case "7. Sin (x) * Exp (x)":
                case "8. Cos (x) * Exp (x)":
                case "9. Sin (x) * Exp (-x)":
                case "10.  Cos (x) * Exp (-x)": */
            }

               hwnd.DrawLines(pen_plotter, PlotFunction.plotArraySDP);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
