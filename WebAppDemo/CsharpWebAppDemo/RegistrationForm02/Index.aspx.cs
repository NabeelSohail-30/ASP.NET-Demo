using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.RegistrationForm02
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            StoreDetail();
            Response.Redirect("View.aspx");
        }

        private void StoreDetail()
        {
            Session["sFirstName"] = TxtFirstName.Text;
            Session["sLastName"] = TxtLastName.Text;
            Session["sGender"] = DdListGender.SelectedItem;
            Session["sNationality"] = DdNationality.SelectedItem;
            Session["sMobile"] = TxtMobileNumber.Text;
            Session["sEmail"] = TxtEmail.Text;
            Session["sAddress"] = TxtAddress.Text;
        }
    }
}