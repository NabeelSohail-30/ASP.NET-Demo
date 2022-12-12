using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CsharpWebAppDemo.Database.LoginForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string LoginEmail = TxtUserEmail.Text;
            string LoginPassword = TxtUserPass.Text;
            string QryStr;

            SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;");

            SqlCommand cmd = new SqlCommand();
            QryStr = $"SELECT LoginEmail, LoginPassword FROM LoginUsersDetail WHERE (LoginEmail = '{LoginEmail}') AND (LoginPassword = '{LoginPassword}') AND (IsActive <> 0)";
            cmd.CommandText = QryStr;
            cmd.Connection = OpenDb;

            SqlDataReader ReaderLoginDetail;

            OpenDb.Open();
            ReaderLoginDetail = cmd.ExecuteReader();

            if(ReaderLoginDetail.HasRows)
            {
                Response.Redirect("Logged.aspx");
            }
            else
            {
                this.LblLoginError.Visible = true;
            }


            //Boolean IsLogged = false;

            //while(ReaderLoginDetail.Read())
            //{
            //    if(LoginEmail.ToLower() == ReaderLoginDetail["LoginEmail"].ToString().ToLower() && LoginPassword == ReaderLoginDetail["LoginPassword"].ToString())
            //    {
            //        IsLogged = true;
            //        this.LblLoginError.Visible = false;
            //        Response.Redirect("Logged.aspx");
            //    }
            //}

            //if (!IsLogged)
            //    this.LblLoginError.Visible = true;
        }
    }
}