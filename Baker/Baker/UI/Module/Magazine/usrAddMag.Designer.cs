namespace Baker
{
    partial class usrAddMag
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
            this.btnAddMag = new System.Windows.Forms.Button();
            this.txtNumeMag = new System.Windows.Forms.TextBox();
            this.txtTelMag = new System.Windows.Forms.TextBox();
            this.txtAdrMag = new System.Windows.Forms.TextBox();
            this.txtCuiMag = new System.Windows.Forms.TextBox();
            this.lblNumeMag = new System.Windows.Forms.Label();
            this.lblTelMag = new System.Windows.Forms.Label();
            this.lblAdrMag = new System.Windows.Forms.Label();
            this.lblCuiMag = new System.Windows.Forms.Label();
            this.groupBoxAddMag = new System.Windows.Forms.GroupBox();
            this.groupBoxAddMag.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMag
            // 
            this.btnAddMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMag.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddMag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMag.Location = new System.Drawing.Point(37, 286);
            this.btnAddMag.Name = "btnAddMag";
            this.btnAddMag.Size = new System.Drawing.Size(145, 42);
            this.btnAddMag.TabIndex = 35;
            this.btnAddMag.Text = "Adauga Magazin";
            this.btnAddMag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMag.UseVisualStyleBackColor = true;
            this.btnAddMag.Click += new System.EventHandler(this.btnAddMag_Click);
            // 
            // txtNumeMag
            // 
            this.txtNumeMag.Location = new System.Drawing.Point(6, 41);
            this.txtNumeMag.Name = "txtNumeMag";
            this.txtNumeMag.Size = new System.Drawing.Size(165, 20);
            this.txtNumeMag.TabIndex = 31;
            // 
            // txtTelMag
            // 
            this.txtTelMag.Location = new System.Drawing.Point(6, 199);
            this.txtTelMag.Name = "txtTelMag";
            this.txtTelMag.Size = new System.Drawing.Size(165, 20);
            this.txtTelMag.TabIndex = 34;
            // 
            // txtAdrMag
            // 
            this.txtAdrMag.Location = new System.Drawing.Point(6, 119);
            this.txtAdrMag.Multiline = true;
            this.txtAdrMag.Name = "txtAdrMag";
            this.txtAdrMag.Size = new System.Drawing.Size(165, 60);
            this.txtAdrMag.TabIndex = 33;
            // 
            // txtCuiMag
            // 
            this.txtCuiMag.Location = new System.Drawing.Point(6, 80);
            this.txtCuiMag.Name = "txtCuiMag";
            this.txtCuiMag.Size = new System.Drawing.Size(165, 20);
            this.txtCuiMag.TabIndex = 32;
            // 
            // lblNumeMag
            // 
            this.lblNumeMag.AutoSize = true;
            this.lblNumeMag.Location = new System.Drawing.Point(3, 25);
            this.lblNumeMag.Name = "lblNumeMag";
            this.lblNumeMag.Size = new System.Drawing.Size(35, 13);
            this.lblNumeMag.TabIndex = 27;
            this.lblNumeMag.Text = "Nume";
            // 
            // lblTelMag
            // 
            this.lblTelMag.AutoSize = true;
            this.lblTelMag.Location = new System.Drawing.Point(3, 183);
            this.lblTelMag.Name = "lblTelMag";
            this.lblTelMag.Size = new System.Drawing.Size(43, 13);
            this.lblTelMag.TabIndex = 30;
            this.lblTelMag.Text = "Telefon";
            // 
            // lblAdrMag
            // 
            this.lblAdrMag.AutoSize = true;
            this.lblAdrMag.Location = new System.Drawing.Point(3, 103);
            this.lblAdrMag.Name = "lblAdrMag";
            this.lblAdrMag.Size = new System.Drawing.Size(40, 13);
            this.lblAdrMag.TabIndex = 29;
            this.lblAdrMag.Text = "Adresa";
            // 
            // lblCuiMag
            // 
            this.lblCuiMag.AutoSize = true;
            this.lblCuiMag.Location = new System.Drawing.Point(3, 64);
            this.lblCuiMag.Name = "lblCuiMag";
            this.lblCuiMag.Size = new System.Drawing.Size(31, 13);
            this.lblCuiMag.TabIndex = 28;
            this.lblCuiMag.Text = "C.U.I";
            // 
            // groupBoxAddMag
            // 
            this.groupBoxAddMag.Controls.Add(this.txtNumeMag);
            this.groupBoxAddMag.Controls.Add(this.lblCuiMag);
            this.groupBoxAddMag.Controls.Add(this.lblAdrMag);
            this.groupBoxAddMag.Controls.Add(this.txtTelMag);
            this.groupBoxAddMag.Controls.Add(this.lblTelMag);
            this.groupBoxAddMag.Controls.Add(this.txtAdrMag);
            this.groupBoxAddMag.Controls.Add(this.lblNumeMag);
            this.groupBoxAddMag.Controls.Add(this.txtCuiMag);
            this.groupBoxAddMag.Location = new System.Drawing.Point(17, 31);
            this.groupBoxAddMag.Name = "groupBoxAddMag";
            this.groupBoxAddMag.Size = new System.Drawing.Size(185, 238);
            this.groupBoxAddMag.TabIndex = 36;
            this.groupBoxAddMag.TabStop = false;
            this.groupBoxAddMag.Text = "Date Magazin Nou";
            // 
            // usrAddMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddMag);
            this.Controls.Add(this.btnAddMag);
            this.Name = "usrAddMag";
            this.Size = new System.Drawing.Size(220, 385);
            this.groupBoxAddMag.ResumeLayout(false);
            this.groupBoxAddMag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMag;
        private System.Windows.Forms.TextBox txtNumeMag;
        private System.Windows.Forms.TextBox txtTelMag;
        private System.Windows.Forms.TextBox txtAdrMag;
        private System.Windows.Forms.TextBox txtCuiMag;
        private System.Windows.Forms.Label lblNumeMag;
        private System.Windows.Forms.Label lblTelMag;
        private System.Windows.Forms.Label lblAdrMag;
        private System.Windows.Forms.Label lblCuiMag;
        private System.Windows.Forms.GroupBox groupBoxAddMag;

    }
}
