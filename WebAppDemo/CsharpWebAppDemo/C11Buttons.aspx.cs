using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C11Buttons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Focus();
            this.Button1.Focus();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetTextVal();
        }

        private void GetTextVal()
        {
            Response.Write($"Name = {TextBox1.Text} <br>");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GetTextVal();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            GetTextVal();
        }
    }
}