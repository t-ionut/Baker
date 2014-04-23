using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baker.Data;

namespace Baker
{
    public partial class dlgDelUser : Form
    {
        DS_Baker.app_usersDataTable dt_Users = new DS_Baker.app_usersDataTable();
        DbProcessing db = new DbProcessing();
        DataTable dt = new DataTable();
        string sql = string.Empty;

        public dlgDelUser()
        {
            InitializeComponent();
        }

        private void dlgDelUser_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT id_user, "
                           + "user_name, "
                           + "firstname, "
                           + "lastname, "
                           + "isadmin "
                    + "FROM app_users "
                    + "WHERE user_name != '"
                    + Globals.UserName + "'";

                db.LoadDataSetBySQL(dt, sql);

                dataGridUsers.DataSource = dt;

                foreach (DataGridViewColumn col in dataGridUsers.Columns)
                {
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn(false);
                column.Name = "sterge";
                column.HeaderText = "sterge";
                dataGridUsers.Columns.Insert(dataGridUsers.Columns.Count, column);

                foreach (DataGridViewRow dgRow in dataGridUsers.Rows)
                    dgRow.Cells["sterge"].Value = false;
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "dlgDelUser_Load", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        private void btnDelUsers_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> deleteUsers = new List<string>();

                foreach (DataGridViewRow dgRow in dataGridUsers.Rows)
                    if ((bool)dgRow.Cells["sterge"].Value)
                        deleteUsers.Add(dgRow.Cells["id_user"].Value.ToString());

                if (deleteUsers.Count == 0)
                    CommonMessages.ErrorMessage();
                else
                {
                    foreach (string id in deleteUsers)
                    {
                        sql = "DELETE FROM app_users WHERE id_user = " + id;
                        db.ExecuteSqlCommand(sql);
                    }

                    CommonMessages.SuccessMessage("Userii au fost stersi din baza de date !");
                    dlgDelUser_Load(this, null);
                }
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "btnDelUsers_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
    }
}
