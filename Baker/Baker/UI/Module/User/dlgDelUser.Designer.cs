namespace Baker
{
    partial class dlgDelUser
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
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.btnDelUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(489, 300);
            this.dataGridUsers.TabIndex = 0;
            // 
            // btnDelUsers
            // 
            this.btnDelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUsers.Image = global::Baker.Properties.Resources.icoDeleteKey;
            this.btnDelUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUsers.Location = new System.Drawing.Point(357, 319);
            this.btnDelUsers.Name = "btnDelUsers";
            this.btnDelUsers.Size = new System.Drawing.Size(145, 42);
            this.btnDelUsers.TabIndex = 1;
            this.btnDelUsers.Text = "Sterge User";
            this.btnDelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelUsers.UseVisualStyleBackColor = true;
            this.btnDelUsers.Click += new System.EventHandler(this.btnDelUsers_Click);
            // 
            // dlgDelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 373);
            this.Controls.Add(this.btnDelUsers);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "dlgDelUser";
            this.Text = "Sterge User";
            this.Load += new System.EventHandler(this.dlgDelUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnDelUsers;
    }
}