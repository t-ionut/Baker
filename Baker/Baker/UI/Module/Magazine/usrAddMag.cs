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
    public partial class usrAddMag : UserControl
    {
        #region - Declarations

        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;

        #endregion

        #region - Constructor

        public usrAddMag()
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
            txtNumeMag.Focus();
        }

        #endregion

        #region - Events

        private void btnAddMag_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "INSERT INTO app_magazine (" +
                        "nume_mag, " +
                        "cui_mag, " +
                        "adr_mag, " +
                        "tel_mag) " +
                        "VALUES ('" +
                        txtNumeMag.Text + "','" +
                        txtCuiMag.Text + "','" +
                        txtAdrMag.Text + "','" +
                        txtTelMag.Text + "')";

                db.ExecuteSqlCommand(sql);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddMag_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion


    }
}
