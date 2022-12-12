using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn01_Click(object sender, EventArgs e)
        {
            Response.Write("<br>Click Event Fired");
            if (TxtName.Text == "Name")
            {
                Response.Write("Default Text");
            }
            else if(String.IsNullOrWhiteSpace(TxtName.Text))
            {
                Response.Write("Null");
            }
            else
            {
                Response.Write("Not Null");
            }

        }

        protected void TxtName_TextChanged(object sender, EventArgs e)
        {
            
            Response.Write("<br>Text Change Event Fired");
        }

        protected void Btn01_Load(object sender, EventArgs e)
        {
            Response.Write("<br>Button Load Event Fired");
        }

        protected void Btn01_Init(object sender, EventArgs e)
        {
            Response.Write("<br>Button Init Event Fired");
            Btn01.Text = "Initilized";
        }

        protected void Btn01_PreRender(object sender, EventArgs e)
        {
            Response.Write("<br>Button Pre Render Event Fired");
            Btn01.Text = "Pre Render";
        }
    }
}