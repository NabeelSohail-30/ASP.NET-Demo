using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C34_SessionRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadSession();
        }

        private void ReadSession()
        {
            if(Session["sEmail"] != null)
            {
                txtEmail.Text = Session["sEmail"].ToString();
            }

            if (Session["sName"] != null)
            {
                txtName.Text = Session["sName"].ToString();
            }
        }
    }
}