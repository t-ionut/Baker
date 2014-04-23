using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baker.Data;

namespace Baker
{
    public partial class frmProduseDistribuite : Form
    {
        #region - Declarations

        private string sql = string.Empty;
        private DbProcessing db = new DbProcessing();
        private DataTable dtProd = new DataTable();
        private DataTable dtCopiedProd;
        private DataView dvProd;

        public DataTable DtCopiedProd
        {
            get { return dtCopiedProd; }
        }
                
        #endregion

        #region - Constructor

        public frmProduseDistribuite()
        {
            InitializeComponent();            
        }

        public frmProduseDistribuite(DataTable dt)
        {
            InitializeComponent();
            dtProd = dt;
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Method to signal parent form or other form for data available
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;

            if (eh != null)
                eh(this, e);
        }

        /// <summary>
        /// Checks if the typed quantity is valid
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        private bool IsDigitValue(string quantity)
        {
            if (quantity.All(Char.IsDigit))
                return true;

            return false;
        }

        /// <summary>
        /// Loads the products datagridview from database
        /// </summary>
        private void LoadGridProd()
        {
            try
            {
                sql = "SELECT id_prod," + 
                             "nume_prod, " + 
                             "gramaj_prod, " + 
                             "tip_prod, " +
                             "pret_prod_ctva " +                             
                      "FROM app_prod_info " +
                      "WHERE comercializat = TRUE";
                db.LoadDataSetBySQL(dtProd, sql);

                DataColumn cantitate = new DataColumn();
                cantitate.DataType = typeof(string);
                cantitate.DefaultValue = "0";
                cantitate.ColumnName = "cantitate_livrata";
                dtProd.Columns.Add(cantitate);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "LoadGridProd", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        /// <summary>
        /// Sets up the datagridview columns
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="dv"></param>
        /// <returns></returns>
        private DataGridView SetUpGrid(DataGridView dg, DataView dv)
        {
            dg.Rows.Clear();
            dg.DataSource = dv;

            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.ReadOnly = true;
            }

            dg.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).ReadOnly = false;

            return dg;
        }

        #endregion

        #region - Events

        public event EventHandler DataAvailable;

        private void frmProduseDistribuite_Load(object sender, EventArgs e)
        {
            if(dtProd.Rows.Count == 0)
                LoadGridProd();
            
            dvProd = new DataView(dtProd);

            dgProds = SetUpGrid(dgProds, dvProd);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dvProd.RowFilter = string.Empty;
        }

        private void btnPaine_Click(object sender, EventArgs e)
        {
            dvProd.RowFilter = "tip_prod = 'Paine'";
        }

        private void btnCozonac_Click(object sender, EventArgs e)
        {
            dvProd.RowFilter = "tip_prod = 'Cozonac'";
        }

        private void btnPatiserie_Click(object sender, EventArgs e)
        {
            dvProd.RowFilter = "tip_prod = 'Patiserie'";
        }

        private void btnDiverse_Click(object sender, EventArgs e)
        {
            dvProd.RowFilter = "tip_prod = 'Diverse'";
        }        

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                dtCopiedProd = dtProd.Clone();
                dtCopiedProd.Rows.Clear();

                foreach (DataRow dr in dtProd.Rows)
                {
                    string quantity = dr["cantitate_livrata"].ToString();

                    if (IsDigitValue(quantity))
                        if (int.Parse(quantity) >= 0)
                            dtCopiedProd.ImportRow(dr);
                        else
                        {
                            CommonMessages.InvalidValueOn(dr["nume_prod"].ToString());
                            dtCopiedProd.Rows.Clear();

                            return;
                        }
                    else
                    {
                        CommonMessages.InvalidValueOn(dr["nume_prod"].ToString());
                        dtCopiedProd.Rows.Clear();

                        return;
                    }

                }

                dtCopiedProd.AcceptChanges();

                OnDataAvailable(null);

                CommonMessages.SuccessMessage("Adaugare cu succes !");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddProd_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        //private void dgProds_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Tab)
        //    {
        //        int currentRowIndex = dgProds.Rows.IndexOf(dgProds.CurrentRow);
        //        dgProds.Rows[currentRowIndex + 1].Cells["cantitate_livrata"].Selected = true;
        //    }
        //}
    }
}