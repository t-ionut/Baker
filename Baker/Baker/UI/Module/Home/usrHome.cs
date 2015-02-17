using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker
{
    public partial class usrHome : UserControl
    {
        public usrHome()
        {
            InitializeComponent();
        }

        public usrHome(string firstname, string lastname)
        {
            InitializeComponent();

            lblUsername.Text = firstname + "  " + lastname;
            lblLogDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy  HH:mm");
        }

        private void usrHome_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
