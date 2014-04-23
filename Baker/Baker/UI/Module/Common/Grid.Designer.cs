namespace Baker
{
    partial class usrGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCloseGrid = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.flexibleDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripExportPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCloseGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripChangeTVA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetOnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetNotOnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowOnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowNotOnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowAllProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddShop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemoveShop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowPartners = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowAllShops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddShopProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteShopProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowShopProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFireDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripViewProductRep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemoveRep = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexibleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer.Panel2.Controls.Add(this.flexibleDataGrid);
            this.splitContainer.Size = new System.Drawing.Size(702, 377);
            this.splitContainer.SplitterDistance = 30;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.flowLayoutPanel1.Controls.Add(this.btnCloseGrid);
            this.flowLayoutPanel1.Controls.Add(this.btnExportGrid);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCloseGrid
            // 
            this.btnCloseGrid.AccessibleDescription = "";
            this.btnCloseGrid.AutoEllipsis = true;
            this.btnCloseGrid.BackgroundImage = global::Baker.Properties.Resources.icoClose;
            this.btnCloseGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseGrid.Location = new System.Drawing.Point(1, 1);
            this.btnCloseGrid.Margin = new System.Windows.Forms.Padding(1);
            this.btnCloseGrid.Name = "btnCloseGrid";
            this.btnCloseGrid.Size = new System.Drawing.Size(36, 29);
            this.btnCloseGrid.TabIndex = 0;
            this.btnCloseGrid.UseVisualStyleBackColor = true;
            this.btnCloseGrid.Click += new System.EventHandler(this.btnCloseGrid_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.AutoEllipsis = true;
            this.btnExportGrid.BackgroundImage = global::Baker.Properties.Resources.icoPdf1;
            this.btnExportGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportGrid.Location = new System.Drawing.Point(39, 1);
            this.btnExportGrid.Margin = new System.Windows.Forms.Padding(1);
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(36, 29);
            this.btnExportGrid.TabIndex = 1;
            this.btnExportGrid.UseVisualStyleBackColor = true;
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // flexibleDataGrid
            // 
            this.flexibleDataGrid.AllowUserToAddRows = false;
            this.flexibleDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flexibleDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flexibleDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(170)))));
            this.flexibleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flexibleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexibleDataGrid.Location = new System.Drawing.Point(0, 0);
            this.flexibleDataGrid.Name = "flexibleDataGrid";
            this.flexibleDataGrid.ReadOnly = true;
            this.flexibleDataGrid.Size = new System.Drawing.Size(702, 346);
            this.flexibleDataGrid.TabIndex = 0;
            this.flexibleDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.flexibleDataGrid_CellMouseDown);
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Name = "contextMenuGrid";
            this.contextMenuGrid.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripExportPdf
            // 
            this.toolStripExportPdf.Image = global::Baker.Properties.Resources.icoPdf3;
            this.toolStripExportPdf.Name = "toolStripExportPdf";
            this.toolStripExportPdf.Size = new System.Drawing.Size(152, 22);
            this.toolStripExportPdf.Text = "Exporta Ca PDF";
            this.toolStripExportPdf.Click += new System.EventHandler(this.toolStripExportPdf_Click);
            // 
            // toolStripCloseGrid
            // 
            this.toolStripCloseGrid.Name = "toolStripCloseGrid";
            this.toolStripCloseGrid.Size = new System.Drawing.Size(152, 22);
            this.toolStripCloseGrid.Text = "Ascunde Tabelul";
            this.toolStripCloseGrid.Click += new System.EventHandler(this.toolStripCloseGrid_Click);
            // 
            // toolStripLogOut
            // 
            this.toolStripLogOut.Image = global::Baker.Properties.Resources.icoAdminKey;
            this.toolStripLogOut.Name = "toolStripLogOut";
            this.toolStripLogOut.Size = new System.Drawing.Size(152, 22);
            this.toolStripLogOut.Text = "Delogare";
            this.toolStripLogOut.Click += new System.EventHandler(this.toolStripLogOut_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::Baker.Properties.Resources.icoCancel;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(152, 22);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripChangeTVA
            // 
            this.toolStripChangeTVA.Image = global::Baker.Properties.Resources.icoTva1;
            this.toolStripChangeTVA.Name = "toolStripChangeTVA";
            this.toolStripChangeTVA.Size = new System.Drawing.Size(152, 22);
            this.toolStripChangeTVA.Text = "Schimba T.V.A.";
            this.toolStripChangeTVA.Click += new System.EventHandler(this.toolStripChangeTVA_Click);
            // 
            // toolStripSetOnSale
            // 
            this.toolStripSetOnSale.Image = global::Baker.Properties.Resources.icoCheck;
            this.toolStripSetOnSale.Name = "toolStripSetOnSale";
            this.toolStripSetOnSale.Size = new System.Drawing.Size(152, 22);
            this.toolStripSetOnSale.Text = "Setare Comercializat";
            this.toolStripSetOnSale.Click += new System.EventHandler(this.toolStripSetOnSale_Click);
            // 
            // toolStripSetNotOnSale
            // 
            this.toolStripSetNotOnSale.Image = global::Baker.Properties.Resources.icoUncheck;
            this.toolStripSetNotOnSale.Name = "toolStripSetNotOnSale";
            this.toolStripSetNotOnSale.Size = new System.Drawing.Size(152, 22);
            this.toolStripSetNotOnSale.Text = "Setare Necomercializat";
            this.toolStripSetNotOnSale.Click += new System.EventHandler(this.toolStripSetNotOnSale_Click);
            // 
            // toolStripShowOnSale
            // 
            this.toolStripShowOnSale.Image = global::Baker.Properties.Resources.icoEyeCheck;
            this.toolStripShowOnSale.Name = "toolStripShowOnSale";
            this.toolStripShowOnSale.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowOnSale.Text = "Arata Comercializate";
            this.toolStripShowOnSale.Click += new System.EventHandler(this.toolStripShowOnSale_Click);
            // 
            // toolStripShowNotOnSale
            // 
            this.toolStripShowNotOnSale.Image = global::Baker.Properties.Resources.icoEyeUncheck;
            this.toolStripShowNotOnSale.Name = "toolStripShowNotOnSale";
            this.toolStripShowNotOnSale.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowNotOnSale.Text = "Arata Necomercializate";
            this.toolStripShowNotOnSale.Click += new System.EventHandler(this.toolStripShowNotOnSale_Click);
            // 
            // toolStripShowAllProd
            // 
            this.toolStripShowAllProd.Image = global::Baker.Properties.Resources.icoEye;
            this.toolStripShowAllProd.Name = "toolStripShowAllProd";
            this.toolStripShowAllProd.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowAllProd.Text = "Arata Toate Produsele";
            this.toolStripShowAllProd.Click += new System.EventHandler(this.toolStripShowAllProd_Click);
            // 
            // toolStripAddShop
            // 
            this.toolStripAddShop.Image = global::Baker.Properties.Resources.icoCheck;
            this.toolStripAddShop.Name = "toolStripAddShop";
            this.toolStripAddShop.Size = new System.Drawing.Size(152, 22);
            this.toolStripAddShop.Text = "Setare Partener";
            this.toolStripAddShop.Click += new System.EventHandler(this.toolStripAddShop_Click);
            // 
            // toolStripRemoveShop
            // 
            this.toolStripRemoveShop.Image = global::Baker.Properties.Resources.icoUncheck;
            this.toolStripRemoveShop.Name = "toolStripRemoveShop";
            this.toolStripRemoveShop.Size = new System.Drawing.Size(152, 22);
            this.toolStripRemoveShop.Text = "Sterge Partener";
            this.toolStripRemoveShop.Click += new System.EventHandler(this.toolStripRemoveShop_Click);
            // 
            // toolStripShowPartners
            // 
            this.toolStripShowPartners.Image = global::Baker.Properties.Resources.icoEyeCheck;
            this.toolStripShowPartners.Name = "toolStripShowPartners";
            this.toolStripShowPartners.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowPartners.Text = "Arata Parteneri";
            this.toolStripShowPartners.Click += new System.EventHandler(this.toolStripShowPartners_Click);
            // 
            // toolStripShowAllShops
            // 
            this.toolStripShowAllShops.Image = global::Baker.Properties.Resources.icoEye;
            this.toolStripShowAllShops.Name = "toolStripShowAllShops";
            this.toolStripShowAllShops.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowAllShops.Text = "Arata Toate Magazinele";
            this.toolStripShowAllShops.Click += new System.EventHandler(this.toolStripShowAllShops_Click);
            //  
            // toolStripAddShopProducts
            // 
            //this.toolStripAddShopProducts.Image = global::Baker.Properties.Resources.icoEye;
            this.toolStripAddShopProducts.Name = "toolStripAddShopProducts";
            this.toolStripAddShopProducts.Size = new System.Drawing.Size(152, 22);
            this.toolStripAddShopProducts.Text = "Arata Toate Magazinele";
            this.toolStripAddShopProducts.Click += new System.EventHandler(this.toolStripAddShopProducts_Click);
            // 
            // toolStripDeleteShopProducts
            // 
            //this.toolStripDeleteShopProducts.Image = global::Baker.Properties.Resources.icoEye;
            this.toolStripDeleteShopProducts.Name = "toolStripDeleteShopProducts";
            this.toolStripDeleteShopProducts.Size = new System.Drawing.Size(152, 22);
            this.toolStripDeleteShopProducts.Text = "Arata Toate Magazinele";
            this.toolStripDeleteShopProducts.Click += new System.EventHandler(this.toolStripDeleteShopProducts_Click);
            // 
            // toolStripShowShopProducts
            // 
            //this.toolStripShowShopProducts.Image = global::Baker.Properties.Resources.icoEye;
            this.toolStripShowShopProducts.Name = "toolStripShowShopProducts";
            this.toolStripShowShopProducts.Size = new System.Drawing.Size(152, 22);
            this.toolStripShowShopProducts.Text = "Arata Toate Magazinele";
            this.toolStripShowShopProducts.Click += new System.EventHandler(this.toolStripShowShopProducts_Click);
            // 
            // toolStripDeleteContact
            // 
            this.toolStripDeleteContact.Image = global::Baker.Properties.Resources.icoUncheck;
            this.toolStripDeleteContact.Name = "toolStripDeleteContact";
            this.toolStripDeleteContact.Size = new System.Drawing.Size(152, 22);
            this.toolStripDeleteContact.Text = "Sterge Contact";
            this.toolStripDeleteContact.Click += new System.EventHandler(this.toolStripDeleteContact_Click);
            // 
            // toolStripFireDriver
            // 
            this.toolStripFireDriver.Image = global::Baker.Properties.Resources.icoUncheck;
            this.toolStripFireDriver.Name = "toolStripFireDriver";
            this.toolStripFireDriver.Size = new System.Drawing.Size(152, 22);
            this.toolStripFireDriver.Text = "Sterge Sofer";
            this.toolStripFireDriver.Click += new System.EventHandler(this.toolStripFireDriver_Click);
            // 
            // toolStripViewProductRep
            // 
            this.toolStripViewProductRep.Image = global::Baker.Properties.Resources.icoProd;
            this.toolStripViewProductRep.Name = "toolStripViewProductRep";
            this.toolStripViewProductRep.Size = new System.Drawing.Size(152, 22);
            this.toolStripViewProductRep.Text = "Arata Produsele Livrate";
            this.toolStripViewProductRep.Click += new System.EventHandler(this.toolStripViewProductRep_Click);
            // 
            // toolStripRemoveRep
            // 
            this.toolStripRemoveRep.Image = global::Baker.Properties.Resources.icoUncheck;
            this.toolStripRemoveRep.Name = "toolStripRemoveRep";
            this.toolStripRemoveRep.Size = new System.Drawing.Size(152, 22);
            this.toolStripRemoveRep.Text = "Sterge Raport";
            this.toolStripRemoveRep.Click += new System.EventHandler(this.toolStripRemoveRep_Click);
            // 
            // usrGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer);
            this.Name = "usrGrid";
            this.Size = new System.Drawing.Size(702, 377);
            this.Load += new System.EventHandler(this.usrGrid_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexibleDataGrid)).EndInit();
            this.ResumeLayout(false);

        }      

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView flexibleDataGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCloseGrid;
        private System.Windows.Forms.Button btnExportGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;

        // Common
        private System.Windows.Forms.ToolStripMenuItem toolStripExportPdf;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloseGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripLogOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        // Products
        private System.Windows.Forms.ToolStripMenuItem toolStripChangeTVA;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetOnSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetNotOnSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowOnSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowNotOnSale;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowAllProd;
        // Shops        
        private System.Windows.Forms.ToolStripMenuItem toolStripAddShop;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveShop;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowPartners;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowAllShops;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddShopProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteShopProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowShopProducts;
        // Contacts
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteContact;
        // Drivers
        private System.Windows.Forms.ToolStripMenuItem toolStripFireDriver;
        // Reports
        private System.Windows.Forms.ToolStripMenuItem toolStripViewProductRep;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveRep;
    }
}
