using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker
{
    public partial class usrAddSofer : UserControl
    {
        #region - Declarations

        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;

        #endregion

        #region - Constructor

        public usrAddSofer()
        {
            InitializeComponent();
        }

        #endregion        

        #region - Methods

        /// <summary>
        /// Sends focus on first field in user control
        /// </summary>
        public void FocusHere()
        {
            txtNumeSofer.Focus();
        }

        #endregion

        #region - Events

        private void btnAddSofer_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "INSERT INTO app_soferi (" +
                                "nume_sofer" + ", " +
                                "cnp_sofer" + ", " +
                                "adr_sofer" + ", " +
                                "tel_sofer" + ") " +
                      "VALUES " + "('" +
                                txtNumeSofer.Text + "','" +
                                txtCnpSofer.Text + "','" +
                                txtAdrSofer.Text + "','" +
                                txtTelSofer.Text + "')";

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddSofer_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion
    }
}
