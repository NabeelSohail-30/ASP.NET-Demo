using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C24_ValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Data Sve into DB
            if (Page.IsValid)
                Response.Redirect("C23_Dynamic Control.aspx");
            //else
            //{
            //    Label3.Text = "NULL data found";
            //    Label3.Visible = true;
            //}
        }
    }
}