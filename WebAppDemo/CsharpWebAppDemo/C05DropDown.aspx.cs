using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C05DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((ListCountry.SelectedValue) == "-1")
            {
                Response.Write($"<br> Invalid Country Selected..");
            }
            else { 
            Response.Write($"Country = {ListCountry.SelectedItem}");
            }
        }
    }
}