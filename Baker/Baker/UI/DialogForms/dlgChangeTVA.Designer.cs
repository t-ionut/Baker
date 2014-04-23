namespace Baker
{
    partial class dlgChangeTVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgChangeTVA));
            this.lblOldTva = new System.Windows.Forms.Label();
            this.lblNewTva = new System.Windows.Forms.Label();
            this.txtOldTva = new System.Windows.Forms.TextBox();
            this.txtNewTva = new System.Windows.Forms.TextBox();
            this.btnChangeTva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOldTva
            // 
            this.lblOldTva.AutoSize = true;
            this.lblOldTva.Location = new System.Drawing.Point(12, 9);
            this.lblOldTva.Name = "lblOldTva";
            this.lblOldTva.Size = new System.Drawing.Size(64, 13);
            this.lblOldTva.TabIndex = 0;
            this.lblOldTva.Text = "T.V.A Vechi";
            // 
            // lblNewTva
            // 
            this.lblNewTva.AutoSize = true;
            this.lblNewTva.Location = new System.Drawing.Point(12, 35);
            this.lblNewTva.Name = "lblNewTva";
            this.lblNewTva.Size = new System.Drawing.Size(57, 13);
            this.lblNewTva.TabIndex = 1;
            this.lblNewTva.Text = "T.V.A Nou";
            // 
            // txtOldTva
            // 
            this.txtOldTva.Location = new System.Drawing.Point(82, 6);
            this.txtOldTva.Name = "txtOldTva";
            this.txtOldTva.ReadOnly = true;
            this.txtOldTva.Size = new System.Drawing.Size(81, 20);
            this.txtOldTva.TabIndex = 2;
            // 
            // txtNewTva
            // 
            this.txtNewTva.Location = new System.Drawing.Point(82, 32);
            this.txtNewTva.Name = "txtNewTva";
            this.txtNewTva.Size = new System.Drawing.Size(81, 20);
            this.txtNewTva.TabIndex = 3;
            // 
            // btnChangeTva
            // 
            this.btnChangeTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTva.Location = new System.Drawing.Point(188, 6);
            this.btnChangeTva.Name = "btnChangeTva";
            this.btnChangeTva.Size = new System.Drawing.Size(100, 46);
            this.btnChangeTva.TabIndex = 4;
            this.btnChangeTva.Text = "Schimba T.V.A.";
            this.btnChangeTva.UseVisualStyleBackColor = true;
            this.btnChangeTva.Click += new System.EventHandler(this.btnChangeTva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "%";
            // 
            // dlgChangeTVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 61);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeTva);
            this.Controls.Add(this.txtNewTva);
            this.Controls.Add(this.txtOldTva);
            this.Controls.Add(this.lblNewTva);
            this.Controls.Add(this.lblOldTva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dlgChangeTVA";
            this.Text = "Schimba TVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldTva;
        private System.Windows.Forms.Label lblNewTva;
        private System.Windows.Forms.TextBox txtOldTva;
        private System.Windows.Forms.TextBox txtNewTva;
        private System.Windows.Forms.Button btnChangeTva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}