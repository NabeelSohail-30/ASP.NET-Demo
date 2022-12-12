using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C28_CustomVal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Response.Redirect("C23_Dynamic Control.aspx");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                int Number;
                bool isNumber = int.TryParse(args.Value, out Number);

                if (isNumber && Number>=0 && (Number %2)==0)
                {
                    args.IsValid = true;

                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}