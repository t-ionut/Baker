using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker
{
    public static class CommonMessages
    {
        #region - Methods

        /// <summary>
        /// Error message showing up when login information is incomplete
        /// </summary>
        public static void EmptyField()
        {
            MessageBox.Show("Toate campurile trebuie completate !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Error message showing up when the username or password is incorrect
        /// </summary>
        public static void WrongUserPass()
        {
            MessageBox.Show("Username sau parola gresita ! Incercati din nou !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Error message showing up when no user is logged into the application
        /// </summary>
        public static void NotLoggedMessage()
        {
            MessageBox.Show("Va rugam sa va logati!", "Acces nepermis!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Error message showing up when quantity is not in a valid format
        /// </summary>
        /// <param name="name"></param>
        public static void InvalidValueOn(string name)
        {
            MessageBox.Show("Cantitate nevalida la " + name + " !", "Baker");
        }

        /// <summary>
        /// Success custom message after successful operation
        /// </summary>
        /// <param name="customMessage"></param>
        public static void SuccessMessage(string customMessage)
        {
            MessageBox.Show(customMessage, "Baker");
        }

        /// <summary>
        /// Error message in case of unsuccessful operation
        /// </summary>
        public static void ErrorMessage()
        {
            MessageBox.Show("Operatie nereusita !\nVa rugam verificati si incercati din nou !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Error message in case of unsuccessful operation
        /// </summary>
        public static void ErrorMessage(string customMessage)
        {
            MessageBox.Show(customMessage, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
