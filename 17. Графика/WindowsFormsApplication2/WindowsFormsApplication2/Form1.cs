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
        // Ex.2 Var.8
        public Form1()
        {
            InitializeComponent();
            // Clear component and fill it
            chart1.Series.Clear();

            // Select chart line type
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType chart_type_stepline = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            
            // Assign handle to graphics
            System.Windows.Forms.DataVisualization.Charting.Series graph1, graph2;
            graph1 = chart1.Series.Add("Cos(x)");
            graph1.ChartType = chart_type_stepline;

            graph2 = chart1.Series.Add("-Sin(2x)");
            graph2.ChartType = chart_type_stepline;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0;
            for (int x = 0; x < 20; x++)
            {
                y = Math.Sin(Math.PI / 5 * x);
                chart1.Series["Cos(x)"].Points.AddXY(x, y);

                y = - Math.Sin(Math.PI / 5 * 2 * x);
                chart1.Series["-Sin(2x)"].Points.AddXY(x, y);
            }
        }
    }
}
