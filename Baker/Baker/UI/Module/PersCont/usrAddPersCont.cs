using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baker.Data;

namespace Baker
{
    public partial class usrAddPersCont : UserControl
    {
        #region - Declarations

        private DS_Baker ds_Baker = new DS_Baker();
        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;

        #endregion

        #region - Constructor

        public usrAddPersCont()
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
            txtNumePersCont.Focus();
        }

        /// <summary>
        /// Loads combobox with the shops from database
        /// </summary>
        private void LoadMagCmb()
        {
            try
            {
                sql = "SELECT id_mag, nume_mag FROM app_magazine ORDER BY nume_mag";

                db.LoadDataSetBySQL(ds_Baker.app_magazine, sql);

                cmbMagazin.DataSource = ds_Baker.app_magazine;
                cmbMagazin.DisplayMember = "nume_mag";
                cmbMagazin.ValueMember = "id_mag";
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "LoadMagCmb", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Events

        private void usrAddPersCont_Load(object sender, EventArgs e)
        {
            LoadMagCmb();
        }

        private void btnAddPersCont_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "INSERT INTO app_pers_cont (" +
                                    "nume_pers_cont" + ", " +
                                    "tel_pers_cont" + ", " +
                                    "id_mag" + ") " +
                      "VALUES " + "('" +
                                    txtNumePersCont.Text + "', '" +
                                    txtTelPersCont.Text + "', " +
                                    cmbMagazin.SelectedValue.ToString() + ")";

                db.ExecuteSqlCommand(sql);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddPersCont_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion        
    }
}
