namespace Baker
{
    partial class usrAddSofer
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
            this.lblNumeSofer = new System.Windows.Forms.Label();
            this.lblCnpSofer = new System.Windows.Forms.Label();
            this.lblAdrSofer = new System.Windows.Forms.Label();
            this.lblTelSofer = new System.Windows.Forms.Label();
            this.txtNumeSofer = new System.Windows.Forms.TextBox();
            this.txtCnpSofer = new System.Windows.Forms.TextBox();
            this.txtAdrSofer = new System.Windows.Forms.TextBox();
            this.txtTelSofer = new System.Windows.Forms.TextBox();
            this.btnAddSofer = new System.Windows.Forms.Button();
            this.groupBoxAddSofer = new System.Windows.Forms.GroupBox();
            this.groupBoxAddSofer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeSofer
            // 
            this.lblNumeSofer.AutoSize = true;
            this.lblNumeSofer.Location = new System.Drawing.Point(3, 20);
            this.lblNumeSofer.Name = "lblNumeSofer";
            this.lblNumeSofer.Size = new System.Drawing.Size(35, 13);
            this.lblNumeSofer.TabIndex = 0;
            this.lblNumeSofer.Text = "Nume";
            // 
            // lblCnpSofer
            // 
            this.lblCnpSofer.AutoSize = true;
            this.lblCnpSofer.Location = new System.Drawing.Point(3, 59);
            this.lblCnpSofer.Name = "lblCnpSofer";
            this.lblCnpSofer.Size = new System.Drawing.Size(35, 13);
            this.lblCnpSofer.TabIndex = 1;
            this.lblCnpSofer.Text = "C.N.P";
            // 
            // lblAdrSofer
            // 
            this.lblAdrSofer.AutoSize = true;
            this.lblAdrSofer.Location = new System.Drawing.Point(3, 98);
            this.lblAdrSofer.Name = "lblAdrSofer";
            this.lblAdrSofer.Size = new System.Drawing.Size(40, 13);
            this.lblAdrSofer.TabIndex = 2;
            this.lblAdrSofer.Text = "Adresa";
            // 
            // lblTelSofer
            // 
            this.lblTelSofer.AutoSize = true;
            this.lblTelSofer.Location = new System.Drawing.Point(3, 177);
            this.lblTelSofer.Name = "lblTelSofer";
            this.lblTelSofer.Size = new System.Drawing.Size(43, 13);
            this.lblTelSofer.TabIndex = 3;
            this.lblTelSofer.Text = "Telefon";
            // 
            // txtNumeSofer
            // 
            this.txtNumeSofer.Location = new System.Drawing.Point(6, 36);
            this.txtNumeSofer.Name = "txtNumeSofer";
            this.txtNumeSofer.Size = new System.Drawing.Size(165, 20);
            this.txtNumeSofer.TabIndex = 4;
            // 
            // txtCnpSofer
            // 
            this.txtCnpSofer.Location = new System.Drawing.Point(6, 75);
            this.txtCnpSofer.Name = "txtCnpSofer";
            this.txtCnpSofer.Size = new System.Drawing.Size(165, 20);
            this.txtCnpSofer.TabIndex = 5;
            // 
            // txtAdrSofer
            // 
            this.txtAdrSofer.Location = new System.Drawing.Point(6, 114);
            this.txtAdrSofer.Multiline = true;
            this.txtAdrSofer.Name = "txtAdrSofer";
            this.txtAdrSofer.Size = new System.Drawing.Size(165, 60);
            this.txtAdrSofer.TabIndex = 6;
            // 
            // txtTelSofer
            // 
            this.txtTelSofer.Location = new System.Drawing.Point(6, 193);
            this.txtTelSofer.Name = "txtTelSofer";
            this.txtTelSofer.Size = new System.Drawing.Size(165, 20);
            this.txtTelSofer.TabIndex = 7;
            // 
            // btnAddSofer
            // 
            this.btnAddSofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSofer.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddSofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSofer.Location = new System.Drawing.Point(37, 267);
            this.btnAddSofer.Name = "btnAddSofer";
            this.btnAddSofer.Size = new System.Drawing.Size(145, 42);
            this.btnAddSofer.TabIndex = 8;
            this.btnAddSofer.Text = "Adauga Sofer";
            this.btnAddSofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSofer.UseVisualStyleBackColor = true;
            this.btnAddSofer.Click += new System.EventHandler(this.btnAddSofer_Click);
            // 
            // groupBoxAddSofer
            // 
            this.groupBoxAddSofer.Controls.Add(this.txtAdrSofer);
            this.groupBoxAddSofer.Controls.Add(this.lblNumeSofer);
            this.groupBoxAddSofer.Controls.Add(this.txtTelSofer);
            this.groupBoxAddSofer.Controls.Add(this.lblCnpSofer);
            this.groupBoxAddSofer.Controls.Add(this.lblAdrSofer);
            this.groupBoxAddSofer.Controls.Add(this.txtCnpSofer);
            this.groupBoxAddSofer.Controls.Add(this.lblTelSofer);
            this.groupBoxAddSofer.Controls.Add(this.txtNumeSofer);
            this.groupBoxAddSofer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxAddSofer.Location = new System.Drawing.Point(18, 23);
            this.groupBoxAddSofer.Name = "groupBoxAddSofer";
            this.groupBoxAddSofer.Size = new System.Drawing.Size(185, 223);
            this.groupBoxAddSofer.TabIndex = 13;
            this.groupBoxAddSofer.TabStop = false;
            this.groupBoxAddSofer.Text = "Date Sofer";
            // 
            // usrAddSofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddSofer);
            this.Controls.Add(this.btnAddSofer);
            this.Name = "usrAddSofer";
            this.Size = new System.Drawing.Size(220, 385);
            this.groupBoxAddSofer.ResumeLayout(false);
            this.groupBoxAddSofer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeSofer;
        private System.Windows.Forms.Label lblCnpSofer;
        private System.Windows.Forms.Label lblAdrSofer;
        private System.Windows.Forms.Label lblTelSofer;
        private System.Windows.Forms.TextBox txtNumeSofer;
        private System.Windows.Forms.TextBox txtCnpSofer;
        private System.Windows.Forms.TextBox txtAdrSofer;
        private System.Windows.Forms.TextBox txtTelSofer;
        private System.Windows.Forms.Button btnAddSofer;
        private System.Windows.Forms.GroupBox groupBoxAddSofer;
    }
}
