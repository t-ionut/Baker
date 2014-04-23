namespace Baker
{
    partial class frmProduseDistribuite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProds = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPatiserie = new System.Windows.Forms.Button();
            this.btnCozonac = new System.Windows.Forms.Button();
            this.btnDiverse = new System.Windows.Forms.Button();
            this.btnPaine = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProds)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProds
            // 
            this.dgProds.AllowUserToAddRows = false;
            this.dgProds.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgProds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProds.Location = new System.Drawing.Point(0, 0);
            this.dgProds.Name = "dgProds";
            this.dgProds.Size = new System.Drawing.Size(942, 419);
            this.dgProds.TabIndex = 0;
            //this.dgProds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgProds_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(5, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgProds);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(944, 476);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(942, 49);
            this.splitContainer1.SplitterDistance = 537;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAll);
            this.flowLayoutPanel2.Controls.Add(this.btnPatiserie);
            this.flowLayoutPanel2.Controls.Add(this.btnCozonac);
            this.flowLayoutPanel2.Controls.Add(this.btnDiverse);
            this.flowLayoutPanel2.Controls.Add(this.btnPaine);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(537, 49);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Image = global::Baker.Properties.Resources.icoAll;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.Location = new System.Drawing.Point(3, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(101, 40);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Toate";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPatiserie
            // 
            this.btnPatiserie.AutoSize = true;
            this.btnPatiserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatiserie.Image = global::Baker.Properties.Resources.icoDonut;
            this.btnPatiserie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatiserie.Location = new System.Drawing.Point(110, 3);
            this.btnPatiserie.Name = "btnPatiserie";
            this.btnPatiserie.Size = new System.Drawing.Size(101, 40);
            this.btnPatiserie.TabIndex = 2;
            this.btnPatiserie.Text = "Patiserie";
            this.btnPatiserie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatiserie.UseVisualStyleBackColor = true;
            this.btnPatiserie.Click += new System.EventHandler(this.btnPatiserie_Click);
            // 
            // btnCozonac
            // 
            this.btnCozonac.AutoSize = true;
            this.btnCozonac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCozonac.Image = global::Baker.Properties.Resources.icoCozonac;
            this.btnCozonac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCozonac.Location = new System.Drawing.Point(217, 3);
            this.btnCozonac.Name = "btnCozonac";
            this.btnCozonac.Size = new System.Drawing.Size(101, 40);
            this.btnCozonac.TabIndex = 1;
            this.btnCozonac.Text = "Cozonac";
            this.btnCozonac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCozonac.UseVisualStyleBackColor = true;
            this.btnCozonac.Click += new System.EventHandler(this.btnCozonac_Click);
            // 
            // btnDiverse
            // 
            this.btnDiverse.AutoSize = true;
            this.btnDiverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiverse.Image = global::Baker.Properties.Resources.icoQuestion;
            this.btnDiverse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiverse.Location = new System.Drawing.Point(324, 3);
            this.btnDiverse.Name = "btnDiverse";
            this.btnDiverse.Size = new System.Drawing.Size(101, 40);
            this.btnDiverse.TabIndex = 3;
            this.btnDiverse.Text = "Diverse";
            this.btnDiverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiverse.UseVisualStyleBackColor = true;
            this.btnDiverse.Click += new System.EventHandler(this.btnDiverse_Click);
            // 
            // btnPaine
            // 
            this.btnPaine.AutoSize = true;
            this.btnPaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaine.Image = global::Baker.Properties.Resources.icoToast;
            this.btnPaine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaine.Location = new System.Drawing.Point(431, 3);
            this.btnPaine.Name = "btnPaine";
            this.btnPaine.Size = new System.Drawing.Size(101, 40);
            this.btnPaine.TabIndex = 4;
            this.btnPaine.Text = "Paine";
            this.btnPaine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaine.UseVisualStyleBackColor = true;
            this.btnPaine.Click += new System.EventHandler(this.btnPaine_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddProd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 49);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddProd
            // 
            this.btnAddProd.AutoSize = true;
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Image = global::Baker.Properties.Resources.btnAddPng;
            this.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProd.Location = new System.Drawing.Point(297, 3);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(101, 40);
            this.btnAddProd.TabIndex = 5;
            this.btnAddProd.Text = "Adauga";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // frmProduseDistribuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 486);
            this.Controls.Add(this.splitContainer2);
            this.Name = "frmProduseDistribuite";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Produse Vandute";
            this.Load += new System.EventHandler(this.frmProduseDistribuite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProds)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProds;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnPaine;
        private System.Windows.Forms.Button btnCozonac;
        private System.Windows.Forms.Button btnPatiserie;
        private System.Windows.Forms.Button btnDiverse;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}