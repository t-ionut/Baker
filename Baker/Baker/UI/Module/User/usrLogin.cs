using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baker.Data;

namespace Baker
{
    public partial class usrLogin : UserControl
    {
        #region - Declarations

        private DS_Baker.app_usersDataTable dt = new DS_Baker.app_usersDataTable();
        private DbProcessing db = new DbProcessing();
        private string sql = string.Empty;

        #endregion

        #region - Constructors

        public usrLogin()
        {
            InitializeComponent();            
        }

        #endregion

        #region - Methods

        /// <summary>
        /// Method for sending login signal to the parent form
        /// </summary>
        /// <param name="e"></param>
        protected virtual void LogIn(EventArgs e)
        {
            EventHandler eh = LogInSignal;

            if (eh != null)
                eh(this, e);
        }

        /// <summary>
        /// Populates the users combobox
        /// </summary>
        /// <param name="adminUser"></param>
        private void FillUsersCombobox()
        {
            try
            {
                dt = new DS_Baker.app_usersDataTable();

                sql = "SELECT * FROM app_users";
                db.LoadDataSetBySQL(dt, sql);

                foreach (DataRow drUser in dt.Rows)
                    cmbUsers.Items.Add(drUser["user_name"].ToString());
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "FillUsersCombobox", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        /// <summary>
        /// Checks if the username and password are valid
        /// </summary>
        private void CheckUser(string user, string pass)
        {
            try
            {
                if (user == string.Empty || pass == string.Empty)
                    CommonMessages.EmptyField();
                else
                {
                    sql = "SELECT * FROM app_users WHERE user_name = '" + user + "'";

                    SaltedHash saltedHash = new SaltedHash(pass);

                    dt = new DS_Baker.app_usersDataTable();
                    db.LoadDataSetBySQL(dt, sql);

                    if (dt.Rows.Count == 0)
                        CommonMessages.WrongUserPass();
                    else
                        foreach (DataRow drUser in dt.Rows)
                            if (user == drUser["user_name"].ToString())
                                if (saltedHash.Verify(drUser["salt"].ToString(), drUser["hash"].ToString(), pass))
                                {
                                    Globals.IsLogged = true;

                                    if (bool.Parse(drUser["isadmin"].ToString()))
                                        Globals.IsAdmin = true;

                                    Globals.UserName = drUser["user_name"].ToString();
                                    Globals.FirstName = drUser["firstname"].ToString();
                                    Globals.LastName = drUser["lastname"].ToString();

                                    LogIn(null);
                                    Logger.WriteSessionStart(drUser["user_name"].ToString(), Globals.IsAdmin);
                                }
                                else
                                    CommonMessages.WrongUserPass();
                            else
                                CommonMessages.WrongUserPass();
                }
            }
            catch(Exception ex)
            {
                Logger.WriteToLog(Name, "CheckUser", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        #endregion

        #region - Events

        public event EventHandler LogInSignal;

        private void usrLogin_Load(object sender, EventArgs e)
        {
            FillUsersCombobox();
            cmbUsers.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUser(cmbUsers.Text, txtPass.Text);
        }

        private void cmbUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckUser(cmbUsers.Text, txtPass.Text);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckUser(cmbUsers.Text, txtPass.Text);
        }

        #endregion        
    }
}
