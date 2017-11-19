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
            
            static int resolution = 100;
            static int periods = 2;
            public double[] plotArray = new double[resolution * periods]; // array for old way to store points
            public int last_i = resolution * periods - 1; // it for array

            public System.Drawing.Point[] plotArraySDP = new System.Drawing.Point[resolution * periods]; // object for modern way to do the same


            /* There is calculate and save in arrays dots of selected function.
             * Function is receive size of drawing window and string from ComboBox, 
             * where user select what kind of function he want to see.
             * I think, it better solve in this case to re-use code with initial value and cycle.
             * It more readable. But not optimal perfomance, because every itteration do the switch and a few function calls.
             */ 
            public void Draw(sWindow my_window, string selected_func)
            {
                double amplitude = my_window.height / 4; // height of waves
                double tab_y = (double)my_window.height / 2 + my_window.top; // offset to center of window
                double dx = (double)my_window.width / (resolution * periods); // scale of increment coordinate x
                double arg = 1; // argument of function
                double f = 1; // result of function
                double x = my_window.left; // coordinate x for drawing graphic
                for (int i = 0; i <= last_i; i++)
                {
                    arg = 2 * Math.PI / resolution * i;

                    switch (selected_func)
                    {
                        case "1. Sin (x)": { f = Math.Sin(arg); break; }
                        case "2. Cos (x)": { f = Math.Cos(arg); break; }
                        case "3. Sin (x) + Sin (2x)": { f = Math.Sin(arg) + Math.Sin(2 * arg); break; }
                        case "4. Sin (x) - Sin (2x)": { f = (Math.Sin(arg) - Math.Sin(2 * arg)); break; }
                        case "5. Sin (x) + Cos (2x)": { f = (Math.Sin(arg) + Math.Cos(2 * arg)); break; }
                        case "6. Sin (x) - Cos (2x)": { f = (Math.Sin(arg) - Math.Cos(2 * arg)); break; }
                        case "7. Sin (x) * Exp (x)": { f = (Math.Sin(arg) * Math.Exp(arg)); amplitude = 0.01;  break; }
                        case "8. Cos (x) * Exp (x)": { f = (Math.Cos(arg) * Math.Exp(arg)); amplitude = 0.01;  break; }
                        case "9. Sin (x) * Exp (-x)": { f = (Math.Sin(arg) * Math.Exp(-arg)); amplitude = my_window.height*1.25; break; }
                        case "10.  Cos (x) * Exp (-x)": { f = (Math.Cos(arg) * Math.Exp(-arg)); amplitude = my_window.height/2; break; }
                    }

                    // classic array - old way                    
                    plotArray[i] = amplitude * f + tab_y;

                    // object - new way
                    plotArraySDP[i].X = (int)x;
                    plotArraySDP[i].Y = (int)(amplitude * f + tab_y);

                    x += dx;
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

            
            cPlotFunction.sWindow my_window; // var for struct that is contain coordinates of drawing field 
            my_window.left = lefttab;
            my_window.top = uptab;
            my_window.width = this.Width - lefttab - righttab;
            my_window.height = this.Height - uptab - downtab;
            

            // Draw selected function in ComboBox
            PlotFunction.Draw(my_window, comboBox1.SelectedItem.ToString());


            // render graphic in old way. You can uncomment and see that is the same
            //Classic_Render(x0, x1, PlotFunction);

            // render graphic to new way   
             hwnd.DrawLines(pen_plotter, PlotFunction.plotArraySDP);

        }

        // render graphic of selected function
        private void Classic_Render(Pen pen_plotter, float x0, float x1, cPlotFunction PlotFunction)
        {
            double x_last = x0;
            double y_last = PlotFunction.plotArray[0];
            double dx = (x1 - x0) / (100 * 2);
            double x = x_last;

            foreach (double y in PlotFunction.plotArray)
            {
                // pass the first itteration, because we want get coords only for start point now
                if (x != x_last) hwnd.DrawLine(pen_plotter, (int)x_last, (int)y_last, (int)x, (int)y);
                y_last = y;
                x_last = x;
                x += dx;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
