using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker.UI.Module.Produse
{
    public partial class frmProdReport : Form
    {
        public frmProdReport()
        {
            InitializeComponent();
        }

        private void frmProdReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
