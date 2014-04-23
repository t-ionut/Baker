namespace Baker
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.rbTabProduse = new System.Windows.Forms.RibbonTab();
            this.rbPanelViewProd = new System.Windows.Forms.RibbonPanel();
            this.rbBtnProd = new System.Windows.Forms.RibbonButton();
            this.rbProdCategory = new System.Windows.Forms.RibbonButtonList();
            this.rbCatPaine = new System.Windows.Forms.RibbonButton();
            this.rbCatCozonac = new System.Windows.Forms.RibbonButton();
            this.rbCatPatiserie = new System.Windows.Forms.RibbonButton();
            this.rbCatDiverse = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.rbPanelModifyProd = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAddProd = new System.Windows.Forms.RibbonButton();
            this.rbTabMagazine = new System.Windows.Forms.RibbonTab();
            this.rbPanelViewMag = new System.Windows.Forms.RibbonPanel();
            this.rbBtnViewMag = new System.Windows.Forms.RibbonButton();
            this.rbBtnViewMagDebt = new System.Windows.Forms.RibbonButton();
            this.rbPanelModifyMag = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAddMag = new System.Windows.Forms.RibbonButton();
            this.rbBtnProdMag = new System.Windows.Forms.RibbonButton();
            this.rbTabSoferi = new System.Windows.Forms.RibbonTab();
            this.rbPanelViewSoferi = new System.Windows.Forms.RibbonPanel();
            this.rbBtnViewSofer = new System.Windows.Forms.RibbonButton();
            this.rbPanelModifySoferi = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAddSofer = new System.Windows.Forms.RibbonButton();
            this.rbTabRapoarte = new System.Windows.Forms.RibbonTab();
            this.rbPanelViewRep = new System.Windows.Forms.RibbonPanel();
            this.rbBtnViewRep = new System.Windows.Forms.RibbonButton();
            this.rbBtnSearchRep = new System.Windows.Forms.RibbonButton();
            this.rbPanelModifyRep = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAddRep = new System.Windows.Forms.RibbonButton();
            this.rbBaker = new System.Windows.Forms.Ribbon();
            this.rbOrbItemAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbOrbItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbTabPersCont = new System.Windows.Forms.RibbonTab();
            this.rbPanelViewPersCont = new System.Windows.Forms.RibbonPanel();
            this.rbBtnViewPersCont = new System.Windows.Forms.RibbonButton();
            this.rbPanelModifyPersCont = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAddPersCont = new System.Windows.Forms.RibbonButton();
            this.rbOrbItemRegUser = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbOrbItemDelUser = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbOrbItemLogOut = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.splitView = new System.Windows.Forms.SplitContainer();
            this.panelView = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitView.Panel2.SuspendLayout();
            this.splitView.SuspendLayout();
            this.panelView.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTabProduse
            // 
            this.rbTabProduse.Panels.Add(this.rbPanelViewProd);
            this.rbTabProduse.Panels.Add(this.rbPanelModifyProd);
            this.rbTabProduse.Text = "Produse";
            // 
            // rbPanelViewProd
            // 
            this.rbPanelViewProd.ButtonMoreEnabled = false;
            this.rbPanelViewProd.ButtonMoreVisible = false;
            this.rbPanelViewProd.Items.Add(this.rbBtnProd);
            this.rbPanelViewProd.Items.Add(this.rbProdCategory);
            this.rbPanelViewProd.Text = "Vizualizare";
            // 
            // rbBtnProd
            // 
            this.rbBtnProd.Image = global::Baker.Properties.Resources.icoProd;
            this.rbBtnProd.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnProd.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProd.SmallImage")));
            this.rbBtnProd.Text = " Afisare";
            this.rbBtnProd.Click += new System.EventHandler(this.rbBtnViewProd_Click);
            // 
            // rbProdCategory
            // 
            this.rbProdCategory.Buttons.Add(this.rbCatPaine);
            this.rbProdCategory.Buttons.Add(this.rbCatCozonac);
            this.rbProdCategory.Buttons.Add(this.rbCatPatiserie);
            this.rbProdCategory.Buttons.Add(this.rbCatDiverse);
            this.rbProdCategory.Buttons.Add(this.ribbonButton1);
            this.rbProdCategory.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.rbProdCategory.ControlButtonsWidth = 15;
            this.rbProdCategory.FlowToBottom = false;
            this.rbProdCategory.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
            this.rbProdCategory.ItemsWideInMediumMode = 20;
            this.rbProdCategory.Text = "Vizualizare Categorii";
            // 
            // rbCatPaine
            // 
            this.rbCatPaine.Image = ((System.Drawing.Image)(resources.GetObject("rbCatPaine.Image")));
            this.rbCatPaine.SmallImage = global::Baker.Properties.Resources.icoToast;
            this.rbCatPaine.Text = "Paine";
            this.rbCatPaine.Click += new System.EventHandler(this.rbCatPaine_Click);
            // 
            // rbCatCozonac
            // 
            this.rbCatCozonac.Image = ((System.Drawing.Image)(resources.GetObject("rbCatCozonac.Image")));
            this.rbCatCozonac.SmallImage = global::Baker.Properties.Resources.icoCozonac;
            this.rbCatCozonac.Text = "Cozonac";
            this.rbCatCozonac.Click += new System.EventHandler(this.rbCatCozonac_Click);
            // 
            // rbCatPatiserie
            // 
            this.rbCatPatiserie.Image = ((System.Drawing.Image)(resources.GetObject("rbCatPatiserie.Image")));
            this.rbCatPatiserie.SmallImage = global::Baker.Properties.Resources.icoDonut;
            this.rbCatPatiserie.Text = "Patiserie";
            this.rbCatPatiserie.Click += new System.EventHandler(this.rbCatPatiserie_Click);
            // 
            // rbCatDiverse
            // 
            this.rbCatDiverse.Image = ((System.Drawing.Image)(resources.GetObject("rbCatDiverse.Image")));
            this.rbCatDiverse.SmallImage = global::Baker.Properties.Resources.icoQuestion;
            this.rbCatDiverse.Text = "Diverse";
            this.rbCatDiverse.Click += new System.EventHandler(this.rbCatDiverse_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "";
            this.ribbonButton1.Visible = false;
            // 
            // rbPanelModifyProd
            // 
            this.rbPanelModifyProd.ButtonMoreEnabled = false;
            this.rbPanelModifyProd.ButtonMoreVisible = false;
            this.rbPanelModifyProd.Items.Add(this.rbBtnAddProd);
            this.rbPanelModifyProd.Text = "Modificare";
            // 
            // rbBtnAddProd
            // 
            this.rbBtnAddProd.Image = global::Baker.Properties.Resources.icoProdAdd;
            this.rbBtnAddProd.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnAddProd.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddProd.SmallImage")));
            this.rbBtnAddProd.Text = " Adaugare";
            this.rbBtnAddProd.Click += new System.EventHandler(this.rbBtnAddProd_Click);
            // 
            // rbTabMagazine
            // 
            this.rbTabMagazine.Panels.Add(this.rbPanelViewMag);
            this.rbTabMagazine.Panels.Add(this.rbPanelModifyMag);
            this.rbTabMagazine.Text = "Magazine";
            // 
            // rbPanelViewMag
            // 
            this.rbPanelViewMag.ButtonMoreEnabled = false;
            this.rbPanelViewMag.ButtonMoreVisible = false;
            this.rbPanelViewMag.Items.Add(this.rbBtnViewMag);
            this.rbPanelViewMag.Items.Add(this.rbBtnViewMagDebt);
            this.rbPanelViewMag.Text = "Vizualizare";
            // 
            // rbBtnViewMag
            // 
            this.rbBtnViewMag.Image = global::Baker.Properties.Resources.icoShop;
            this.rbBtnViewMag.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnViewMag.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnViewMag.SmallImage")));
            this.rbBtnViewMag.Text = " Afisare";
            this.rbBtnViewMag.Click += new System.EventHandler(this.rbBtnViewMag_Click);
            // 
            // rbBtnViewMagDebt
            // 
            this.rbBtnViewMagDebt.Image = global::Baker.Properties.Resources.icoShopDebt;
            this.rbBtnViewMagDebt.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnViewMagDebt.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnViewMagDebt.SmallImage")));
            this.rbBtnViewMagDebt.Text = "Afisare Datorii";
            this.rbBtnViewMagDebt.Click += new System.EventHandler(this.rbBtnViewMagDebt_Click);
            // 
            // rbPanelModifyMag
            // 
            this.rbPanelModifyMag.ButtonMoreEnabled = false;
            this.rbPanelModifyMag.ButtonMoreVisible = false;
            this.rbPanelModifyMag.Items.Add(this.rbBtnAddMag);
            this.rbPanelModifyMag.Items.Add(this.rbBtnProdMag);
            this.rbPanelModifyMag.Text = "Modificare";
            // 
            // rbBtnAddMag
            // 
            this.rbBtnAddMag.Image = global::Baker.Properties.Resources.icoShopAdd;
            this.rbBtnAddMag.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnAddMag.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddMag.SmallImage")));
            this.rbBtnAddMag.Text = " Adaugare";
            this.rbBtnAddMag.Click += new System.EventHandler(this.rbBtnAddMag_Click);
            // 
            // rbBtnProdMag
            // 
            this.rbBtnProdMag.Image = global::Baker.Properties.Resources.icoProdMag;
            this.rbBtnProdMag.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnProdMag.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProdMag.SmallImage")));
            this.rbBtnProdMag.Text = "Produse Magazin";
            this.rbBtnProdMag.Click += new System.EventHandler(this.rbBtnProdMag_Click);
            // 
            // rbTabSoferi
            // 
            this.rbTabSoferi.Panels.Add(this.rbPanelViewSoferi);
            this.rbTabSoferi.Panels.Add(this.rbPanelModifySoferi);
            this.rbTabSoferi.Text = "Soferi";
            // 
            // rbPanelViewSoferi
            // 
            this.rbPanelViewSoferi.ButtonMoreEnabled = false;
            this.rbPanelViewSoferi.ButtonMoreVisible = false;
            this.rbPanelViewSoferi.Items.Add(this.rbBtnViewSofer);
            this.rbPanelViewSoferi.Text = "Vizualizare";
            // 
            // rbBtnViewSofer
            // 
            this.rbBtnViewSofer.Image = global::Baker.Properties.Resources.icoCar;
            this.rbBtnViewSofer.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnViewSofer.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnViewSofer.SmallImage")));
            this.rbBtnViewSofer.Text = " Afisare";
            this.rbBtnViewSofer.Click += new System.EventHandler(this.rbBtnViewSofer_Click);
            // 
            // rbPanelModifySoferi
            // 
            this.rbPanelModifySoferi.ButtonMoreEnabled = false;
            this.rbPanelModifySoferi.ButtonMoreVisible = false;
            this.rbPanelModifySoferi.Items.Add(this.rbBtnAddSofer);
            this.rbPanelModifySoferi.Text = "Modificare";
            // 
            // rbBtnAddSofer
            // 
            this.rbBtnAddSofer.Image = global::Baker.Properties.Resources.icoCarAdd;
            this.rbBtnAddSofer.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnAddSofer.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddSofer.SmallImage")));
            this.rbBtnAddSofer.Text = " Adaugare";
            this.rbBtnAddSofer.Click += new System.EventHandler(this.rbBtnAddSofer_Click);
            // 
            // rbTabRapoarte
            // 
            this.rbTabRapoarte.Panels.Add(this.rbPanelViewRep);
            this.rbTabRapoarte.Panels.Add(this.rbPanelModifyRep);
            this.rbTabRapoarte.Text = "Rapoarte";
            // 
            // rbPanelViewRep
            // 
            this.rbPanelViewRep.ButtonMoreEnabled = false;
            this.rbPanelViewRep.ButtonMoreVisible = false;
            this.rbPanelViewRep.Items.Add(this.rbBtnViewRep);
            this.rbPanelViewRep.Items.Add(this.rbBtnSearchRep);
            this.rbPanelViewRep.Text = "Vizualizare";
            // 
            // rbBtnViewRep
            // 
            this.rbBtnViewRep.Image = global::Baker.Properties.Resources.icoRep;
            this.rbBtnViewRep.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnViewRep.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnViewRep.SmallImage")));
            this.rbBtnViewRep.Text = " Afisare";
            this.rbBtnViewRep.Click += new System.EventHandler(this.rbBtnViewRep_Click);
            // 
            // rbBtnSearchRep
            // 
            this.rbBtnSearchRep.Image = global::Baker.Properties.Resources.icoRepSearch;
            this.rbBtnSearchRep.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnSearchRep.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSearchRep.SmallImage")));
            this.rbBtnSearchRep.Text = " Cautare";
            this.rbBtnSearchRep.Click += new System.EventHandler(this.rbBtnSearchRep_Click);
            // 
            // rbPanelModifyRep
            // 
            this.rbPanelModifyRep.ButtonMoreEnabled = false;
            this.rbPanelModifyRep.ButtonMoreVisible = false;
            this.rbPanelModifyRep.Items.Add(this.rbBtnAddRep);
            this.rbPanelModifyRep.Text = "Modificare";
            // 
            // rbBtnAddRep
            // 
            this.rbBtnAddRep.Image = global::Baker.Properties.Resources.icoRepAdd;
            this.rbBtnAddRep.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnAddRep.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddRep.SmallImage")));
            this.rbBtnAddRep.Text = " Adaugare";
            this.rbBtnAddRep.Click += new System.EventHandler(this.rbBtnAddRep_Click);
            // 
            // rbBaker
            // 
            this.rbBaker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaker.Location = new System.Drawing.Point(0, 0);
            this.rbBaker.Minimized = false;
            this.rbBaker.Name = "rbBaker";
            // 
            // 
            // 
            this.rbBaker.OrbDropDown.BorderRoundness = 10;
            this.rbBaker.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbBaker.OrbDropDown.MenuItems.Add(this.rbOrbItemAbout);
            this.rbBaker.OrbDropDown.MenuItems.Add(this.rbOrbItemExit);
            this.rbBaker.OrbDropDown.Name = "";
            this.rbBaker.OrbDropDown.Size = new System.Drawing.Size(527, 250);
            this.rbBaker.OrbDropDown.TabIndex = 0;
            this.rbBaker.OrbImage = global::Baker.Properties.Resources.iconOrb;
            this.rbBaker.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.rbBaker.OrbText = "";
            // 
            // 
            // 
            this.rbBaker.QuickAcessToolbar.Visible = false;
            this.rbBaker.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbBaker.Size = new System.Drawing.Size(884, 155);
            this.rbBaker.TabIndex = 0;
            this.rbBaker.Tabs.Add(this.rbTabProduse);
            this.rbBaker.Tabs.Add(this.rbTabMagazine);
            this.rbBaker.Tabs.Add(this.rbTabPersCont);
            this.rbBaker.Tabs.Add(this.rbTabSoferi);
            this.rbBaker.Tabs.Add(this.rbTabRapoarte);
            this.rbBaker.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.rbBaker.Text = "ribBaker";
            this.rbBaker.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // rbOrbItemAbout
            // 
            this.rbOrbItemAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbOrbItemAbout.Image = global::Baker.Properties.Resources.icoInfo;
            this.rbOrbItemAbout.SmallImage = global::Baker.Properties.Resources.icoInfo;
            this.rbOrbItemAbout.Text = "Informatii";
            this.rbOrbItemAbout.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.rbOrbItemAbout.Click += new System.EventHandler(this.rbOrbItemAbout_Click);
            // 
            // rbOrbItemExit
            // 
            this.rbOrbItemExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbOrbItemExit.Image = global::Baker.Properties.Resources.icoCancel;
            this.rbOrbItemExit.SmallImage = global::Baker.Properties.Resources.icoCancel;
            this.rbOrbItemExit.Text = "Exit";
            this.rbOrbItemExit.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.rbOrbItemExit.Click += new System.EventHandler(this.rbOrbItemExit_Click);
            // 
            // rbTabPersCont
            // 
            this.rbTabPersCont.Panels.Add(this.rbPanelViewPersCont);
            this.rbTabPersCont.Panels.Add(this.rbPanelModifyPersCont);
            this.rbTabPersCont.Text = "Persoane de contact";
            // 
            // rbPanelViewPersCont
            // 
            this.rbPanelViewPersCont.ButtonMoreEnabled = false;
            this.rbPanelViewPersCont.ButtonMoreVisible = false;
            this.rbPanelViewPersCont.Items.Add(this.rbBtnViewPersCont);
            this.rbPanelViewPersCont.Text = "Vizualizare";
            // 
            // rbBtnViewPersCont
            // 
            this.rbBtnViewPersCont.Image = global::Baker.Properties.Resources.icoPhone;
            this.rbBtnViewPersCont.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnViewPersCont.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnViewPersCont.SmallImage")));
            this.rbBtnViewPersCont.Text = "Afisare";
            this.rbBtnViewPersCont.Click += new System.EventHandler(this.rbBtnViewPersCont_Click);
            // 
            // rbPanelModifyPersCont
            // 
            this.rbPanelModifyPersCont.ButtonMoreEnabled = false;
            this.rbPanelModifyPersCont.ButtonMoreVisible = false;
            this.rbPanelModifyPersCont.Items.Add(this.rbBtnAddPersCont);
            this.rbPanelModifyPersCont.Text = "Modificare";
            // 
            // rbBtnAddPersCont
            // 
            this.rbBtnAddPersCont.Image = global::Baker.Properties.Resources.icoPhoneAdd;
            this.rbBtnAddPersCont.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbBtnAddPersCont.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddPersCont.SmallImage")));
            this.rbBtnAddPersCont.Text = "Adaugare";
            this.rbBtnAddPersCont.Click += new System.EventHandler(this.rbBtnAddPersCont_Click);
            // 
            // rbOrbItemRegUser
            // 
            this.rbOrbItemRegUser.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbOrbItemRegUser.Image = global::Baker.Properties.Resources.icoAddKey;
            this.rbOrbItemRegUser.SmallImage = global::Baker.Properties.Resources.icoAddKey;
            this.rbOrbItemRegUser.Text = "Inregistrare User";
            this.rbOrbItemRegUser.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.rbOrbItemRegUser.Click += new System.EventHandler(this.rbOrbItemRegUser_Click);
            // 
            // rbOrbItemDelUser
            // 
            this.rbOrbItemDelUser.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbOrbItemDelUser.Image = global::Baker.Properties.Resources.icoDeleteKey;
            this.rbOrbItemDelUser.SmallImage = global::Baker.Properties.Resources.icoDeleteKey;
            this.rbOrbItemDelUser.Text = "Stergere User";
            this.rbOrbItemDelUser.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.rbOrbItemDelUser.Click += new System.EventHandler(this.rbOrbItemDelUser_Click);
            // 
            // rbOrbItemLogOut
            // 
            this.rbOrbItemLogOut.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rbOrbItemLogOut.Image = global::Baker.Properties.Resources.icoAdminKey1;
            this.rbOrbItemLogOut.SmallImage = global::Baker.Properties.Resources.icoAdminKey1;
            this.rbOrbItemLogOut.Text = "Delogare";
            this.rbOrbItemLogOut.Click += new System.EventHandler(this.rbOrbItemLogOut_Click);
            // 
            // splitView
            // 
            this.splitView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitView.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitView.IsSplitterFixed = true;
            this.splitView.Location = new System.Drawing.Point(0, 0);
            this.splitView.Name = "splitView";
            // 
            // splitView.Panel1
            // 
            this.splitView.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            // 
            // splitView.Panel2
            // 
            this.splitView.Panel2.BackgroundImage = global::Baker.Properties.Resources.bgBread;
            this.splitView.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitView.Panel2.Controls.Add(this.splitContainer1);
            this.splitView.Size = new System.Drawing.Size(884, 386);
            this.splitView.SplitterDistance = 218;
            this.splitView.SplitterWidth = 5;
            this.splitView.TabIndex = 1;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(170)))));
            this.panelView.Controls.Add(this.splitView);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 155);
            this.panelView.Name = "panelView";
            this.panelView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelView.Size = new System.Drawing.Size(884, 386);
            this.panelView.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Baker.Properties.Resources.bgBread;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Size = new System.Drawing.Size(659, 384);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.rbBaker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baker";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.splitView.Panel2.ResumeLayout(false);
            this.splitView.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.RibbonTab rbTabProduse;
        private System.Windows.Forms.RibbonPanel rbPanelViewProd;
        private System.Windows.Forms.RibbonTab rbTabMagazine;
        private System.Windows.Forms.RibbonTab rbTabSoferi;
        private System.Windows.Forms.RibbonTab rbTabRapoarte;
        private System.Windows.Forms.RibbonPanel rbPanelViewMag;
        private System.Windows.Forms.RibbonButton rbBtnAddMag;
        private System.Windows.Forms.RibbonButton rbBtnViewMag;
        private System.Windows.Forms.RibbonPanel rbPanelViewSoferi;
        private System.Windows.Forms.RibbonButton rbBtnAddSofer;
        private System.Windows.Forms.RibbonButton rbBtnViewSofer;
        private System.Windows.Forms.RibbonPanel rbPanelViewRep;
        private System.Windows.Forms.RibbonButton rbBtnAddRep;
        private System.Windows.Forms.RibbonButton rbBtnViewRep;
        private System.Windows.Forms.RibbonButton rbBtnAddProd;
        private System.Windows.Forms.RibbonButton rbBtnProd;
        private System.Windows.Forms.Ribbon rbBaker;
        private System.Windows.Forms.RibbonButtonList rbProdCategory;
        private System.Windows.Forms.RibbonButton rbCatPaine;
        private System.Windows.Forms.RibbonButton rbCatCozonac;
        private System.Windows.Forms.RibbonButton rbCatPatiserie;
        private System.Windows.Forms.RibbonButton rbCatDiverse;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.SplitContainer splitView;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.RibbonButton rbBtnSearchRep;
        private System.Windows.Forms.RibbonTab rbTabPersCont;
        private System.Windows.Forms.RibbonPanel rbPanelViewPersCont;
        private System.Windows.Forms.RibbonPanel rbPanelModifyProd;
        private System.Windows.Forms.RibbonPanel rbPanelModifySoferi;
        private System.Windows.Forms.RibbonPanel rbPanelModifyRep;
        private System.Windows.Forms.RibbonPanel rbPanelModifyPersCont;
        private System.Windows.Forms.RibbonPanel rbPanelModifyMag;
        private System.Windows.Forms.RibbonButton rbBtnViewPersCont;
        private System.Windows.Forms.RibbonButton rbBtnAddPersCont;
        private System.Windows.Forms.RibbonOrbMenuItem rbOrbItemRegUser;
        private System.Windows.Forms.RibbonOrbMenuItem rbOrbItemDelUser;
        private System.Windows.Forms.RibbonOrbMenuItem rbOrbItemLogOut;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem rbOrbItemAbout;
        private System.Windows.Forms.RibbonOrbMenuItem rbOrbItemExit;
        private System.Windows.Forms.RibbonButton rbBtnViewMagDebt;
        private System.Windows.Forms.RibbonButton rbBtnProdMag;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

