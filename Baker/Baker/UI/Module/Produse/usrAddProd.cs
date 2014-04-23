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
    public partial class usrAddProd : UserControl
    {
        #region - Declarations

        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;
        private DS_Baker ds_Baker = new DS_Baker();

        #endregion

        #region - Constructor

        public usrAddProd()
        {
            InitializeComponent();
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Loads combobox with the types of products from database
        /// </summary>
        private void LoadTipProdCmb()
        {
            try
            {
                sql = "SELECT * FROM app_tip_prod";
                db.LoadDataSetBySQL(ds_Baker.app_tip_prod, sql);
                cmbTipProd.DataSource = ds_Baker.app_tip_prod;

                cmbTipProd.DisplayMember = "nume_tip_prod";
                cmbTipProd.ValueMember = "id_tip_prod";
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "LoadTipProdCmb", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        /// <summary>
        /// Sends focus on first field in user control
        /// </summary>
        public void FocusHere()
        {
            txtNumeProd.Focus();
        }

        #endregion

        #region - Events

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "INSERT INTO app_prod (" +
                            "nume_prod" + ", " +
                            "gramaj_prod" + ", " +
                            "id_tip_prod" + ", " +
                            "comercializat" + ", " +
                            "pret_prod_ftva" + ", " +
                            "tva_prod" + ", " +
                            "pret_prod_ctva" + ") " +
                      "VALUES ('" +
                            txtNumeProd.Text + "', " +
                            txtCantProd.Text + ", " +
                            cmbTipProd.SelectedValue.ToString() + ", " +
                            chkComercializat.Checked + ", " +
                            txtPretFTva.Text + ", " +
                            txtTva.Text + ", " + 
                            "calc_pctva(" + txtPretFTva.Text + ", " + txtTva.Text + ")" +
                            ")";

                db.ExecuteSqlCommand(sql);

                CommonMessages.SuccessMessage("Produsul " + txtNumeProd.Text + " a fost adaugat");
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddProd_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void usrAddProd_Load(object sender, EventArgs e)
        {
            LoadTipProdCmb();
        }

        #endregion
    }
}
