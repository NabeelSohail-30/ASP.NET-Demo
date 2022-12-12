using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMSWebApp
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblUserDetail.Text = $"Welcome {Session["sUserName"].ToString()}({Session["sLoginEmail"].ToString()}) to Library Management System - Logged in as : {Session["sUserRole"].ToString()}";
            LblDateTime.Text = $"Logged in Since : {Session["sLoggedDt"].ToString()}";
        }
    }
}