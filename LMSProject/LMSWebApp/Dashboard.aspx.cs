using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS;

namespace LMSWeb
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check if User came directly without login Page
            if (Session["sLoginId"] == null)
            {
                Response.Redirect("LoginForm.aspx?LoginError=Your Session has been expired. Please login again to continue");
            }
        }
    }
}