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
    public partial class usrAddRep : UserControl
    {
        #region - Declarations

        private string sql = string.Empty;
        private DbProcessing db = new DbProcessing();
        private DS_Baker ds_Baker = new DS_Baker();
        private DataTable dt = new DataTable();

        #endregion

        #region - Constructors

        public usrAddRep()
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
            cmbSofer.Focus();
        }

        /// <summary>
        /// Loads combobox with the drivers from database
        /// </summary>
        private void LoadSoferiCmb()
        {
            try
            {
                sql = "SELECT id_sofer, nume_sofer FROM app_soferi ORDER BY nume_sofer";

                db.LoadDataSetBySQL(ds_Baker.app_soferi, sql);

                cmbSofer.DataSource = ds_Baker.app_soferi;
                cmbSofer.DisplayMember = "nume_sofer";
                cmbSofer.ValueMember = "id_sofer";
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "LoadSoferiCmb", ex.Message);
                CommonMessages.ErrorMessage();
            }
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

        /// <summary>
        /// Loads combobox with the number of shifts
        /// </summary>
        private void LoadTuraCmb()
        {
            cmbTura.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        /// <summary>
        /// Loads combobox with the types of delivery
        /// </summary>
        private void LoadTurReturCmb()
        {
            cmbTurRetur.Items.AddRange(new object[] { "Tur", "Retur" });
        }

        /// <summary>
        /// Checks the type selected type of delivery
        /// </summary>
        /// <param name="selection"></param>
        /// <returns>True for selected type of delivery, false for non-selected</returns>
        private bool GetTurRetur(string selection)
        {
            if (cmbTurRetur.SelectedItem.ToString() == selection)
                return true;
            else
                return false;
        }

        #endregion

        #region - Events

        private void usrAddRep_Load(object sender, EventArgs e)
        {
            LoadSoferiCmb();
            LoadMagCmb();
            LoadTuraCmb();
            LoadTurReturCmb();
        }

        private void btnAddProds_Click(object sender, EventArgs e)
        {
            frmProduseDistribuite frm_ProdDist;

            if(dt.Rows.Count == 0)
                frm_ProdDist = new frmProduseDistribuite();
            else
                frm_ProdDist = new frmProduseDistribuite(dt);

            frm_ProdDist.DataAvailable += new EventHandler(frm_ProdDist_DataAvailable);
            
            frm_ProdDist.ShowDialog();
        }

        private void frm_ProdDist_DataAvailable(object sender, EventArgs e)
        {
            frmProduseDistribuite frm_ProdDist = sender as frmProduseDistribuite;
            
            if(frm_ProdDist != null)
                dt = frm_ProdDist.DtCopiedProd;
        }

        private void btnAddRep_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Nu ati introdus nici un produs in raport !", "Eroare Raport !");
                else
                {
                    sql = "INSERT INTO app_livrari (id_sofer, id_mag, tura, tur, retur, data_livrare, suma_incasata)"
                          + "VALUES ("
                          + cmbSofer.SelectedValue.ToString() + ", "
                          + cmbMagazin.SelectedValue.ToString() + ", "
                          + cmbTura.Text + ", "
                          + GetTurRetur("Tur").ToString() + ", "
                          + GetTurRetur("Retur").ToString() + ", to_timestamp('"
                          + dateTimeAddRep.Value.ToString(dateTimeAddRep.CustomFormat) + "', '"
                          + "dd - mm - yyyy hh24:mi'), "
                          + txtSumaIncasata.Text + ")";

                    db.ExecuteSqlCommand(sql);

                    DataTable dt_id_rep = new DataTable();

                    sql = "SELECT id_raport_livrare FROM app_livrari "
                         + "ORDER BY id_raport_livrare DESC LIMIT 1";

                    db.LoadDataSetBySQL(dt_id_rep, sql);                    

                    sql = "INSERT INTO app_livrari_detalii (id_raport_livrare, id_prod, cantitate_livrata) VALUES ";

                    foreach (DataRow dr in dt.Rows)
                        if(int.Parse(dr["cantitate_livrata"].ToString()) > 0)
                            sql = sql + "("
                                + dt_id_rep.Rows[dt_id_rep.Rows.Count - 1]["id_raport_livrare"].ToString() + ", "
                                + dr["id_prod"].ToString() + ", "
                                + dr["cantitate_livrata"].ToString() + "),";

                    sql = sql.Remove(sql.Length - 1);

                    db.ExecuteSqlCommand(sql);

                    sql = "INSERT INTO app_livrari_costuri "
                        + "SELECT * FROM app_livrari_cost "
                        + "WHERE id_raport_livrare = "
                        + dt_id_rep.Rows[dt_id_rep.Rows.Count - 1]["id_raport_livrare"].ToString();

                    db.ExecuteSqlCommand(sql);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "btnAddRep_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }        

        #endregion
    }
}
