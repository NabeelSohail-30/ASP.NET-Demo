using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.RegistrationForm02
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayDetail();
        }

        private void DisplayDetail()
        {
            FirstName.Text = Session["sFirstName"].ToString();
            LastName.Text = Session["sLastName"].ToString();
            Gender.Text = Session["sGender"].ToString();
            Nationality.Text = Session["sNationality"].ToString();
            MobileNumber.Text = Session["sMobile"].ToString();
            EmailAddress.Text = Session["sEmail"].ToString();
            Address.Text = Session["sAddress"].ToString();
        }
    }
}