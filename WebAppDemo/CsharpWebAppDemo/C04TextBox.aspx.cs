using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C04TextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            if (TextBox1.Visible == true)
            {
                TextBox1.Visible = false;
            }
            else
            {
                TextBox1.Visible = true;
            }
            */
            TextBox1.Visible = !(TextBox1.Visible);
        }

        protected void TxtPass_TextChanged(object sender, EventArgs e)
        {
            Response.Write($"Your Password is : {TxtPass.Text}");
        }
    }
}