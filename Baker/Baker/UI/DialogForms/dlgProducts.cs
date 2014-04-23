using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker
{
    public partial class dlgProducts : Form
    {
        public dlgProducts()
        {
            InitializeComponent();
        }

        public dlgProducts(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;

            foreach (DataGridViewColumn dgcol in dataGridView1.Columns)
                dgcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
