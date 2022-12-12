using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo
{
    public partial class C20_HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            DisplayData(int.Parse(TxtFindId.Text));
        }

        private void DisplayData(int id)
        {
            LoginUsers login = new LoginUsers();
            LoginModel lm = login.Find(id);

            TxtId.Text = lm.LoginId.ToString();
            HiddenId.Value = lm.LoginId.ToString();
            TxtName.Text = lm.UserFullName;
            TxtEmail.Text = lm.LoginEmail;
            TxtPassword.Text = lm.LoginPassword;
            TxtRole.Text = lm.RoleDescription;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Textbox: " + TxtId.Text + "<br>");
            Response.Write("Hidden: " + HiddenId.Value);
        }
    }
}