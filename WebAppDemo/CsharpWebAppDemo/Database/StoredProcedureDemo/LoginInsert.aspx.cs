using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.Database.StoredProcedureDemo
{
    public partial class LoginInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //AddLogin();
        }

        private void AddLogin()
        {
            LoginUsers login = new LoginUsers();
            lblRowsAff.Text = login.AddLogin2().ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginModel loginDetail = new LoginModel();
            LoginUsers login = new LoginUsers();

            loginDetail.LoginEmail = TxtEmail.Text;
            loginDetail.UserFullName = TxtName.Text;
            loginDetail.LoginPassword = TxtPassword.Text;
            loginDetail.RoleId = int.Parse(TxtRole.Text);
            loginDetail.IsActive = bool.Parse(TxtIsActive.Text);

            //without return identity col - id
            //lblRowsAff.Text = login.AddLogin(loginDetail).ToString();

            //returning identity col - id
            //lblRowsAff.Text = login.AddLoginReturnId(loginDetail).ToString();

            //returning identity col using output param
            lblRowsAff.Text = login.AddLoginOutPara(loginDetail).ToString();
        }
    }
}