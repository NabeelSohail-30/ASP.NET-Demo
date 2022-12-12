using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using LMS;

namespace LMSWeb
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string LoginError = Request.QueryString["LoginError"];

            if(!string.IsNullOrEmpty(LoginError))
            {
                this.LblLoginError.Text = LoginError;
                this.LblLoginError.Visible = true;
            }

            //Check if values are coming from FORM or SESSION
            if (Session["sLoginEmail"] != null || Session["sLoginPass"] != null)
            {
                Response.Redirect("Dashboard.aspx");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string LoginEmail;
            string LoginPassword;
            string QryStr;
            DateTime LoggedDt = DateTime.Now;
            //bool ErrorFound = false;

            LblEmailError.Visible = false;
            LblPassError.Visible = false;
            LblLoginError.Visible = false;

            //Check if values are coming from FORM or SESSION
            if (Session["sLoginEmail"] == null || Session["sLoginPass"] == null)
            {
                LoginEmail = TxtUserEmail.Text;
                LoginPassword = TxtUserPass.Text;
            }
            else
            {
                LoginEmail = Session["sLoginEmail"].ToString();
                LoginPassword = Session["sLoginPass"].ToString();
            }

            LoginEmail = TxtUserEmail.Text;
            LoginPassword = TxtUserPass.Text;

            //Session
            Session["sLoginEmail"] = "";
            Session["sLoginId"] = "";
            Session["sLoginPass"] = "";
            Session["sUserName"] = "";
            Session["sUserRole"] = "";

            //Checking Null
            if (string.IsNullOrEmpty(LoginEmail))
            {
                LblEmailError.Visible = true;               
                return;
            }
            else if (string.IsNullOrEmpty(LoginPassword))
            {
                Session["sLoginEmail"] = LoginEmail;              
                LblPassError.Visible = true; 
                return;
            }

            //SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;");

            //SqlCommand cmd = new SqlCommand();

            //QryStr = $"SELECT * FROM View_LoginDetail WHERE (LoginEmail = '{LoginEmail}') AND (LoginPassword = '{LoginPassword}') AND (IsActive <> 0)";

            //cmd.CommandText = QryStr;
            //cmd.Connection = OpenDb;

            //SqlDataReader ReaderLoginDetail;

            //OpenDb.Open();
            //ReaderLoginDetail = cmd.ExecuteReader();

            //if (ReaderLoginDetail.HasRows)
            //{
            //    ReaderLoginDetail.Read();
            //    Session["sLoginEmail"] = ReaderLoginDetail["LoginEmail"];
            //    Session["sLoginId"] = ReaderLoginDetail["LoginId"];
            //    Session["sLoginPass"] = ReaderLoginDetail["LoginPassword"];
            //    Session["sUserName"] = ReaderLoginDetail["UserFullName"];
            //    Session["sUserRole"] = ReaderLoginDetail["Role"];
            //    //Response.Redirect("Dashboard.aspx");

            //    OpenDb.Close();
            //    cmd.Dispose();
            //    ReaderLoginDetail.Close();

            //    if (Session["sLoggedDt"] == null)
            //    {
            //        Session["sLoggedDt"] = LoggedDt;
            //    }

            //    Response.Redirect("Dashboard.aspx");

            //}
            //else
            //{
            //    OpenDb.Close();
            //    cmd.Dispose();
            //    ReaderLoginDetail.Close();

            //    this.LblLoginError.Text = "Login Failed. Incorrect Login Email or Password";
            //    this.LblLoginError.Visible = true;
            //}

            LoginUsers AuthenticateUser = new LoginUsers();

            int LoginId = AuthenticateUser.Authenticate(LoginEmail, LoginPassword);
            if(LoginId != -1)
            {
                LoginUsersModel LoggedUserDetail = AuthenticateUser.GetLoginInfo(LoginId);
                Response.Write(LoggedUserDetail.LoginEmail);
                Session["sLoginEmail"] = LoggedUserDetail.LoginEmail;
                Session["sLoginId"] = LoggedUserDetail.LoginId;
                Session["sLoginPass"] = LoggedUserDetail.LoginPassword;
                Session["sUserName"] = LoggedUserDetail.UserFullName;
                Session["sUserRole"] = LoggedUserDetail.UserRoleId;
                Session["sLoggedDt"] = LoggedUserDetail.LoggedDateTime;

                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                this.LblLoginError.Text = AuthenticateUser.Error;
                this.LblLoginError.Visible = true;
            }

        }
    }
}