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
    public partial class usrSearchRep : UserControl
    {
        #region - Declarations

        private DS_Baker ds_Baker = new DS_Baker();
        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;
        private string searchSql = string.Empty;
        Random random = new Random();

        public DS_Baker.app_livrari_prodDataTable Dt
        {
            get { return ds_Baker.app_livrari_prod; }
        }

        #endregion

        #region - Constructor

        public usrSearchRep()
        {
            InitializeComponent();
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Makes the string bring all reports unconditionalized
        /// </summary>
        private string InitializeSearchString(string searchStr)
        {
            searchStr = "SELECT DISTINCT ON (id_raport_livrare)" +
                                " id_raport_livrare" + "," +
                                " nume_sofer" + "," +
                                " nume_mag" + "," +
                                " tura" + "," +
                                " tur" + "," +
                                " retur" + "," +
                                " data_livrare" + "," +
                                " suma_incasata" +
                                " FROM app_livrari_prod" +
                                " ORDER BY id_raport_livrare";

            return searchStr;
        }

        /// <summary>
        /// Loads the drivers combobox from database
        /// </summary>
        private void LoadSoferiCmb()
        {
            try
            {
                sql = "SELECT id_sofer, nume_sofer FROM app_soferi ORDER BY nume_sofer";

                db.LoadDataSetBySQL(ds_Baker.app_soferi, sql);

                foreach (DataRow dr in ds_Baker.app_soferi.Rows)
                    cmbSofer.Items.Add(dr["nume_sofer"].ToString());

                cmbSofer.Items.Add("");

                cmbSofer.DisplayMember = "nume_sofer";
                cmbSofer.ValueMember = "id_sofer";
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "LoadSoferiCmb", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        /// <summary>
        /// Loads the shops combobox from database
        /// </summary>
        private void LoadMagCmb()
        {
            try
            {
                sql = "SELECT id_mag, nume_mag FROM app_magazine ORDER BY nume_mag";

                db.LoadDataSetBySQL(ds_Baker.app_magazine, sql);

                foreach (DataRow dr in ds_Baker.app_magazine.Rows)
                    cmbMagazin.Items.Add(dr["nume_mag"].ToString());

                cmbMagazin.Items.Add("");

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
        /// Method for sending signals to other forms about data
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;

            if (eh != null)
                eh(this, e);
        }

        #endregion

        #region - Events

        public event EventHandler DataAvailable;

        private void usrSearchRep_Load(object sender, EventArgs e)
        {
            LoadSoferiCmb();
            LoadMagCmb();

            searchSql = InitializeSearchString(searchSql);
        }

        

        #endregion

        private void btnResetParams_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimeStart.Value = DateTime.Now;
                dateTimeStop.Value = DateTime.Now;

                cmbSofer.Text = string.Empty;
                cmbMagazin.Text = string.Empty;

                searchSql = InitializeSearchString(searchSql);

                db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, searchSql);

                OnDataAvailable(null);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnResetParams_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateStart = DateTime.Parse(dateTimeStart.Value.ToShortDateString());
                DateTime dateStop = DateTime.Parse(dateTimeStop.Value.ToShortDateString());

                if (dateStart.CompareTo(dateStop) > 0)
                    CommonMessages.ErrorMessage("Data de inceput nu poate fi mai mare decat data finala !");
                else
                    if (dateStart.CompareTo(dateStop) == 0)
                        searchSql = "SELECT * FROM ("
                            + searchSql + ") "
                            + "AS x" + random.Next(1, 999).ToString() + " "
                            + "WHERE data_livrare = '"
                            + dateTimeStart.Value.ToString("yyyy-MM-dd") + "'";
                    else
                        searchSql = "SELECT * FROM ("
                            + searchSql + ") "
                            + "AS x" + random.Next(1, 999).ToString() + " "
                            + "WHERE data_livrare >= '"
                            + dateTimeStart.Value.ToString("yyyy-MM-dd") + "' "
                            + "AND data_livrare <= '"
                            + dateTimeStop.Value.ToString("yyyy-MM-dd") + "'";

                db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, searchSql);

                //if (ds_Baker.app_livrari_prod.Rows.Count == 0)
                //{
                //    MessageBox.Show("Niciun rezultat gasit !");
                //    searchSql = InitializeSearchString(searchSql);                    
                //}

                OnDataAvailable(null);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnSearchByDate_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void cmbSofer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbSofer.Text == string.Empty)
                    searchSql = InitializeSearchString(searchSql);
                else
                {
                    searchSql = "SELECT * FROM ("
                        + searchSql + ") "
                        + "AS x" + random.Next(1, 999).ToString() + " "
                        + "WHERE LOWER(nume_sofer) LIKE LOWER('"
                        + cmbSofer.Text + "%')";
                }

                db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, searchSql);

                //if (ds_Baker.app_livrari_prod.Rows.Count == 0)
                //{
                //    MessageBox.Show("Niciun rezultat gasit !");
                //    searchSql = InitializeSearchString(searchSql);
                //}

                OnDataAvailable(null);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "cmbSofer_KeyUp", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void cmbMagazin_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbMagazin.Text == string.Empty)
                    searchSql = InitializeSearchString(searchSql);
                else
                {
                    searchSql = "SELECT * FROM ("
                        + searchSql + ") "
                        + "AS x" + random.Next(1, 999).ToString() + " "
                        + "WHERE LOWER(nume_mag) LIKE LOWER('"
                        + cmbMagazin.Text + "%')";
                }

                db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, searchSql);

                //if (ds_Baker.app_livrari_prod.Rows.Count == 0)
                //{
                //    MessageBox.Show("Niciun rezultat gasit !");
                //    searchSql = InitializeSearchString(searchSql);
                //}

                OnDataAvailable(null);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "cmbMagazin_KeyUp", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
    }
}
