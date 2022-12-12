using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C03StateTypes_Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MyName"] != null)
            {
                TxtName.Text = Session["MyName"].ToString();
            }

            if (ViewState["MyName02"] != null)
            {
                TextBox1.Text = ViewState["MyName02"].ToString();
            }
        }
    }
}