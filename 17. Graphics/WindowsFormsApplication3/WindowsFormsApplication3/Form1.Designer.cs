namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "10",
            "20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "300",
            "400"}, -1);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "250",
            "60"}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fill_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pen_panel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addparam_panel = new System.Windows.Forms.Panel();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_param2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_param1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.numericUpDown_y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.point_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.fill_panel.SuspendLayout();
            this.pen_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.addparam_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_param2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_param1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            this.point_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.point_panel);
            this.groupBox1.Controls.Add(this.fill_panel);
            this.groupBox1.Controls.Add(this.pen_panel);
            this.groupBox1.Controls.Add(this.addparam_panel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(573, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try pick the type of figure first:";
            // 
            // fill_panel
            // 
            this.fill_panel.Controls.Add(this.button2);
            this.fill_panel.Controls.Add(this.label6);
            this.fill_panel.Controls.Add(this.label3);
            this.fill_panel.Controls.Add(this.comboBox4);
            this.fill_panel.Location = new System.Drawing.Point(3, 190);
            this.fill_panel.Name = "fill_panel";
            this.fill_panel.Size = new System.Drawing.Size(189, 92);
            this.fill_panel.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pick";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Set color of fill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Style of fill:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.Fill_change);
            // 
            // pen_panel
            // 
            this.pen_panel.Controls.Add(this.numericUpDown1);
            this.pen_panel.Controls.Add(this.label7);
            this.pen_panel.Controls.Add(this.label2);
            this.pen_panel.Controls.Add(this.comboBox2);
            this.pen_panel.Controls.Add(this.button1);
            this.pen_panel.Controls.Add(this.label5);
            this.pen_panel.Location = new System.Drawing.Point(3, 70);
            this.pen_panel.Name = "pen_panel";
            this.pen_panel.Size = new System.Drawing.Size(189, 118);
            this.pen_panel.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 55);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Pen_change);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Set width of pen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Style of pen:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Pen_change);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Set color of pen:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem28.StateImageIndex = 0;
            listViewItem29.StateImageIndex = 0;
            listViewItem30.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 99);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "x:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "y:";
            // 
            // addparam_panel
            // 
            this.addparam_panel.Controls.Add(this.numericUpDown_width);
            this.addparam_panel.Controls.Add(this.label8);
            this.addparam_panel.Controls.Add(this.label9);
            this.addparam_panel.Controls.Add(this.numericUpDown_param2);
            this.addparam_panel.Controls.Add(this.numericUpDown_x);
            this.addparam_panel.Controls.Add(this.numericUpDown_param1);
            this.addparam_panel.Controls.Add(this.label10);
            this.addparam_panel.Controls.Add(this.label_param2);
            this.addparam_panel.Controls.Add(this.numericUpDown_y);
            this.addparam_panel.Controls.Add(this.numericUpDown_height);
            this.addparam_panel.Controls.Add(this.label11);
            this.addparam_panel.Controls.Add(this.label_param1);
            this.addparam_panel.Location = new System.Drawing.Point(3, 285);
            this.addparam_panel.Name = "addparam_panel";
            this.addparam_panel.Size = new System.Drawing.Size(189, 131);
            this.addparam_panel.TabIndex = 8;
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(126, 8);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_width.TabIndex = 5;
            this.numericUpDown_width.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_width.ValueChanged += new System.EventHandler(this.Render);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "x:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "y:";
            // 
            // numericUpDown_param2
            // 
            this.numericUpDown_param2.Location = new System.Drawing.Point(126, 99);
            this.numericUpDown_param2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_param2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_param2.Name = "numericUpDown_param2";
            this.numericUpDown_param2.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_param2.TabIndex = 5;
            this.numericUpDown_param2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_param2.ValueChanged += new System.EventHandler(this.Render);
            // 
            // numericUpDown_x
            // 
            this.numericUpDown_x.Location = new System.Drawing.Point(29, 8);
            this.numericUpDown_x.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDown_x.Name = "numericUpDown_x";
            this.numericUpDown_x.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_x.TabIndex = 5;
            this.numericUpDown_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_x.ValueChanged += new System.EventHandler(this.Render);
            // 
            // numericUpDown_param1
            // 
            this.numericUpDown_param1.Location = new System.Drawing.Point(126, 73);
            this.numericUpDown_param1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_param1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_param1.Name = "numericUpDown_param1";
            this.numericUpDown_param1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_param1.TabIndex = 5;
            this.numericUpDown_param1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_param1.ValueChanged += new System.EventHandler(this.Render);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "width:";
            // 
            // label_param2
            // 
            this.label_param2.AutoSize = true;
            this.label_param2.Location = new System.Drawing.Point(14, 101);
            this.label_param2.Name = "label_param2";
            this.label_param2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_param2.Size = new System.Drawing.Size(45, 13);
            this.label_param2.TabIndex = 4;
            this.label_param2.Text = "param2:";
            // 
            // numericUpDown_y
            // 
            this.numericUpDown_y.Location = new System.Drawing.Point(29, 34);
            this.numericUpDown_y.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_y.Name = "numericUpDown_y";
            this.numericUpDown_y.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_y.TabIndex = 5;
            this.numericUpDown_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_y.ValueChanged += new System.EventHandler(this.Render);
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Location = new System.Drawing.Point(126, 36);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_height.TabIndex = 5;
            this.numericUpDown_height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.Render);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "height:";
            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.Location = new System.Drawing.Point(14, 75);
            this.label_param1.Name = "label_param1";
            this.label_param1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_param1.Size = new System.Drawing.Size(45, 13);
            this.label_param1.TabIndex = 4;
            this.label_param1.Text = "param1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type of Figure:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Render);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 555);
            this.panel1.TabIndex = 1;
            // 
            // point_panel
            // 
            this.point_panel.Controls.Add(this.button3);
            this.point_panel.Controls.Add(this.listView1);
            this.point_panel.Location = new System.Drawing.Point(4, 423);
            this.point_panel.Name = "point_panel";
            this.point_panel.Size = new System.Drawing.Size(189, 136);
            this.point_panel.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw Styles Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fill_panel.ResumeLayout(false);
            this.fill_panel.PerformLayout();
            this.pen_panel.ResumeLayout(false);
            this.pen_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.addparam_panel.ResumeLayout(false);
            this.addparam_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_param2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_param1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            this.point_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown_param1;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_x;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_param2;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Panel addparam_panel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel fill_panel;
        private System.Windows.Forms.Panel pen_panel;
        private System.Windows.Forms.Panel point_panel;
        private System.Windows.Forms.Button button3;
    }
}

