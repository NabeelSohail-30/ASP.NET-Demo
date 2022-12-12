using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.Database
{
    public partial class Db11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginUsers login = new LoginUsers();
            LoginModel loginM= new LoginModel();

            loginM.LoginEmail = TxtUserEmail.Text;
            loginM.LoginPassword = TxtUserPass.Text;

            if (login.AuthenticateUser(loginM) == -1){
                LblLoginError.Text = "Invalid Login Details";
                LblLoginError.Visible = true;
            }
            else
            {
                LblLoginError.Visible = false;
                Response.Redirect("www.google.com");
            }
        }
    }
}