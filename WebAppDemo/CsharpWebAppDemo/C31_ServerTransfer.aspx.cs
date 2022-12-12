using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C31_ServerTransfer : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("C31_ServerTransfer_2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("C31_ServerTransfer_2.aspx",true);

            //This part of code will not execute
            Label1.Text = "Web Form 2 processing finished.";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Execute("C31_ServerTransfer_2.aspx",true);

            //ASP.net will process the above statement and control will return here to continue...
            Label1.Text = "Web Form 2 processing finished.";

        }

        public string Email
        {
            get { return txtEmail.Text; }
        }

        public string Name
        {
            get { return txtName.Text; }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string strJavaScript = $"<script type='text/javascript'>window.open('C31_ServerTransfer_2.aspx?qsemail={txtName.Text}');</script>";
            Response.Write(strJavaScript);
        }
    }
}