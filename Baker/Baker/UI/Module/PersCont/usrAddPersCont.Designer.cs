namespace Baker
{
    partial class usrAddPersCont
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
            this.lblNumePersCont = new System.Windows.Forms.Label();
            this.lblTelPersCont = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.txtNumePersCont = new System.Windows.Forms.TextBox();
            this.txtTelPersCont = new System.Windows.Forms.TextBox();
            this.cmbMagazin = new System.Windows.Forms.ComboBox();
            this.btnAddPersCont = new System.Windows.Forms.Button();
            this.groupBoxAddPersCont = new System.Windows.Forms.GroupBox();
            this.groupBoxAddPersCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumePersCont
            // 
            this.lblNumePersCont.AutoSize = true;
            this.lblNumePersCont.Location = new System.Drawing.Point(3, 21);
            this.lblNumePersCont.Name = "lblNumePersCont";
            this.lblNumePersCont.Size = new System.Drawing.Size(35, 13);
            this.lblNumePersCont.TabIndex = 0;
            this.lblNumePersCont.Text = "Nume";
            // 
            // lblTelPersCont
            // 
            this.lblTelPersCont.AutoSize = true;
            this.lblTelPersCont.Location = new System.Drawing.Point(3, 60);
            this.lblTelPersCont.Name = "lblTelPersCont";
            this.lblTelPersCont.Size = new System.Drawing.Size(43, 13);
            this.lblTelPersCont.TabIndex = 1;
            this.lblTelPersCont.Text = "Telefon";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(3, 99);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(47, 13);
            this.lblMag.TabIndex = 2;
            this.lblMag.Text = "Magazin";
            // 
            // txtNumePersCont
            // 
            this.txtNumePersCont.Location = new System.Drawing.Point(6, 37);
            this.txtNumePersCont.Name = "txtNumePersCont";
            this.txtNumePersCont.Size = new System.Drawing.Size(165, 20);
            this.txtNumePersCont.TabIndex = 3;
            // 
            // txtTelPersCont
            // 
            this.txtTelPersCont.Location = new System.Drawing.Point(6, 76);
            this.txtTelPersCont.Name = "txtTelPersCont";
            this.txtTelPersCont.Size = new System.Drawing.Size(165, 20);
            this.txtTelPersCont.TabIndex = 4;
            // 
            // cmbMagazin
            // 
            this.cmbMagazin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMagazin.FormattingEnabled = true;
            this.cmbMagazin.Location = new System.Drawing.Point(6, 115);
            this.cmbMagazin.Name = "cmbMagazin";
            this.cmbMagazin.Size = new System.Drawing.Size(165, 21);
            this.cmbMagazin.TabIndex = 5;
            // 
            // btnAddPersCont
            // 
            this.btnAddPersCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPersCont.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddPersCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPersCont.Location = new System.Drawing.Point(37, 186);
            this.btnAddPersCont.Name = "btnAddPersCont";
            this.btnAddPersCont.Size = new System.Drawing.Size(145, 42);
            this.btnAddPersCont.TabIndex = 6;
            this.btnAddPersCont.Text = "Adauga Contact";
            this.btnAddPersCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPersCont.UseVisualStyleBackColor = true;
            this.btnAddPersCont.Click += new System.EventHandler(this.btnAddPersCont_Click);
            // 
            // groupBoxAddPersCont
            // 
            this.groupBoxAddPersCont.Controls.Add(this.cmbMagazin);
            this.groupBoxAddPersCont.Controls.Add(this.lblNumePersCont);
            this.groupBoxAddPersCont.Controls.Add(this.lblTelPersCont);
            this.groupBoxAddPersCont.Controls.Add(this.txtTelPersCont);
            this.groupBoxAddPersCont.Controls.Add(this.lblMag);
            this.groupBoxAddPersCont.Controls.Add(this.txtNumePersCont);
            this.groupBoxAddPersCont.Location = new System.Drawing.Point(17, 25);
            this.groupBoxAddPersCont.Name = "groupBoxAddPersCont";
            this.groupBoxAddPersCont.Size = new System.Drawing.Size(185, 145);
            this.groupBoxAddPersCont.TabIndex = 23;
            this.groupBoxAddPersCont.TabStop = false;
            this.groupBoxAddPersCont.Text = "Date Persoana de Contact";
            // 
            // usrAddPersCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddPersCont);
            this.Controls.Add(this.btnAddPersCont);
            this.Name = "usrAddPersCont";
            this.Size = new System.Drawing.Size(220, 385);
            this.Load += new System.EventHandler(this.usrAddPersCont_Load);
            this.groupBoxAddPersCont.ResumeLayout(false);
            this.groupBoxAddPersCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumePersCont;
        private System.Windows.Forms.Label lblTelPersCont;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.TextBox txtNumePersCont;
        private System.Windows.Forms.TextBox txtTelPersCont;
        private System.Windows.Forms.ComboBox cmbMagazin;
        private System.Windows.Forms.Button btnAddPersCont;
        private System.Windows.Forms.GroupBox groupBoxAddPersCont;


    }
}
