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
    public partial class dlgRegUser : Form
    {
        #region - Declarations

        DbProcessing db = new DbProcessing();
        string sql = string.Empty;

        #endregion

        #region - Constructor

        public dlgRegUser()
        {
            InitializeComponent();
        }

        #endregion

        #region - Events

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                db.LoadDataSetBySQL(dt, "SELECT user_name FROM app_users WHERE user_name = '" + txtUsername.Text + "'");

                if (dt.Rows.Count == 0)
                    if (txtPassword.Text == txtRepeatPassword.Text)
                    {
                        SaltedHash sh = new SaltedHash(txtPassword.Text);

                        sql = "INSERT INTO app_users ("
                            + "user_name, "
                            + "salt, "
                            + "hash, "
                            + "firstname, "
                            + "lastname, "
                            + "isadmin" + ")"
                            + "VALUES ('"
                            + txtUsername.Text + "', '"
                            + sh.Salt.ToString() + "', '"
                            + sh.Hash.ToString() + "', '"
                            + txtFirstName.Text + "', '"
                            + txtLastName.Text + "', '"
                            + checkBoxIsAdmin.Checked.ToString() + "')";

                        db.ExecuteSqlCommand(sql);

                        CommonMessages.SuccessMessage("Inregistrarea a avut succes !");
                        this.Close();
                    }
                    else
                    {
                        CommonMessages.ErrorMessage("Parolele nu sunt identice !");
                    }
                else
                    CommonMessages.ErrorMessage("Exista deja un user cu acest nume !");
            }
            catch (Exception ex)
            {
                Logger.WriteToLog(Name, "btnRegUser_Click", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion        
    }
}
