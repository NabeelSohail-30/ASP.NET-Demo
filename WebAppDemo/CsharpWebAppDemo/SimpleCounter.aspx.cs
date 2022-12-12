using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class SimpleCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page Load Event");
        }

        protected void ButtonCounter(object sender, EventArgs e)
        {
            /*
            int Counter = 0;
            int.TryParse(LblValue.Text, out Counter);

            Counter++;

            LblValue.Text = Counter.ToString();
            */

            LblValue.Text = ((int.Parse(LblValue.Text)) + 1).ToString();

        }

        protected void ButtonResetCounter(object sender, EventArgs e)
        {
            int Counter = 0;

            LblValue.Text = Counter.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed");
        }
    }
}