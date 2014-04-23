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
    public partial class usrViewSofer : UserControl
    {
        #region - Declarations

        private DbProcessing db = new DbProcessing();
        private DS_Baker ds_Baker = new DS_Baker();
        private string sql = string.Empty;
        private List<ToolStripMenuItem> MenuList = new List<ToolStripMenuItem>();       

        #endregion

        #region - Constructor

        public usrViewSofer()
        {
            InitializeComponent();
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Shows or hides the user control
        /// </summary>
        /// <param name="option"></param>
        public void usrVisibility(bool option)
        {
            if (option)
                this.Show();
            else
                this.Hide();
        }

        /// <summary>
        /// Method for sending logout signal to the parent form
        /// </summary>
        /// <param name="e"></param>
        protected virtual void LogOut(EventArgs e)
        {
            EventHandler eh = LogOutSignal;

            if (eh != null)
                eh(this, e);
        }

        /// <summary>
        /// Sets the data source of the grid and some extra layout configuration
        /// </summary>
        /// <param name="dt"></param>
        public void ConnectGridToSource(DataTable dt, string RightClickMenu, DataGridViewAutoSizeColumnMode SizeMode)
        {
            flexibleDataGrid.DataSource = dt;

            foreach (DataGridViewColumn column in flexibleDataGrid.Columns)
                column.AutoSizeMode = SizeMode;
            
            contextMenuGrid.Items.Clear();
            contextMenuGrid.Items.AddRange(LoadMenu(RightClickMenu));

            int separatorIndex = contextMenuGrid.Items.IndexOf(contextMenuGrid.Items.Find("toolStripExportPdf", true)[0]);

            contextMenuGrid.Items.Insert(separatorIndex, new ToolStripSeparator());

            flexibleDataGrid.ContextMenuStrip = contextMenuGrid;
        }

        private void LoadCommonMenu()
        {
            MenuList.Add(toolStripExportPdf);
            MenuList.Add(toolStripCloseGrid);
            MenuList.Add(toolStripLogOut);
            MenuList.Add(toolStripExit);
        }

        private void LoadProductsMenu()
        {
            MenuList.Clear();

            if (Globals.IsLogged && Globals.IsAdmin)
            {
                MenuList.Add(toolStripChangeTVA);
                MenuList.Add(toolStripSetOnSale);
                MenuList.Add(toolStripSetNotOnSale);
                MenuList.Add(toolStripShowOnSale);
                MenuList.Add(toolStripShowNotOnSale);
                MenuList.Add(toolStripShowAllProd);

                LoadCommonMenu();
            }
            else
            {
                MenuList.Add(toolStripShowOnSale);
                MenuList.Add(toolStripShowNotOnSale);
                MenuList.Add(toolStripShowAllProd);

                LoadCommonMenu();
            }
        }

        private void LoadShopsMenu()
        {
            MenuList.Clear();

            if (Globals.IsLogged && Globals.IsAdmin)
            {
                MenuList.Add(toolStripAddShop);
                MenuList.Add(toolStripRemoveShop);
                MenuList.Add(toolStripShowPartners);
                MenuList.Add(toolStripShowAllShops);
                MenuList.Add(toolStripAddShopProducts);
                MenuList.Add(toolStripDeleteShopProducts);
                MenuList.Add(toolStripShowShopProducts);

                LoadCommonMenu();
            }
            else
            {
                MenuList.Add(toolStripShowPartners);
                MenuList.Add(toolStripShowAllShops);

                LoadCommonMenu();
            }
        }

        private void LoadContactsMenu()
        {
            MenuList.Clear();

            if (Globals.IsLogged && Globals.IsAdmin)
            {
                MenuList.Add(toolStripDeleteContact);

                LoadCommonMenu();
            }
            else
                LoadCommonMenu();
        }

        private void LoadDriversMenu()
        {
            MenuList.Clear();

            if (Globals.IsLogged && Globals.IsAdmin)
            {
                MenuList.Add(toolStripFireDriver);

                LoadCommonMenu();
            }
            else
                LoadCommonMenu();
        }

        private void LoadReportsMenu()
        {
            MenuList.Clear();

            if (Globals.IsLogged && Globals.IsAdmin)
            {
                MenuList.Add(toolStripViewProductRep);
                MenuList.Add(toolStripRemoveRep);

                LoadCommonMenu();
            }
            else
            {
                MenuList.Add(toolStripViewProductRep);

                LoadCommonMenu();
            }
        }

        public ToolStripMenuItem[] LoadMenu(string MenuOption)
        {
            switch (MenuOption)
            {
                case "app_prod_info":
                    LoadProductsMenu();
                    break;
                case "app_magazine":
                    LoadShopsMenu();
                    break;
                case "app_magazine_datorii":
                    LoadShopsMenu();
                    break;
                case "app_pers_cont":
                    LoadContactsMenu();
                    break;
                case "app_soferi":
                    LoadDriversMenu();
                    break;
                case "app_livrari_prod":
                    LoadReportsMenu();
                    break;
            }

            return MenuList.ToArray();
        }

        #endregion

        #region - Events

        public event EventHandler LogOutSignal;

        private void usrGrid_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                this.Dock = DockStyle.Fill;
        }

        private void flexibleDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                flexibleDataGrid.CurrentCell = flexibleDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        private void btnCloseGrid_Click(object sender, EventArgs e)
        {
            usrVisibility(false);
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            try
            {
                PdfProcessing pdf = new PdfProcessing();
                string pdfName = "Raport NovaPane " + DateTime.Now.ToString("dd.MMM.yyyy hh-mm-ss");
                string pdfHeader = "Raport NovaPane" + "\n"
                                + DateTime.Now.ToString("dd.MMM.yyyy hh-mm-ss") + "\n"
                                + ((DataTable)flexibleDataGrid.DataSource).TableName;
                pdf.SendToPDF(pdfHeader, pdfName, flexibleDataGrid, flexibleDataGrid.DataSource as DataTable);

                CommonMessages.SuccessMessage("S-a adaugat raportul cu numele \"" + pdfName + "\" in dosarul Rapoarte");
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnExportGrid_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #region - Toolstrip Items

        #region - Common

        private void toolStripExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                PdfProcessing pdf = new PdfProcessing();
                string pdfName = "Raport NovaPane " + DateTime.Now.ToString("dd.MMM.yyyy hh-mm-ss");
                string pdfHeader = "Raport NovaPane" + "\n"
                                + DateTime.Now.ToString("dd.MMM.yyyy hh-mm-ss") + "\n"
                                + ((DataTable)flexibleDataGrid.DataSource).TableName;
                pdf.SendToPDF(pdfHeader, pdfName, flexibleDataGrid, flexibleDataGrid.DataSource as DataTable);

                CommonMessages.SuccessMessage("S-a adaugat raportul cu numele \"" + pdfName + "\" in dosarul Rapoarte !");
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripExportPdf_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripCloseGrid_Click(object sender, EventArgs e)
        {
            usrVisibility(false);
        }

        private void toolStripLogOut_Click(object sender, EventArgs e)
        {
            LogOut(null);
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region - Products

        private void toolStripChangeTVA_Click(object sender, EventArgs e)
        {
            int prodId = int.Parse(flexibleDataGrid.CurrentRow.Cells[0].Value.ToString());
            string oldPftva = flexibleDataGrid.CurrentRow.Cells[5].Value.ToString();
            string tva = flexibleDataGrid.CurrentRow.Cells[6].Value.ToString();

            dlgChangeTVA dlgChangeTva = new dlgChangeTVA(prodId, oldPftva, tva);
            dlgChangeTva.ShowDialog();
        }
        
        private void toolStripSetOnSale_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE app_prod SET comercializat = TRUE WHERE id_prod = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);

                usrGrid_Load(this, null);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripSetOnSale_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripSetNotOnSale_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE app_prod SET comercializat = FALSE WHERE id_prod = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);

                usrGrid_Load(this, null);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripSetNotOnSale_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripShowOnSale_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_prod_info WHERE comercializat = TRUE";

                db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql);
                ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripShowOnSale_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripShowNotOnSale_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_prod_info WHERE comercializat = FALSE";

                db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql);
                ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripShowNotOnSale_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripShowAllProd_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_prod_info";

                db.LoadDataSetBySQL(ds_Baker.app_prod_info, sql);
                ConnectGridToSource(ds_Baker.app_prod_info, ds_Baker.app_prod_info.TableName, DataGridViewAutoSizeColumnMode.Fill);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripShowAllProd_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Shops

        private void toolStripAddShop_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE app_magazine SET partener = TRUE WHERE id_mag = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripAddShop_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripRemoveShop_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE app_magazine SET partener = FALSE WHERE id_mag = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripRemoveShop_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripShowPartners_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_magazine WHERE partener = TRUE";

                db.LoadDataSetBySQL(ds_Baker.app_magazine, sql);
                ConnectGridToSource(ds_Baker.app_magazine, ds_Baker.app_magazine.TableName, DataGridViewAutoSizeColumnMode.Fill);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripShowPartners_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripShowAllShops_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_magazine";

                db.LoadDataSetBySQL(ds_Baker.app_magazine, sql);
                ConnectGridToSource(ds_Baker.app_magazine, ds_Baker.app_magazine.TableName, DataGridViewAutoSizeColumnMode.Fill);
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripShowAllShops_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripAddShopProducts_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDeleteShopProducts_Click(object sender, EventArgs e)
        {

        }
        
        private void toolStripShowShopProducts_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region - Contacts

        private void toolStripDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "DELETE FROM app_pers_cont WHERE id_pers_cont = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripDeleteContact_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Drivers

        private void toolStripFireDriver_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE app_soferi SET angajat = FALSE WHERE id_sofer = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripFireDriver_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Reports

        private void toolStripViewProductRep_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM app_livrari_prod WHERE id_raport_livrare = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.LoadDataSetBySQL(ds_Baker.app_livrari_prod, sql);

                dlgProducts dlgProd = new dlgProducts(ds_Baker.app_livrari_prod);
                dlgProd.Show();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripViewProductRep_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void toolStripRemoveRep_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "DELETE FROM app_livrari_detalii WHERE id_raport_livrare = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);

                sql = "DELETE FROM app_livrari WHERE id_raport_livrare = "
                    + flexibleDataGrid.CurrentRow.Cells[0].Value.ToString();

                db.ExecuteSqlCommand(sql);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "toolStripRemoveRep_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
        
        #endregion


        #endregion

        #endregion
    }
}
