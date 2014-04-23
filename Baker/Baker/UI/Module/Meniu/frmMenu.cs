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
    public partial class frmMenu : Form
    {
        #region - Declarations

        private string sql = string.Empty;
        private DbProcessing db = new DbProcessing();
        private DS_Baker ds_Baker = new DS_Baker();
        private usrGrid gridUsr = new usrGrid();

        #endregion

        #region - Constructors

        public frmMenu()
        {
            InitializeComponent();            
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Adds wanted user control in left panel
        /// </summary>
        /// <param name="usr"></param>
        private void AddUserControl(UserControl usr)
        {
            splitView.Panel1.Controls.Clear();
            splitView.SplitterDistance = usr.Width;
            splitView.Panel1.Controls.Add(usr);
        }
                
        private void LoadHomeScreen(string firstname, string lastname)
        {
            usrHome usr_Home = new usrHome(firstname, lastname);
            AddUserControl(usr_Home);
        }

        /// <summary>
        /// Loads the specific menu items for current user
        /// </summary>
        /// <param name="isAdmin"></param>
        private void LoadOrbMenuItems(bool isLogged, bool isAdmin)
        {
            rbBaker.OrbDropDown.MenuItems.Clear();

            if (isLogged && isAdmin)
            {
                rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemRegUser);
                rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemDelUser);
                rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemLogOut);
                rbBaker.OrbDropDown.MenuItems.Add(ribbonSeparator1);
                rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemAbout);
                rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemExit);
            }
            else
                if (isLogged)
                {
                    rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemLogOut);
                    rbBaker.OrbDropDown.MenuItems.Add(ribbonSeparator1);
                    rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemAbout);
                    rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemExit);
                }
                else
                {
                    rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemAbout);
                    rbBaker.OrbDropDown.MenuItems.Add(rbOrbItemExit);
                }
        }

        #endregion

        #region - Events

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Globals.IsAdmin = false;
            Globals.IsLogged = false;

            usrLogin usr_Login = new usrLogin();
            LoadOrbMenuItems(Globals.IsLogged, Globals.IsAdmin);
            AddUserControl(usr_Login);

            gridUsr.LogOutSignal += new EventHandler(gridUsr_LogOutSignal);
            usr_Login.LogInSignal += new EventHandler(usr_Login_LogInSignal);

            gridUsr.Visible = false;
            splitView.Panel2.Controls.Clear();
            splitView.Panel2.Controls.Add(gridUsr);
        }

        private void usr_Login_LogInSignal(object sender, EventArgs e)
        {
            LoadOrbMenuItems(Globals.IsLogged, Globals.IsAdmin);
            LoadHomeScreen(Globals.FirstName, Globals.LastName);
        }

        private void gridUsr_LogOutSignal(object sender, EventArgs e)
        {
            frmMenu_Load(this, null);                        
        }

        #region - OrbMenuItems

        private void rbOrbItemRegUser_Click(object sender, EventArgs e)
        {
            dlgRegUser dlgRegUsr = new dlgRegUser();
            dlgRegUsr.ShowDialog();
        }

        private void rbOrbItemDelUser_Click(object sender, EventArgs e)
        {
            dlgDelUser dlgDelUsr = new dlgDelUser();
            dlgDelUsr.ShowDialog();
        }

        private void rbOrbItemLogOut_Click(object sender, EventArgs e)
        {
            frmMenu_Load(this, null);
        }

        private void rbOrbItemAbout_Click(object sender, EventArgs e)
        {
            dlgAbout dlg_About = new dlgAbout();
            dlg_About.ShowDialog();
        }

        private void rbOrbItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region - Produse

        private void rbBtnViewProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddProd usrAdd_Prod = new usrAddProd();
                    AddUserControl(usrAdd_Prod);

                    sql = "SELECT * FROM app_prod_info";
                    db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewProd_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbCatPaine_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    sql = "SELECT * FROM app_prod_info WHERE tip_prod = 'Paine'";
                    db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbCatPaine_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbCatCozonac_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    sql = "SELECT * FROM app_prod_info WHERE tip_prod = 'Cozonac'";
                    db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbCatCozonac_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbCatPatiserie_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    sql = "SELECT * FROM app_prod_info WHERE tip_prod = 'Patiserie'";
                    db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbCatPatiserie_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbCatDiverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    sql = "SELECT * FROM app_prod_info WHERE tip_prod = 'Diverse'";
                    db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbCatDiverse_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbBtnAddProd_Click(object sender, EventArgs e)
        {
            if (Globals.IsLogged)
            {
                bool found = false;

                foreach (Control ctrlFound in splitView.Panel1.Controls)
                    if (ctrlFound.GetType() == typeof(usrAddProd))
                        ((usrAddProd)ctrlFound).FocusHere();
                if (!found)
                {
                    usrAddProd usrAdd_Prod = new usrAddProd();
                    AddUserControl(usrAdd_Prod);
                    usrAdd_Prod.FocusHere();
                }
            }
            else
                CommonMessages.NotLoggedMessage();
        }   

        #endregion

        #region - Magazine

        private void rbBtnViewMag_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddMag usrAdd_Mag = new usrAddMag();
                    AddUserControl(usrAdd_Mag);

                    sql = "SELECT * FROM app_magazine WHERE partener = TRUE";

                    db.LoadDataSetBySQL(ds_Baker.app_magazine, sql);
                    
                    gridUsr.ConnectGridToSource(ds_Baker.app_magazine, ds_Baker.app_magazine.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewMag_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbBtnViewMagDebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddMag usrAdd_Mag = new usrAddMag();
                    AddUserControl(usrAdd_Mag);

                    sql = "SELECT * FROM app_magazine_datorii";

                    db.LoadDataSetBySQL(ds_Baker.app_magazine_datorii, sql);

                    gridUsr.ConnectGridToSource(ds_Baker.app_magazine_datorii, ds_Baker.app_magazine_datorii.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewMagDebt_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
        
        private void rbBtnAddMag_Click(object sender, EventArgs e)
        {
            if (Globals.IsLogged)
            {
                bool found = false;

                foreach (Control ctrlFound in splitView.Panel1.Controls)
                    if (ctrlFound.GetType() == typeof(usrAddMag))
                        ((usrAddMag)ctrlFound).FocusHere();
                if (!found)
                {
                    usrAddMag usrAdd_Mag = new usrAddMag();
                    AddUserControl(usrAdd_Mag);
                    usrAdd_Mag.FocusHere();
                }
            }
            else
                CommonMessages.NotLoggedMessage();
        }

        private void rbBtnProdMag_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region - Persoane de contact

        private void rbBtnViewPersCont_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddPersCont usrAdd_PersCont = new usrAddPersCont();
                    AddUserControl(usrAdd_PersCont);

                    sql = "SELECT * FROM app_pers_cont";

                    db.LoadDataSetBySQL(ds_Baker.app_pers_cont, sql, 30);

                    gridUsr.ConnectGridToSource(ds_Baker.app_pers_cont, ds_Baker.app_pers_cont.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewPersCont_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbBtnAddPersCont_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    bool found = false;

                    foreach (Control ctrlFound in splitView.Panel1.Controls)
                        if (ctrlFound.GetType() == typeof(usrAddMag))
                            ((usrAddPersCont)ctrlFound).FocusHere();
                    if (!found)
                    {
                        usrAddPersCont usrAdd_PersCont = new usrAddPersCont();
                        AddUserControl(usrAdd_PersCont);
                        usrAdd_PersCont.FocusHere();
                    }
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnAddPersCont_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Soferi

        private void rbBtnViewSofer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddSofer usrAdd_Sofer = new usrAddSofer();
                    AddUserControl(usrAdd_Sofer);

                    sql = "SELECT id_sofer, " + 
                                 "nume_sofer, " +
                                 "cnp_sofer, " +
                                 "adr_sofer, " +
                                 "tel_sofer " +
                                 "FROM app_soferi " +
                                 "WHERE angajat = TRUE";

                    db.LoadDataSetBySQL(ds_Baker.app_soferi, sql);

                    gridUsr.ConnectGridToSource(ds_Baker.app_soferi, ds_Baker.app_soferi.TableName, DataGridViewAutoSizeColumnMode.Fill);
                    gridUsr.usrVisibility(true);
                }
                else
                    CommonMessages.NotLoggedMessage();
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewSofer_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbBtnAddSofer_Click(object sender, EventArgs e)
        {
            if (Globals.IsLogged)
            {
                bool found = false;

                foreach (Control ctrlFound in splitView.Panel1.Controls)
                    if (ctrlFound.GetType() == typeof(usrAddSofer))
                        ((usrAddSofer)ctrlFound).FocusHere();
                if (!found)
                {
                    usrAddSofer usrAdd_Sofer = new usrAddSofer();
                    AddUserControl(usrAdd_Sofer);
                    usrAdd_Sofer.FocusHere();
                }
            }
            else
                CommonMessages.NotLoggedMessage();
        }

        #endregion       

        #region - Rapoarte
        
        private void rbBtnViewRep_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.IsLogged)
                {
                    usrAddRep usrAdd_Rep = new usrAddRep();
                    AddUserControl(usrAdd_Rep);

                    sql = "SELECT DISTINCT ON (id_raport_livrare)" +
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
                    db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, sql);

                    gridUsr.ConnectGridToSource(ds_Baker.app_livrari_prod, ds_Baker.app_livrari_prod.TableName, DataGridViewAutoSizeColumnMode.AllCells);
                    gridUsr.usrVisibility(true);
                }

                else
                    CommonMessages.NotLoggedMessage();
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "rbBtnViewRep_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void rbBtnSearchRep_Click(object sender, EventArgs e)
        {
            if (Globals.IsLogged)
            {
                bool found = false;

                foreach (Control ctrlFound in splitView.Panel1.Controls)
                    if (ctrlFound.GetType() == typeof(usrSearchRep))
                    {
                        ((usrSearchRep)ctrlFound).Focus();
                        found = true;
                    }

                if (!found)
                {
                    usrSearchRep usrSearch_Rep = new usrSearchRep();

                    usrSearch_Rep.DataAvailable += new EventHandler(usrSearch_Rep_DataAvailable);

                    AddUserControl(usrSearch_Rep);
                }
            }
            else
                CommonMessages.NotLoggedMessage();
        }

        private void usrSearch_Rep_DataAvailable(object sender, EventArgs e)
        {
            usrSearchRep usrSearch_Rep = sender as usrSearchRep;

            if (usrSearch_Rep != null)
                gridUsr.ConnectGridToSource(usrSearch_Rep.Dt, usrSearch_Rep.Dt.TableName, DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void rbBtnAddRep_Click(object sender, EventArgs e)
        {
            if (Globals.IsLogged)
            {
                usrAddRep usrAdd_Rep = new usrAddRep();
                AddUserControl(usrAdd_Rep);
                usrAdd_Rep.FocusHere();
            }
            else
                CommonMessages.NotLoggedMessage();
        }

        #endregion

        #endregion
    }
}
