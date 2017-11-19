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
        System.Windows.Forms.DataVisualization.Charting.SeriesChartType series_chart_type;
        System.Windows.Forms.DataVisualization.Charting.Series graph1, graph2;

        // Ex.2 Var.8
        public Form1()
        {
            InitializeComponent();

            // Clear component and fill it
            chart1.Series.Clear();

            // Assign handle to graphics
            graph1 = chart1.Series.Add("Series 1");
            graph2 = chart1.Series.Add("Series 2");

            comboBox1.Items.Add("Sin(x)");
            comboBox1.Items.Add("Cos(x)");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("Sin(2x)");
            comboBox2.Items.Add("-Sin(2x)");
            comboBox2.Items.Add("Sin(3x)");
            comboBox2.Items.Add("-Sin(3x)");
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.Add("Spline");
            comboBox3.Items.Add("Point");
            comboBox3.Items.Add("StepLine");
            comboBox3.Items.Add("Line");
            comboBox3.Items.Add("Column");
            comboBox3.SelectedIndex = 0;
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select chart line type
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Spline":
                    series_chart_type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    break;
                case "Point":
                    series_chart_type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case "StepLine":
                    series_chart_type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                    break;
                case "Line":
                    series_chart_type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case "Column":
                    series_chart_type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }
            graph1.ChartType = series_chart_type;
            graph2.ChartType = series_chart_type;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double y = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Sin(x)":
                    graph1.Name = comboBox1.SelectedItem.ToString();
                    chart1.Series[graph1.Name].Points.Clear();
                    for (double x = 0; x <= 2*Math.PI; x+=.1)
                    {
                        y = Math.Sin(x);
                        chart1.Series[graph1.Name].Points.AddXY(x, y);
                    }
                    break;

                case "Cos(x)":
                    graph1.Name = comboBox1.SelectedItem.ToString();
                    chart1.Series[graph1.Name].Points.Clear();
                    for (double x = 0; x <= 2 * Math.PI; x += .1)
                    {
                        y = Math.Cos(x);
                        chart1.Series[graph1.Name].Points.AddXY(x, y);
                    }
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double y = 0;
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Sin(2x)":
                    graph2.Name = comboBox2.SelectedItem.ToString();
                    chart1.Series[graph2.Name].Points.Clear();
                    for (double x = 0; x <= 2 * Math.PI; x += .1)
                    {
                        y = Math.Sin(2*x);
                        chart1.Series[graph2.Name].Points.AddXY(x, y);
                    }
                    break;
                case "-Sin(2x)":
                    graph2.Name = comboBox2.SelectedItem.ToString();
                    chart1.Series[graph2.Name].Points.Clear();
                    for (double x = 0; x <= 2 * Math.PI; x += .1)
                    {
                        y = -Math.Sin(2*x);
                        chart1.Series[graph2.Name].Points.AddXY(x, y);
                    }
                    break;
                case "Sin(3x)":
                    graph2.Name = comboBox2.SelectedItem.ToString();
                    chart1.Series[graph2.Name].Points.Clear();
                    for (double x = 0; x <= 2 * Math.PI; x += .1)
                    {
                        y = Math.Sin(3*x);
                        chart1.Series[graph2.Name].Points.AddXY(x, y);
                    }
                    break;
                case "-Sin(3x)":
                    graph2.Name = comboBox2.SelectedItem.ToString();
                    chart1.Series[graph2.Name].Points.Clear();
                    for (double x = 0; x <= 2 * Math.PI; x += .1)
                    {
                        y = -Math.Sin(3*x);
                        chart1.Series[graph2.Name].Points.AddXY(x, y);
                    }
                    break;
            }
        }

    }
}
