using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baker
{
    public static class Globals
    {
        #region - Declarations

        private static bool _isLogged = false;
        private static bool _isAdmin = false;
        private static string username;
        private static string firstname;
        private static string lastname;

        public static bool IsLogged 
        {
            get { return _isLogged; }
            set { _isLogged = value; }
        }

        public static bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public static string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public static string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public static string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        #endregion
    }
}
