using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.RegistrationForm01
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                Panel1.Visible = false;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            DisplayDetail();
        }

        private void DisplayDetail()
        {
            Panel1.Visible = true;
            FirstName.Text = TxtFirstName.Text;
            LastName.Text = TxtLastName.Text;
            Gender.Text = DdListGender.SelectedItem.ToString();
            Nationality.Text = DdNationality.SelectedItem.ToString();
            MobileNumber.Text = TxtMobileNumber.Text;
            EmailAddress.Text = TxtEmail.Text;
            Address.Text = TxtAddress.Text;
        }
    }
}