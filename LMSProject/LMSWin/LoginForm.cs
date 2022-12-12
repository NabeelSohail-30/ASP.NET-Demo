using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LMS;

namespace LMSWin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string LoginEmail;
            string LoginPassword;
            string QryStr;

            LoginEmail = TxtUserEmail.Text;
            LoginPassword = TxtUserPass.Text;

            if (string.IsNullOrEmpty(LoginEmail))
            {
                MessageBox.Show("Please Enter Login Email, Login Email cannot be NULL", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(LoginPassword))
            {
                MessageBox.Show("Please Enter Login Password, Login Password cannot be NULL", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //    LoggedUserModel.LoginId = (int)ReaderLoginDetail["LoginId"];
            //    LoggedUserModel.LoginEmail = (string)ReaderLoginDetail["LoginEmail"];
            //    LoggedUserModel.LoginPassword = (string)ReaderLoginDetail["LoginPassword"];
            //    LoggedUserModel.UserFullName = (string)ReaderLoginDetail["UserFullName"];
            //    LoggedUserModel.UserRole = (string)ReaderLoginDetail["Role"];
            //    LoggedUserModel.LoggedDateTime = DateTime.Now;

            //    OpenDb.Close();
            //    cmd.Dispose();
            //    ReaderLoginDetail.Close();

            //    this.Hide();

            //    Dashboard DashboardForm = new Dashboard();
            //    DashboardForm.Show();
            //}
            //else
            //{
            //    OpenDb.Close();
            //    cmd.Dispose();
            //    ReaderLoginDetail.Close();
            //    MessageBox.Show("Login Failed, Incorrect User Email or Password","Login Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            LoginUsers AuthenticateUser = new LoginUsers();

            int LoginId = AuthenticateUser.Authenticate(LoginEmail, LoginPassword);
            if (LoginId != -1)
            {
                LoginUsersModel LoggedUserDetail = AuthenticateUser.GetLoginInfo(LoginId);
                this.Hide();

                //LoggedUserModel.LoginId = LoggedUserDetail.LoginId;
                //LoggedUserModel.LoginEmail = LoggedUserDetail.LoginEmail;
                //LoggedUserModel.LoginPassword = LoggedUserDetail.LoginPassword;
                //LoggedUserModel.UserFullName = LoggedUserDetail.UserFullName;
                //LoggedUserModel.UserRoleId = LoggedUserDetail.UserRoleId;
                //LoggedUserModel.LoggedDateTime = DateTime.Now;

                Global.LoggedUser.LoginId = LoggedUserDetail.LoginId;
                Global.LoggedUser.LoginEmail = LoggedUserDetail.LoginEmail;
                Global.LoggedUser.LoginPassword = LoggedUserDetail.LoginPassword;
                Global.LoggedUser.UserFullName = LoggedUserDetail.UserFullName;
                Global.LoggedUser.UserRoleId = LoggedUserDetail.UserRoleId;
                Global.LoggedUser.UserRole = LoggedUserDetail.UserRole;
                Global.LoggedUser.LoggedDateTime = LoggedUserDetail.LoggedDateTime;


                Dashboard DashboardForm = new Dashboard();
                DashboardForm.Show();
            }
            else
            {
                MessageBox.Show($"{AuthenticateUser.Error}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
