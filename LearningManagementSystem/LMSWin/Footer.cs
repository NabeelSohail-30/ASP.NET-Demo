using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSWin.Models;

namespace LMSWin
{
    public partial class Footer : UserControl
    {
        public Footer()
        {
            InitializeComponent();
        }

        private void Footer_Load(object sender, EventArgs e)
        {
            //StLblName.Text = $"Welcome {Global.LoggedUser.UserFullName}({Global.LoggedUser.LoginEmail})  -  Logged in as: {Global.LoggedUser.UserRole.Role}  -  Logged since: {Global.LoggedUser.LoggedDateTime}";
        }
    }
}
