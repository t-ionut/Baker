namespace Baker
{
    partial class usrAddRep
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
            this.lblSofer = new System.Windows.Forms.Label();
            this.cmbSofer = new System.Windows.Forms.ComboBox();
            this.lblMagazin = new System.Windows.Forms.Label();
            this.cmbMagazin = new System.Windows.Forms.ComboBox();
            this.lblTura = new System.Windows.Forms.Label();
            this.cmbTura = new System.Windows.Forms.ComboBox();
            this.cmbTurRetur = new System.Windows.Forms.ComboBox();
            this.lblTurRetur = new System.Windows.Forms.Label();
            this.dateTimeAddRep = new System.Windows.Forms.DateTimePicker();
            this.btnAddProds = new System.Windows.Forms.Button();
            this.btnAddRep = new System.Windows.Forms.Button();
            this.txtSumaIncasata = new System.Windows.Forms.TextBox();
            this.lblSumaIncasata = new System.Windows.Forms.Label();
            this.groupBoxAddRep = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBoxAddRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSofer
            // 
            this.lblSofer.AutoSize = true;
            this.lblSofer.Location = new System.Drawing.Point(3, 24);
            this.lblSofer.Name = "lblSofer";
            this.lblSofer.Size = new System.Drawing.Size(32, 13);
            this.lblSofer.TabIndex = 0;
            this.lblSofer.Text = "Sofer";
            // 
            // cmbSofer
            // 
            this.cmbSofer.FormattingEnabled = true;
            this.cmbSofer.Location = new System.Drawing.Point(6, 41);
            this.cmbSofer.Name = "cmbSofer";
            this.cmbSofer.Size = new System.Drawing.Size(165, 21);
            this.cmbSofer.TabIndex = 2;
            // 
            // lblMagazin
            // 
            this.lblMagazin.AutoSize = true;
            this.lblMagazin.Location = new System.Drawing.Point(3, 65);
            this.lblMagazin.Name = "lblMagazin";
            this.lblMagazin.Size = new System.Drawing.Size(47, 13);
            this.lblMagazin.TabIndex = 3;
            this.lblMagazin.Text = "Magazin";
            // 
            // cmbMagazin
            // 
            this.cmbMagazin.FormattingEnabled = true;
            this.cmbMagazin.Location = new System.Drawing.Point(6, 81);
            this.cmbMagazin.Name = "cmbMagazin";
            this.cmbMagazin.Size = new System.Drawing.Size(165, 21);
            this.cmbMagazin.TabIndex = 4;
            // 
            // lblTura
            // 
            this.lblTura.AutoSize = true;
            this.lblTura.Location = new System.Drawing.Point(3, 105);
            this.lblTura.Name = "lblTura";
            this.lblTura.Size = new System.Drawing.Size(29, 13);
            this.lblTura.TabIndex = 5;
            this.lblTura.Text = "Tura";
            // 
            // cmbTura
            // 
            this.cmbTura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTura.FormattingEnabled = true;
            this.cmbTura.Location = new System.Drawing.Point(6, 121);
            this.cmbTura.Name = "cmbTura";
            this.cmbTura.Size = new System.Drawing.Size(165, 21);
            this.cmbTura.TabIndex = 6;
            // 
            // cmbTurRetur
            // 
            this.cmbTurRetur.DisplayMember = "Tur";
            this.cmbTurRetur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurRetur.FormattingEnabled = true;
            this.cmbTurRetur.Location = new System.Drawing.Point(6, 167);
            this.cmbTurRetur.Name = "cmbTurRetur";
            this.cmbTurRetur.Size = new System.Drawing.Size(66, 21);
            this.cmbTurRetur.TabIndex = 7;
            // 
            // lblTurRetur
            // 
            this.lblTurRetur.AutoSize = true;
            this.lblTurRetur.Location = new System.Drawing.Point(3, 150);
            this.lblTurRetur.Name = "lblTurRetur";
            this.lblTurRetur.Size = new System.Drawing.Size(60, 13);
            this.lblTurRetur.TabIndex = 8;
            this.lblTurRetur.Text = "Tur / Retur";
            // 
            // dateTimeAddRep
            // 
            this.dateTimeAddRep.CustomFormat = "dd - MM - yyyy HH:mm";
            this.dateTimeAddRep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAddRep.Location = new System.Drawing.Point(6, 210);
            this.dateTimeAddRep.Name = "dateTimeAddRep";
            this.dateTimeAddRep.Size = new System.Drawing.Size(165, 20);
            this.dateTimeAddRep.TabIndex = 9;
            // 
            // btnAddProds
            // 
            this.btnAddProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProds.Image = global::Baker.Properties.Resources.icoProdAdd;
            this.btnAddProds.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddProds.Location = new System.Drawing.Point(78, 147);
            this.btnAddProds.Name = "btnAddProds";
            this.btnAddProds.Size = new System.Drawing.Size(93, 42);
            this.btnAddProds.TabIndex = 10;
            this.btnAddProds.Text = "Produse";
            this.btnAddProds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProds.UseVisualStyleBackColor = true;
            this.btnAddProds.Click += new System.EventHandler(this.btnAddProds_Click);
            // 
            // btnAddRep
            // 
            this.btnAddRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRep.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRep.Location = new System.Drawing.Point(37, 327);
            this.btnAddRep.Name = "btnAddRep";
            this.btnAddRep.Size = new System.Drawing.Size(147, 42);
            this.btnAddRep.TabIndex = 11;
            this.btnAddRep.Text = "Adauga Raportul";
            this.btnAddRep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRep.UseVisualStyleBackColor = true;
            this.btnAddRep.Click += new System.EventHandler(this.btnAddRep_Click);
            // 
            // txtSumaIncasata
            // 
            this.txtSumaIncasata.Location = new System.Drawing.Point(6, 251);
            this.txtSumaIncasata.Name = "txtSumaIncasata";
            this.txtSumaIncasata.Size = new System.Drawing.Size(165, 20);
            this.txtSumaIncasata.TabIndex = 12;
            // 
            // lblSumaIncasata
            // 
            this.lblSumaIncasata.AutoSize = true;
            this.lblSumaIncasata.Location = new System.Drawing.Point(3, 236);
            this.lblSumaIncasata.Name = "lblSumaIncasata";
            this.lblSumaIncasata.Size = new System.Drawing.Size(78, 13);
            this.lblSumaIncasata.TabIndex = 13;
            this.lblSumaIncasata.Text = "Suma Incasata";
            // 
            // groupBoxAddRep
            // 
            this.groupBoxAddRep.Controls.Add(this.lblDate);
            this.groupBoxAddRep.Controls.Add(this.cmbTura);
            this.groupBoxAddRep.Controls.Add(this.lblSumaIncasata);
            this.groupBoxAddRep.Controls.Add(this.lblSofer);
            this.groupBoxAddRep.Controls.Add(this.txtSumaIncasata);
            this.groupBoxAddRep.Controls.Add(this.cmbSofer);
            this.groupBoxAddRep.Controls.Add(this.lblMagazin);
            this.groupBoxAddRep.Controls.Add(this.btnAddProds);
            this.groupBoxAddRep.Controls.Add(this.cmbMagazin);
            this.groupBoxAddRep.Controls.Add(this.dateTimeAddRep);
            this.groupBoxAddRep.Controls.Add(this.lblTura);
            this.groupBoxAddRep.Controls.Add(this.lblTurRetur);
            this.groupBoxAddRep.Controls.Add(this.cmbTurRetur);
            this.groupBoxAddRep.Location = new System.Drawing.Point(17, 22);
            this.groupBoxAddRep.Name = "groupBoxAddRep";
            this.groupBoxAddRep.Size = new System.Drawing.Size(185, 291);
            this.groupBoxAddRep.TabIndex = 14;
            this.groupBoxAddRep.TabStop = false;
            this.groupBoxAddRep.Text = "Date Raport Nou";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 194);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Data Raport";
            // 
            // usrAddRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddRep);
            this.Controls.Add(this.btnAddRep);
            this.Name = "usrAddRep";
            this.Size = new System.Drawing.Size(220, 385);
            this.Load += new System.EventHandler(this.usrAddRep_Load);
            this.groupBoxAddRep.ResumeLayout(false);
            this.groupBoxAddRep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSofer;
        private System.Windows.Forms.ComboBox cmbSofer;
        private System.Windows.Forms.Label lblMagazin;
        private System.Windows.Forms.ComboBox cmbMagazin;
        private System.Windows.Forms.Label lblTura;
        private System.Windows.Forms.ComboBox cmbTura;
        private System.Windows.Forms.Label lblTurRetur;
        private System.Windows.Forms.ComboBox cmbTurRetur;        
        private System.Windows.Forms.DateTimePicker dateTimeAddRep;
        private System.Windows.Forms.Button btnAddProds;
        private System.Windows.Forms.Button btnAddRep;
        private System.Windows.Forms.TextBox txtSumaIncasata;
        private System.Windows.Forms.Label lblSumaIncasata;
        private System.Windows.Forms.GroupBox groupBoxAddRep;
        private System.Windows.Forms.Label lblDate;
    }
}
