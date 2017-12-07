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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void planesrefBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planesrefBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Planesref' table. You can move, or remove it, as needed.
            this.planesrefTableAdapter.Fill(this.customersDataSet.Planesref);

        }

    }
}
