namespace Baker
{
    partial class usrAddProd
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
            this.txtPretFTva = new System.Windows.Forms.TextBox();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.txtNumeProd = new System.Windows.Forms.TextBox();
            this.lblTva = new System.Windows.Forms.Label();
            this.lblPretFTva = new System.Windows.Forms.Label();
            this.lblCantProd = new System.Windows.Forms.Label();
            this.lblNumeProd = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.cmbTipProd = new System.Windows.Forms.ComboBox();
            this.lblTipProd = new System.Windows.Forms.Label();
            this.chkComercializat = new System.Windows.Forms.CheckBox();
            this.groupBoxAddProd = new System.Windows.Forms.GroupBox();
            this.txtTva = new System.Windows.Forms.TextBox();
            this.groupBoxAddProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPretFTva
            // 
            this.txtPretFTva.Location = new System.Drawing.Point(6, 151);
            this.txtPretFTva.Name = "txtPretFTva";
            this.txtPretFTva.Size = new System.Drawing.Size(165, 20);
            this.txtPretFTva.TabIndex = 15;
            // 
            // txtCantProd
            // 
            this.txtCantProd.Location = new System.Drawing.Point(6, 73);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(165, 20);
            this.txtCantProd.TabIndex = 14;
            // 
            // txtNumeProd
            // 
            this.txtNumeProd.Location = new System.Drawing.Point(6, 34);
            this.txtNumeProd.Name = "txtNumeProd";
            this.txtNumeProd.Size = new System.Drawing.Size(165, 20);
            this.txtNumeProd.TabIndex = 13;
            // 
            // lblTva
            // 
            this.lblTva.AutoSize = true;
            this.lblTva.Location = new System.Drawing.Point(3, 174);
            this.lblTva.Name = "lblTva";
            this.lblTva.Size = new System.Drawing.Size(57, 13);
            this.lblTva.TabIndex = 12;
            this.lblTva.Text = "T.V.A ( % )";
            // 
            // lblPretFTva
            // 
            this.lblPretFTva.AutoSize = true;
            this.lblPretFTva.Location = new System.Drawing.Point(3, 135);
            this.lblPretFTva.Name = "lblPretFTva";
            this.lblPretFTva.Size = new System.Drawing.Size(83, 13);
            this.lblPretFTva.TabIndex = 11;
            this.lblPretFTva.Text = "Pret ( fara TVA )";
            // 
            // lblCantProd
            // 
            this.lblCantProd.AutoSize = true;
            this.lblCantProd.Location = new System.Drawing.Point(3, 57);
            this.lblCantProd.Name = "lblCantProd";
            this.lblCantProd.Size = new System.Drawing.Size(93, 13);
            this.lblCantProd.TabIndex = 10;
            this.lblCantProd.Text = "Cantitate ( grame )";
            // 
            // lblNumeProd
            // 
            this.lblNumeProd.AutoSize = true;
            this.lblNumeProd.Location = new System.Drawing.Point(3, 18);
            this.lblNumeProd.Name = "lblNumeProd";
            this.lblNumeProd.Size = new System.Drawing.Size(35, 13);
            this.lblNumeProd.TabIndex = 9;
            this.lblNumeProd.Text = "Nume";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.Location = new System.Drawing.Point(37, 282);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(145, 42);
            this.btnAddProd.TabIndex = 17;
            this.btnAddProd.Text = "Adauga Produs";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // cmbTipProd
            // 
            this.cmbTipProd.FormattingEnabled = true;
            this.cmbTipProd.Location = new System.Drawing.Point(6, 112);
            this.cmbTipProd.Name = "cmbTipProd";
            this.cmbTipProd.Size = new System.Drawing.Size(165, 21);
            this.cmbTipProd.TabIndex = 18;
            // 
            // lblTipProd
            // 
            this.lblTipProd.AutoSize = true;
            this.lblTipProd.Location = new System.Drawing.Point(3, 96);
            this.lblTipProd.Name = "lblTipProd";
            this.lblTipProd.Size = new System.Drawing.Size(58, 13);
            this.lblTipProd.TabIndex = 19;
            this.lblTipProd.Text = "Tip Produs";
            // 
            // chkComercializat
            // 
            this.chkComercializat.AutoSize = true;
            this.chkComercializat.Checked = true;
            this.chkComercializat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComercializat.Location = new System.Drawing.Point(2, 218);
            this.chkComercializat.Name = "chkComercializat";
            this.chkComercializat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkComercializat.Size = new System.Drawing.Size(88, 17);
            this.chkComercializat.TabIndex = 21;
            this.chkComercializat.Text = "Comercializat";
            this.chkComercializat.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddProd
            // 
            this.groupBoxAddProd.Controls.Add(this.txtTva);
            this.groupBoxAddProd.Controls.Add(this.chkComercializat);
            this.groupBoxAddProd.Controls.Add(this.lblNumeProd);
            this.groupBoxAddProd.Controls.Add(this.lblCantProd);
            this.groupBoxAddProd.Controls.Add(this.lblTipProd);
            this.groupBoxAddProd.Controls.Add(this.lblPretFTva);
            this.groupBoxAddProd.Controls.Add(this.cmbTipProd);
            this.groupBoxAddProd.Controls.Add(this.lblTva);
            this.groupBoxAddProd.Controls.Add(this.txtNumeProd);
            this.groupBoxAddProd.Controls.Add(this.txtPretFTva);
            this.groupBoxAddProd.Controls.Add(this.txtCantProd);
            this.groupBoxAddProd.Location = new System.Drawing.Point(17, 23);
            this.groupBoxAddProd.Name = "groupBoxAddProd";
            this.groupBoxAddProd.Size = new System.Drawing.Size(185, 243);
            this.groupBoxAddProd.TabIndex = 22;
            this.groupBoxAddProd.TabStop = false;
            this.groupBoxAddProd.Text = "Produs Nou";
            // 
            // txtTva
            // 
            this.txtTva.Location = new System.Drawing.Point(6, 190);
            this.txtTva.Name = "txtTva";
            this.txtTva.Size = new System.Drawing.Size(165, 20);
            this.txtTva.TabIndex = 22;
            // 
            // usrAddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddProd);
            this.Controls.Add(this.btnAddProd);
            this.Name = "usrAddProd";
            this.Size = new System.Drawing.Size(220, 385);
            this.Load += new System.EventHandler(this.usrAddProd_Load);
            this.groupBoxAddProd.ResumeLayout(false);
            this.groupBoxAddProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.TextBox txtPretFTva;
        private System.Windows.Forms.TextBox txtCantProd;
        private System.Windows.Forms.TextBox txtNumeProd;
        private System.Windows.Forms.Label lblTva;
        private System.Windows.Forms.Label lblPretFTva;
        private System.Windows.Forms.Label lblCantProd;
        private System.Windows.Forms.Label lblNumeProd;
        private System.Windows.Forms.ComboBox cmbTipProd;
        private System.Windows.Forms.Label lblTipProd;
        private System.Windows.Forms.CheckBox chkComercializat;
        private System.Windows.Forms.GroupBox groupBoxAddProd;
        private System.Windows.Forms.TextBox txtTva;
    }
}
