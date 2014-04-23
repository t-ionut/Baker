namespace Baker.UI.Module.Common
{
    partial class MenuBar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCloseGrid = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.flowLayoutPanel1.Controls.Add(this.btnCloseGrid);
            this.flowLayoutPanel1.Controls.Add(this.btnExportGrid);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 31);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(408, 31);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCloseGrid;
        private System.Windows.Forms.Button btnExportGrid;
    }
}
