using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LMSWin.Models;

namespace LMSWin.Models
{
    class LoginUsers
    {
        public string Error { get; set; }
        public int Authenticate(string pLoginEmail, string pLoginPassword)
        {
            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"SELECT LoginId FROM LoginUsersDetail WHERE (LoginEmail = '{pLoginEmail}') AND (LoginPassword = '{pLoginPassword}') AND (IsActive <> 0)";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;

                    //SqlDataReader ReaderLoginDetail;

                    OpenDb.Open();
                    //ReaderLoginDetail = cmd.ExecuteReader();
                    int dbLoginId;

                    if (cmd.ExecuteScalar() == null)
                    {
                        dbLoginId = -1;
                    }
                    else
                    {
                        dbLoginId = (int)cmd.ExecuteScalar();
                    }

                    if (dbLoginId > 0)
                    {                       
                        return dbLoginId;
                    }
                    else
                    {
                        this.Error = "Login Failed! Invalid User Email or Password.";
                        return dbLoginId;  //Invalid Login - Login Failed
                    }
                }
            }

        }

        public LoginUsersModel GetLoginInfo(int pLoginId)
        {
            //Get Login User Detail from Table against pLoginId
            string QryStr;
            LoginUsersModel LoginDetail = new LoginUsersModel();

            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"SELECT * FROM LoginUsersDetail WHERE (LoginId = {pLoginId})";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;

                    SqlDataReader ReaderLoginDetail;

                    OpenDb.Open();
                    ReaderLoginDetail = cmd.ExecuteReader();

                    if (ReaderLoginDetail.HasRows)
                    {
                        ReaderLoginDetail.Read();
                        LoginDetail.LoginId = (int)ReaderLoginDetail["LoginId"];
                        LoginDetail.LoginEmail = (string)ReaderLoginDetail["LoginEmail"];
                        LoginDetail.LoginPassword = (string)ReaderLoginDetail["LoginPassword"];
                        LoginDetail.UserFullName = (string)ReaderLoginDetail["UserFullName"];
                        LoginDetail.UserRoleId = (Int16)ReaderLoginDetail["UserRoleId"];
                        LoginDetail.LoggedDateTime = DateTime.Now;

                        //Role Object
                        Role role = new Role();
                        LoginDetail.UserRole = role.Find(LoginDetail.UserRoleId);
                    }
                }
            }

            return LoginDetail;
        }
    }
}
