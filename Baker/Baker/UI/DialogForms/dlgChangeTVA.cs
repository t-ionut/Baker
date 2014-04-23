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
    public partial class dlgChangeTVA : Form
    {
        private string sql;
        private int id;
        private string oldPftva;

        public dlgChangeTVA(int id, string oldPftva, string oldTva)
        {
            InitializeComponent();

            txtOldTva.Text = oldTva;
            this.id = id;
            this.oldPftva = oldPftva;
            txtNewTva.Select();

            sql = "UPDATE app_prod ";
        }

        private void btnChangeTva_Click(object sender, EventArgs e)
        {
            try
            {
                DbProcessing db = new DbProcessing();

                sql = sql + "SET tva_prod = " + txtNewTva.Text + ", " + 
                                "pret_prod_ctva = calc_pctva(" + oldPftva + ", " +
                                 txtNewTva.Text + ") " +
                    "WHERE id_prod = " + id.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnChangeTva_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
    }
}
