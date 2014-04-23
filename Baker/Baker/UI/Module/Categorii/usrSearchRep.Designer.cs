namespace Baker
{
    partial class usrSearchRep
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
            this.groupBoxCriteria = new System.Windows.Forms.GroupBox();
            this.lblMagazin = new System.Windows.Forms.Label();
            this.lblSofer = new System.Windows.Forms.Label();
            this.cmbMagazin = new System.Windows.Forms.ComboBox();
            this.cmbSofer = new System.Windows.Forms.ComboBox();
            this.groupBoxIntervalCalendar = new System.Windows.Forms.GroupBox();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnResetParams = new System.Windows.Forms.Button();
            this.groupBoxCriteria.SuspendLayout();
            this.groupBoxIntervalCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCriteria
            // 
            this.groupBoxCriteria.Controls.Add(this.lblMagazin);
            this.groupBoxCriteria.Controls.Add(this.lblSofer);
            this.groupBoxCriteria.Controls.Add(this.cmbMagazin);
            this.groupBoxCriteria.Controls.Add(this.cmbSofer);
            this.groupBoxCriteria.Location = new System.Drawing.Point(16, 187);
            this.groupBoxCriteria.Name = "groupBoxCriteria";
            this.groupBoxCriteria.Size = new System.Drawing.Size(185, 109);
            this.groupBoxCriteria.TabIndex = 9;
            this.groupBoxCriteria.TabStop = false;
            this.groupBoxCriteria.Text = "Alte Criterii";
            // 
            // lblMagazin
            // 
            this.lblMagazin.AutoSize = true;
            this.lblMagazin.Location = new System.Drawing.Point(6, 56);
            this.lblMagazin.Name = "lblMagazin";
            this.lblMagazin.Size = new System.Drawing.Size(47, 13);
            this.lblMagazin.TabIndex = 4;
            this.lblMagazin.Text = "Magazin";
            // 
            // lblSofer
            // 
            this.lblSofer.AutoSize = true;
            this.lblSofer.Location = new System.Drawing.Point(6, 16);
            this.lblSofer.Name = "lblSofer";
            this.lblSofer.Size = new System.Drawing.Size(32, 13);
            this.lblSofer.TabIndex = 3;
            this.lblSofer.Text = "Sofer";
            // 
            // cmbMagazin
            // 
            this.cmbMagazin.FormattingEnabled = true;
            this.cmbMagazin.Location = new System.Drawing.Point(6, 72);
            this.cmbMagazin.Name = "cmbMagazin";
            this.cmbMagazin.Size = new System.Drawing.Size(165, 21);
            this.cmbMagazin.TabIndex = 1;
            this.cmbMagazin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMagazin_KeyUp);
            // 
            // cmbSofer
            // 
            this.cmbSofer.FormattingEnabled = true;
            this.cmbSofer.Location = new System.Drawing.Point(6, 32);
            this.cmbSofer.Name = "cmbSofer";
            this.cmbSofer.Size = new System.Drawing.Size(165, 21);
            this.cmbSofer.TabIndex = 0;
            this.cmbSofer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSofer_KeyUp);
            // 
            // groupBoxIntervalCalendar
            // 
            this.groupBoxIntervalCalendar.Controls.Add(this.dateTimeStop);
            this.groupBoxIntervalCalendar.Controls.Add(this.dateTimeStart);
            this.groupBoxIntervalCalendar.Controls.Add(this.lblStart);
            this.groupBoxIntervalCalendar.Controls.Add(this.lblEnd);
            this.groupBoxIntervalCalendar.Location = new System.Drawing.Point(16, 16);
            this.groupBoxIntervalCalendar.Name = "groupBoxIntervalCalendar";
            this.groupBoxIntervalCalendar.Size = new System.Drawing.Size(185, 105);
            this.groupBoxIntervalCalendar.TabIndex = 12;
            this.groupBoxIntervalCalendar.TabStop = false;
            this.groupBoxIntervalCalendar.Text = "Interval Calendaristic";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.CustomFormat = "dd - MMM - yyyy";
            this.dateTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStop.Location = new System.Drawing.Point(6, 76);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(165, 20);
            this.dateTimeStop.TabIndex = 1;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "dd - MMM - yyyy";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(6, 33);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(165, 20);
            this.dateTimeStart.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(3, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(69, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Data Inceput";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(3, 60);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(62, 13);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Data Sfarsit";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.Image = global::Baker.Properties.Resources.icoCalendar;
            this.btnSearchByDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByDate.Location = new System.Drawing.Point(36, 131);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(147, 42);
            this.btnSearchByDate.TabIndex = 14;
            this.btnSearchByDate.Text = "Cauta Dupa Data";
            this.btnSearchByDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnResetParams
            // 
            this.btnResetParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetParams.Image = global::Baker.Properties.Resources.icoErase;
            this.btnResetParams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetParams.Location = new System.Drawing.Point(36, 309);
            this.btnResetParams.Name = "btnResetParams";
            this.btnResetParams.Size = new System.Drawing.Size(147, 42);
            this.btnResetParams.TabIndex = 13;
            this.btnResetParams.Text = "Sterge Parametri";
            this.btnResetParams.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetParams.UseVisualStyleBackColor = true;
            this.btnResetParams.Click += new System.EventHandler(this.btnResetParams_Click);
            // 
            // usrSearchRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnResetParams);
            this.Controls.Add(this.groupBoxIntervalCalendar);
            this.Controls.Add(this.groupBoxCriteria);
            this.Name = "usrSearchRep";
            this.Size = new System.Drawing.Size(220, 385);
            this.Load += new System.EventHandler(this.usrSearchRep_Load);
            this.groupBoxCriteria.ResumeLayout(false);
            this.groupBoxCriteria.PerformLayout();
            this.groupBoxIntervalCalendar.ResumeLayout(false);
            this.groupBoxIntervalCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCriteria;
        private System.Windows.Forms.ComboBox cmbMagazin;
        private System.Windows.Forms.ComboBox cmbSofer;
        private System.Windows.Forms.Label lblMagazin;
        private System.Windows.Forms.Label lblSofer;
        private System.Windows.Forms.GroupBox groupBoxIntervalCalendar;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnResetParams;
        private System.Windows.Forms.Button btnSearchByDate;
    }
}
