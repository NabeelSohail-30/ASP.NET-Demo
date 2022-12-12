using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C03StateTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["MyName02"] != null)
            {
            TextBox1.Text = ViewState["MyName02"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["MyName"] = TxtName.Text;
            Response.Redirect("C03StateTypes_Session.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["MyName02"] = TxtName.Text;
        }
    }
}