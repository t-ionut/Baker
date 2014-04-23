namespace Baker
{
    partial class dlgProducts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.applivrariprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Baker = new Baker.Data.DS_Baker();
            this.idraportlivrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numesoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numemagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.returDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datalivrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaincasataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramajprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretprodftvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvaprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretprodctvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitatelivrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applivrariprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Baker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idraportlivrareDataGridViewTextBoxColumn,
            this.idsoferDataGridViewTextBoxColumn,
            this.numesoferDataGridViewTextBoxColumn,
            this.idmagDataGridViewTextBoxColumn,
            this.numemagDataGridViewCheckBoxColumn,
            this.turaDataGridViewCheckBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.returDataGridViewTextBoxColumn,
            this.datalivrareDataGridViewTextBoxColumn,
            this.sumaincasataDataGridViewTextBoxColumn,
            this.idprodDataGridViewTextBoxColumn,
            this.numeprodDataGridViewTextBoxColumn,
            this.gramajprodDataGridViewTextBoxColumn,
            this.tipprodDataGridViewTextBoxColumn,
            this.pretprodftvaDataGridViewTextBoxColumn,
            this.tvaprodDataGridViewTextBoxColumn,
            this.pretprodctvaDataGridViewTextBoxColumn,
            this.cantitatelivrataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applivrariprodBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // applivrariprodBindingSource
            // 
            this.applivrariprodBindingSource.DataMember = "app_livrari_prod";
            this.applivrariprodBindingSource.DataSource = this.dS_Baker;
            // 
            // dS_Baker
            // 
            this.dS_Baker.DataSetName = "DS_Baker";
            this.dS_Baker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idraportlivrareDataGridViewTextBoxColumn
            // 
            this.idraportlivrareDataGridViewTextBoxColumn.DataPropertyName = "id_raport_livrare";
            this.idraportlivrareDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idraportlivrareDataGridViewTextBoxColumn.Name = "idraportlivrareDataGridViewTextBoxColumn";
            this.idraportlivrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idraportlivrareDataGridViewTextBoxColumn.Width = 43;
            // 
            // idsoferDataGridViewTextBoxColumn
            // 
            this.idsoferDataGridViewTextBoxColumn.DataPropertyName = "id_sofer";
            this.idsoferDataGridViewTextBoxColumn.HeaderText = "id_sofer";
            this.idsoferDataGridViewTextBoxColumn.Name = "idsoferDataGridViewTextBoxColumn";
            this.idsoferDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsoferDataGridViewTextBoxColumn.Visible = false;
            this.idsoferDataGridViewTextBoxColumn.Width = 69;
            // 
            // numesoferDataGridViewTextBoxColumn
            // 
            this.numesoferDataGridViewTextBoxColumn.DataPropertyName = "nume_sofer";
            this.numesoferDataGridViewTextBoxColumn.HeaderText = "nume_sofer";
            this.numesoferDataGridViewTextBoxColumn.Name = "numesoferDataGridViewTextBoxColumn";
            this.numesoferDataGridViewTextBoxColumn.ReadOnly = true;
            this.numesoferDataGridViewTextBoxColumn.Visible = false;
            this.numesoferDataGridViewTextBoxColumn.Width = 87;
            // 
            // idmagDataGridViewTextBoxColumn
            // 
            this.idmagDataGridViewTextBoxColumn.DataPropertyName = "id_mag";
            this.idmagDataGridViewTextBoxColumn.HeaderText = "id_mag";
            this.idmagDataGridViewTextBoxColumn.Name = "idmagDataGridViewTextBoxColumn";
            this.idmagDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmagDataGridViewTextBoxColumn.Visible = false;
            this.idmagDataGridViewTextBoxColumn.Width = 66;
            // 
            // numemagDataGridViewCheckBoxColumn
            // 
            this.numemagDataGridViewCheckBoxColumn.DataPropertyName = "nume_mag";
            this.numemagDataGridViewCheckBoxColumn.HeaderText = "nume_mag";
            this.numemagDataGridViewCheckBoxColumn.Name = "numemagDataGridViewCheckBoxColumn";
            this.numemagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.numemagDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numemagDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numemagDataGridViewCheckBoxColumn.Width = 65;
            // 
            // turaDataGridViewCheckBoxColumn
            // 
            this.turaDataGridViewCheckBoxColumn.DataPropertyName = "tura";
            this.turaDataGridViewCheckBoxColumn.HeaderText = "tura";
            this.turaDataGridViewCheckBoxColumn.Name = "turaDataGridViewCheckBoxColumn";
            this.turaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.turaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.turaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.turaDataGridViewCheckBoxColumn.Visible = false;
            this.turaDataGridViewCheckBoxColumn.Width = 31;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "tur";
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            this.turDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.turDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.turDataGridViewTextBoxColumn.Visible = false;
            this.turDataGridViewTextBoxColumn.Width = 44;
            // 
            // returDataGridViewTextBoxColumn
            // 
            this.returDataGridViewTextBoxColumn.DataPropertyName = "retur";
            this.returDataGridViewTextBoxColumn.HeaderText = "retur";
            this.returDataGridViewTextBoxColumn.Name = "returDataGridViewTextBoxColumn";
            this.returDataGridViewTextBoxColumn.ReadOnly = true;
            this.returDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.returDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.returDataGridViewTextBoxColumn.Visible = false;
            this.returDataGridViewTextBoxColumn.Width = 53;
            // 
            // datalivrareDataGridViewTextBoxColumn
            // 
            this.datalivrareDataGridViewTextBoxColumn.DataPropertyName = "data_livrare";
            this.datalivrareDataGridViewTextBoxColumn.HeaderText = "data_livrare";
            this.datalivrareDataGridViewTextBoxColumn.Name = "datalivrareDataGridViewTextBoxColumn";
            this.datalivrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.datalivrareDataGridViewTextBoxColumn.Visible = false;
            this.datalivrareDataGridViewTextBoxColumn.Width = 87;
            // 
            // sumaincasataDataGridViewTextBoxColumn
            // 
            this.sumaincasataDataGridViewTextBoxColumn.DataPropertyName = "suma_incasata";
            this.sumaincasataDataGridViewTextBoxColumn.HeaderText = "suma_incasata";
            this.sumaincasataDataGridViewTextBoxColumn.Name = "sumaincasataDataGridViewTextBoxColumn";
            this.sumaincasataDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumaincasataDataGridViewTextBoxColumn.Visible = false;
            this.sumaincasataDataGridViewTextBoxColumn.Width = 103;
            // 
            // idprodDataGridViewTextBoxColumn
            // 
            this.idprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod";
            this.idprodDataGridViewTextBoxColumn.HeaderText = "id_prod";
            this.idprodDataGridViewTextBoxColumn.Name = "idprodDataGridViewTextBoxColumn";
            this.idprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodDataGridViewTextBoxColumn.Visible = false;
            this.idprodDataGridViewTextBoxColumn.Width = 67;
            // 
            // numeprodDataGridViewTextBoxColumn
            // 
            this.numeprodDataGridViewTextBoxColumn.DataPropertyName = "nume_prod";
            this.numeprodDataGridViewTextBoxColumn.HeaderText = "nume_prod";
            this.numeprodDataGridViewTextBoxColumn.Name = "numeprodDataGridViewTextBoxColumn";
            this.numeprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeprodDataGridViewTextBoxColumn.Width = 85;
            // 
            // gramajprodDataGridViewTextBoxColumn
            // 
            this.gramajprodDataGridViewTextBoxColumn.DataPropertyName = "gramaj_prod";
            this.gramajprodDataGridViewTextBoxColumn.HeaderText = "gramaj_prod";
            this.gramajprodDataGridViewTextBoxColumn.Name = "gramajprodDataGridViewTextBoxColumn";
            this.gramajprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.gramajprodDataGridViewTextBoxColumn.Width = 90;
            // 
            // tipprodDataGridViewTextBoxColumn
            // 
            this.tipprodDataGridViewTextBoxColumn.DataPropertyName = "tip_prod";
            this.tipprodDataGridViewTextBoxColumn.HeaderText = "tip_prod";
            this.tipprodDataGridViewTextBoxColumn.Name = "tipprodDataGridViewTextBoxColumn";
            this.tipprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipprodDataGridViewTextBoxColumn.Width = 70;
            // 
            // pretprodftvaDataGridViewTextBoxColumn
            // 
            this.pretprodftvaDataGridViewTextBoxColumn.DataPropertyName = "pret_prod_ftva";
            this.pretprodftvaDataGridViewTextBoxColumn.HeaderText = "pret_prod_ftva";
            this.pretprodftvaDataGridViewTextBoxColumn.Name = "pretprodftvaDataGridViewTextBoxColumn";
            this.pretprodftvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretprodftvaDataGridViewTextBoxColumn.Visible = false;
            this.pretprodftvaDataGridViewTextBoxColumn.Width = 101;
            // 
            // tvaprodDataGridViewTextBoxColumn
            // 
            this.tvaprodDataGridViewTextBoxColumn.DataPropertyName = "tva_prod";
            this.tvaprodDataGridViewTextBoxColumn.HeaderText = "tva_prod";
            this.tvaprodDataGridViewTextBoxColumn.Name = "tvaprodDataGridViewTextBoxColumn";
            this.tvaprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.tvaprodDataGridViewTextBoxColumn.Visible = false;
            this.tvaprodDataGridViewTextBoxColumn.Width = 74;
            // 
            // pretprodctvaDataGridViewTextBoxColumn
            // 
            this.pretprodctvaDataGridViewTextBoxColumn.DataPropertyName = "pret_prod_ctva";
            this.pretprodctvaDataGridViewTextBoxColumn.HeaderText = "pret_prod_ctva";
            this.pretprodctvaDataGridViewTextBoxColumn.Name = "pretprodctvaDataGridViewTextBoxColumn";
            this.pretprodctvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretprodctvaDataGridViewTextBoxColumn.Width = 104;
            // 
            // cantitatelivrataDataGridViewTextBoxColumn
            // 
            this.cantitatelivrataDataGridViewTextBoxColumn.DataPropertyName = "cantitate_livrata";
            this.cantitatelivrataDataGridViewTextBoxColumn.HeaderText = "cantitate_livrata";
            this.cantitatelivrataDataGridViewTextBoxColumn.Name = "cantitatelivrataDataGridViewTextBoxColumn";
            this.cantitatelivrataDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitatelivrataDataGridViewTextBoxColumn.Width = 107;
            // 
            // dlgProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 417);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dlgProducts";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Produse Livrate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applivrariprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Baker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource applivrariprodBindingSource;
        private Data.DS_Baker dS_Baker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idraportlivrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numesoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numemagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn returDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalivrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaincasataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramajprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretprodftvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvaprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretprodctvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitatelivrataDataGridViewTextBoxColumn;
    }
}