using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C35_ApplicationStateRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadAppState();
        }

        private void ReadAppState()
        {
            if (Application["asEmail"] != null)
            {
                txtEmail.Text = Application["asEmail"].ToString();
            }

            if (Application["asName"] != null)
            {
                txtName.Text = Application["asName"].ToString();
            }
        }
    }
}