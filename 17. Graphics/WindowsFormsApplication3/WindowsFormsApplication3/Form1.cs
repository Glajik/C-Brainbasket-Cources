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
        struct sPanelsConfig
        {
            public const int Reset = 0;
            public const int ArcGroup = 1;
            public const int RectangleGroup = 2;
            public const int LineGroup = 3;
            public const int FillLineGroup = 4;
            public const int FillRectangleGroup = 5;
            public const int FillArcGroup = 6;
            public int lastMode;
        }
        sPanelsConfig panels_config;


        Graphics hwnd;
        Pen pen = new Pen(Color.Black);
        System.Drawing.SolidBrush solidbrush = new SolidBrush(Color.Black);
       
        System.Drawing.Drawing2D.HatchBrush hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.ZigZag, Color.Black, Color.White);
        Color hatchbrush_forecolor = Color.Black;
       

        public Form1()
        {
            InitializeComponent();

            // Take handle for draw
            hwnd = Graphics.FromHwnd(this.panel1.Handle);

            // set up panels
            PreparePanels(sPanelsConfig.Reset);


            // fill List View with new random values
            FillListView();

            // Fill Comboboxes

            // FIGURES

            string[] items = new string[] { "DrawArc", "DrawBezier", "DrawBeziers", "DrawCurve", "DrawClosedCurve", 
                                             "DrawEllipse", "DrawLine", "DrawLines", "DrawPie", "DrawRectangle", 
                                             "FillClosedCurve", "FillRectange", "FillEllipse", "FillPie", "FillPolygon"
            };

            foreach (string item in items) 
                   comboBox1.Items.Add(item);

            
            // STORKE STYLES

            items = new string[] { "Dash", "DashDot", "DashDotDot", "Dot", "Solid" };
            
            foreach (string item in items)
                comboBox2.Items.Add(item);

            // set default
            comboBox2.SelectedItem = "Solid";

            // FILL STYLES

            items = new string[] { "Solid Brush",
            "BackwardDiagonal", 
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

            // set default
            comboBox4.SelectedItem = "ZigZag";
           
        }

        // Check user selection and make appropriate pen. Function is an event handler.
        private void Pen_change(object sender, EventArgs e)
        {
            pen.Width = (float)numericUpDown1.Value;

            switch (comboBox2.SelectedItem.ToString())
            {
                case "Dash": pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; break;
                case "DashDot": pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break;
                case "DashDotDot": pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break;
                case "Dot": pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; break;
                case "Solid": pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; break;
            }

            Render(sender, e);
        }

        // Check user selection and make appropriate hatchbrush. Function is an event handler.
        private void Fill_change(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "Solid Brush": hatchbrush = null; break;
                case "BackwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "Cross": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross, hatchbrush_forecolor, Color.White); break;
                case "DarkDownwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "DarkHorizontal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DarkHorizontal, hatchbrush_forecolor, Color.White); break;
                case "DarkUpwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "DarkVertical": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DarkVertical, hatchbrush_forecolor, Color.White); break;
                case "DashedDownwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DashedDownwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "DashedHorizontal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DashedHorizontal, hatchbrush_forecolor, Color.White); break;
                case "DashedUpwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DashedUpwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "DashedVertical": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DashedVertical, hatchbrush_forecolor, Color.White); break;
                case "DiagonalBrick": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DiagonalBrick, hatchbrush_forecolor, Color.White); break;
                case "DiagonalCross": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DiagonalCross, hatchbrush_forecolor, Color.White); break;
                case "Divot": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Divot, hatchbrush_forecolor, Color.White); break;
                case "DottedDiamond": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DottedDiamond, hatchbrush_forecolor, Color.White); break;
                case "DottedGrid": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DottedGrid, hatchbrush_forecolor, Color.White); break;
                case "ForwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "Horizontal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Horizontal, hatchbrush_forecolor, Color.White); break;
                case "HorizontalBrick": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.HorizontalBrick, hatchbrush_forecolor, Color.White); break;
                case "LargeCheckerBoard": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LargeCheckerBoard, hatchbrush_forecolor, Color.White); break;
                case "LargeConfetti": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LargeConfetti, hatchbrush_forecolor, Color.White); break;
                case "LargeGrid": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LargeGrid, hatchbrush_forecolor, Color.White); break;
                case "LightDownwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "LightHorizontal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightHorizontal, hatchbrush_forecolor, Color.White); break;
                case "LightUpwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "LightVertical": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightVertical, hatchbrush_forecolor, Color.White); break;
                case "Max": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Max, hatchbrush_forecolor, Color.White); break;
                case "Min": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Min, hatchbrush_forecolor, Color.White); break;
                case "NarrowHorizontal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.NarrowHorizontal, hatchbrush_forecolor, Color.White); break;
                case "NarrowVertical": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.NarrowVertical, hatchbrush_forecolor, Color.White); break;
                case "OutlinedDiamond": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond, hatchbrush_forecolor, Color.White); break;
                case "Percent05": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent05, hatchbrush_forecolor, Color.White); break;
                case "Percent10": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent10, hatchbrush_forecolor, Color.White); break;
                case "Percent20": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent20, hatchbrush_forecolor, Color.White); break;
                case "Percent25": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent25, hatchbrush_forecolor, Color.White); break;
                case "Percent30": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent30, hatchbrush_forecolor, Color.White); break;
                case "Percent40": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent40, hatchbrush_forecolor, Color.White); break;
                case "Percent50": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent50, hatchbrush_forecolor, Color.White); break;
                case "Percent60": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent60, hatchbrush_forecolor, Color.White); break;
                case "Percent70": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent70, hatchbrush_forecolor, Color.White); break;
                case "Percent75": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent75, hatchbrush_forecolor, Color.White); break;
                case "Percent80": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent80, hatchbrush_forecolor, Color.White); break;
                case "Percent90": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent90, hatchbrush_forecolor, Color.White); break;
                case "Plaid": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Plaid, hatchbrush_forecolor, Color.White); break;
                case "Shingle": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Shingle, hatchbrush_forecolor, Color.White); break;
                case "SmallCheckerBoard": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SmallCheckerBoard, hatchbrush_forecolor, Color.White); break;
                case "SmallConfetti": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SmallConfetti, hatchbrush_forecolor, Color.White); break;
                case "SmallGrid": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SmallGrid, hatchbrush_forecolor, Color.White); break;
                case "SolidDiamond": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SolidDiamond, hatchbrush_forecolor, Color.White); break;
                case "Sphere": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Sphere, hatchbrush_forecolor, Color.White); break;
                case "Trellis": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Trellis, hatchbrush_forecolor, Color.White); break;
                case "Vertical": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Vertical, hatchbrush_forecolor, Color.White); break;
                case "Wave": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Wave, hatchbrush_forecolor, Color.White); break;
                case "Weave": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Weave, hatchbrush_forecolor, Color.White); break;
                case "WideDownwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.WideDownwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "WideUpwardDiagonal": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.WideUpwardDiagonal, hatchbrush_forecolor, Color.White); break;
                case "ZigZag": hatchbrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.ZigZag, hatchbrush_forecolor, Color.White); break;
            }
            
            Render(sender, e);
        }

        // Set pen color.
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(Form1.ActiveForm);
            pen.Color = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
            Render(sender, e);
        }

        // Set Brushes color
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(Form1.ActiveForm);
            hatchbrush_forecolor = colorDialog1.Color;
            solidbrush = new SolidBrush(colorDialog1.Color);
            button2.BackColor = colorDialog1.Color;
            Fill_change(sender, e);
        }

        // Fill List with random points
        private void button3_Click(object sender, EventArgs e)
        {
            FillListView();
            Render(sender, e);
        }

        // Fill List with random points
        private void FillListView()
        {
            ListViewItem item;
            ListViewItem.ListViewSubItem subitem_x, subitem_y;
            System.Random rnd = new System.Random();
            int x, y, count;
            
            listView1.Items.Clear();

            count = 10;//rnd.Next(5, 10);

            for (int i = 0; i < count; i++)
            {
                x = rnd.Next(25, panel1.Width - 25);
                y = rnd.Next(25, panel1.Height - 25);
                item = listView1.Items.Add(Convert.ToString(listView1.Items.Count + 1));
                subitem_x = item.SubItems.Add(x.ToString());
                subitem_y = item.SubItems.Add(y.ToString());
            }
        }

        // Check user selection and call the appropriate function for drawing
        private void Render(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                hwnd.Clear(Color.White);

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "DrawArc": MyDrawArc(); break;
                    case "DrawBezier": MyDrawBezier(); break;
                    case "DrawBeziers": MyDrawBeziers(); break;
                    case "DrawClosedCurve": MyDrawClosedCurve(); break;
                    case "DrawCurve": MyDrawCurve();  break;
                    case "DrawEllipse": MyDrawEllipse(); break;
                    case "DrawLine": MyDrawLine(); break;
                    case "DrawLines": MyDrawLines(); break;
                    case "DrawPie": MyDrawPie(); break;
                    case "DrawRectangle": MyDrawRectangle(); break;

                    case "FillClosedCurve": MyDrawFillClosedCurve();  break;
                    case "FillRectange": MyDrawFillRectangle(); break;
                    case "FillEllipse": MyDrawFillEllipse(); break;
                    case "FillPie": MyFillPie(); break;
                    case "FillPolygon": MyFillPolygon(); break;

                    default: break;
                }
            }
        }

        // Prepare the settings panel for shapes
        public void PreparePanels(int config)
        {
            switch (config)
            {
                case sPanelsConfig.Reset:
                    {
                        addparam_panel.Enabled = false;
                        pen_panel.Enabled = false;
                        fill_panel.Enabled = false;
                        point_panel.Enabled = false;
                        listView1.Visible = false;

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

                        label_param1.Text = "param1:";
                        label_param1.Enabled = true;
                        numericUpDown_param1.Enabled = true;
                        numericUpDown_param1.Minimum = 0;
                        numericUpDown_param1.Maximum = 360;
                        numericUpDown_param1.Value = 0;

                        label_param2.Text = "param2:";
                        label_param2.Enabled = true;
                        numericUpDown_param2.Enabled = true;
                        numericUpDown_param2.Minimum = 0;
                        numericUpDown_param2.Maximum = 360;
                        numericUpDown_param2.Value = 270;

                        break;
                    }
                case sPanelsConfig.ArcGroup:
                    {
                        pen_panel.Enabled = true;
                        fill_panel.Enabled = false;
                        point_panel.Enabled = false;
                        listView1.Visible = false;
                        addparam_panel.Enabled = true;

                        // Configure additional parameter window
                        if (config != panels_config.lastMode)
                        {
                            panels_config.lastMode = config;
                            label_param1.Text = "start angle:";
                            label_param1.Enabled = true;
                            label_param2.Text = "sweep angle:";
                            label_param2.Enabled = true;
                            numericUpDown_param2.Enabled = true;
                        }
                        break;
                    }
                case sPanelsConfig.RectangleGroup:
                    {
                        pen_panel.Enabled = true;
                        fill_panel.Enabled = false;
                        point_panel.Enabled = false;
                        listView1.Visible = false;
                        addparam_panel.Enabled = true;

                        // Configure additional parameter window
                        if (config != panels_config.lastMode)
                        {
                            panels_config.lastMode = config;
                            label_param1.Text = "param1:";
                            label_param1.Enabled = false;
                            numericUpDown_param1.Enabled = false;
                            label_param2.Text = "param2:";
                            label_param2.Enabled = false;
                            numericUpDown_param2.Enabled = false;
                        }
                        break;
                    }
                case sPanelsConfig.LineGroup:
                    {
                        pen_panel.Enabled = true;
                        fill_panel.Enabled = false;
                        point_panel.Enabled = true;
                        listView1.Visible = true;
                        addparam_panel.Enabled = false;
                        break;
                    }
                case sPanelsConfig.FillLineGroup:
                    {
                        pen_panel.Enabled = false;
                        fill_panel.Enabled = true;
                        point_panel.Enabled = true;
                        listView1.Visible = true;
                        addparam_panel.Enabled = false;
                        break;
                    }
                case sPanelsConfig.FillRectangleGroup:
                    {
                        pen_panel.Enabled = false;
                        fill_panel.Enabled = true;
                        point_panel.Enabled = false;
                        listView1.Visible = false;
                        addparam_panel.Enabled = true;
                        
                        // Configure additional parameter window
                        if (config != panels_config.lastMode)
                        {
                            panels_config.lastMode = config;
                            label_param1.Text = "param1:";
                            label_param1.Enabled = false;
                            numericUpDown_param1.Enabled = false;
                            label_param2.Text = "param2:";
                            label_param2.Enabled = false;
                            numericUpDown_param2.Enabled = false;
                        }
                        break;
                    }
                case sPanelsConfig.FillArcGroup:
                    {
                        pen_panel.Enabled = false;
                        fill_panel.Enabled = true;
                        point_panel.Enabled = false;
                        listView1.Visible = false;
                        addparam_panel.Enabled = true;

                        // Configure additional parameter window
                        if (config != panels_config.lastMode)
                        {
                            panels_config.lastMode = config;
                            label_param1.Text = "start angle:";
                            label_param1.Enabled = true;
                            numericUpDown_param1.Enabled = true;
                            label_param2.Text = "sweep angle:";
                            label_param2.Enabled = true;
                            numericUpDown_param2.Enabled = true;
                        }
                        break;
                    }
            }
        }

        // DRAW FIGURES

        private void MyDrawArc()
        {
            // Prepare the settings panel for shapes
            PreparePanels(sPanelsConfig.ArcGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            float startAngle = (float)numericUpDown_param1.Value;
            float sweepAngle = (float)numericUpDown_param2.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            
            // Draw figure

            hwnd.DrawArc(pen, rect, startAngle, sweepAngle);

        }

        private void MyDrawBezier()
        {
            PreparePanels(sPanelsConfig.LineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawBezier(pen, points[0], points[1], points[2], points[3]);
        }

        // not work yet
        private void MyDrawBeziers()
        {
            PreparePanels(sPanelsConfig.LineGroup);
            
            /* WORKED CODE
            System.Random rnd = new System.Random();

            int count = 40;

            Point[] points = new Point[count];

            for (int i = 0; i < count; i++)
            {
                points[i].X = rnd.Next(25, panel1.Width - 25);
                points[i].Y = rnd.Next(25, panel1.Height - 25);
            }            
            */
            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawBeziers(pen, points);
        }

        private void MyDrawCurve()
        {
            PreparePanels(sPanelsConfig.LineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawCurve(pen, points);
        }

        private void MyDrawClosedCurve()
        {
            PreparePanels(sPanelsConfig.LineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawClosedCurve(pen, points);
        }

        private void MyDrawEllipse()
        {
            PreparePanels(sPanelsConfig.RectangleGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure

            hwnd.DrawEllipse(pen, rect);
        }

        private void MyDrawLine()
        {
            PreparePanels(sPanelsConfig.LineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawLine(pen, points[0], points[1]);
        }

        private void MyDrawLines()
        {
            PreparePanels(sPanelsConfig.LineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            hwnd.DrawLines(pen, points);
        }

        private void MyDrawPie()
        {
            // Prepare the settings panel for shapes
            PreparePanels(sPanelsConfig.ArcGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            float startAngle = (float)numericUpDown_param1.Value;
            float sweepAngle = (float)numericUpDown_param2.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure

            hwnd.DrawPie(pen, rect, startAngle, sweepAngle);
        }

        private void MyDrawRectangle()
        {
            PreparePanels(sPanelsConfig.RectangleGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure

            hwnd.DrawRectangle(pen, rect);
        }

        private void MyDrawFillClosedCurve()
        {
            PreparePanels(sPanelsConfig.FillLineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {   
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            if (hatchbrush != null) hwnd.FillClosedCurve(hatchbrush, points);
            else hwnd.FillClosedCurve(solidbrush, points);

        }

        private void MyDrawFillRectangle()
        {
            PreparePanels(sPanelsConfig.FillRectangleGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure
            if (hatchbrush != null) hwnd.FillRectangle(hatchbrush, rect);
            else hwnd.FillRectangle(solidbrush, rect);
        }

        private void MyDrawFillEllipse()
        {
            PreparePanels(sPanelsConfig.FillRectangleGroup);
            
            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure
            if (hatchbrush != null) hwnd.FillEllipse(hatchbrush, rect);
            else hwnd.FillEllipse(solidbrush, rect);
        }

        private void MyFillPie()
        {
            PreparePanels(sPanelsConfig.FillArcGroup);

            //setup initial parameter
            int x = (int)numericUpDown_x.Value;
            int y = (int)numericUpDown_y.Value;
            int width = (int)numericUpDown_width.Value;
            int height = (int)numericUpDown_height.Value;
            float startAngle = (float)numericUpDown_param1.Value;
            float sweepAngle = (float)numericUpDown_param2.Value;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            // Draw figure
            if (hatchbrush != null) hwnd.FillPie(hatchbrush, rect, startAngle, sweepAngle);
            else hwnd.FillPie(solidbrush, rect, startAngle, sweepAngle);
        }

        private void MyFillPolygon()
        {
            PreparePanels(sPanelsConfig.FillLineGroup);

            int count = listView1.Items.Count;

            Point[] points = new Point[count];

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                points[i].X = Convert.ToInt32(item.SubItems[1].Text);
                points[i].Y = Convert.ToInt32(item.SubItems[2].Text);
                i++;
            }

            // Draw figure
            if (hatchbrush != null) hwnd.FillPolygon(hatchbrush, points);
            else hwnd.FillPolygon(solidbrush, points);

        }
    }
}
