using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C02WebAppLifeCycleEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>Page Load Event Fired");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("<br>Page_PreInit Event Fired");
            this.Button1.Text = "Submit Form";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<br>Page_Init Event Fired");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("<br>Page_InitComplete Event Fired");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("<br>Page_PreLoad Event Fired");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("<br>Page_LoadComplete Event Fired");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("<br>Page_PreRender Event Fired");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("<br>Page_PreRenderComplete Event Fired");
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Response.Write("<br>Page Unload Event Fired");

            //Processing on server
            int a = 20 + 30;


        }

        protected void Button1_Load(object sender, EventArgs e)
        {
            Response.Write("<br>Button Load Event Fired");

        }
    }
}