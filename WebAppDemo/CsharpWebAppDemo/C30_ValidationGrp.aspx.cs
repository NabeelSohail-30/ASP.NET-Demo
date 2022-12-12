using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C30_ValidationGrp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Response.Redirect("C23_Dynamic Control.aspx");
        }
    }
}