using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace CsharpWebAppDemo.Database.Models
{
    public class LoginUsers
    {
        public int AuthenticateUser(LoginModel login)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            //Str Concatination Query
            //string QueryStr = $"SELECT LoginId FROM LoginUsersDetail WHERE(LoginEmail = '{login.LoginEmail}') AND (LoginPassword = '{login.LoginPassword}')";

            //Parameterized Query
            string QueryStr = "SELECT LoginId FROM LoginUsersDetail WHERE(LoginEmail = @pLoginEmail) AND (LoginPassword = @pLoginPassword)";

            //Build Queries using String Concatination - Retrives values from Forms and build SQL Queries
            //string QueryStr = $"SELECT LoginId FROM LoginUsersDetail WHERE(LoginEmail = '{login.LoginEmail}')";


            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();

                //SQL Server Parameter exisit in sqlCommand.Parameter Class
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                //da.SelectCommand.CommandText = QueryStr;
                //da.SelectCommand.Connection = DBConnection;


                //Input Parameters - By Defatul Parameter type = Input
                //Method 1: using AddWithValue
                da.SelectCommand.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);

                /*
                //Method2: using Add
                da.SelectCommand.Parameters.Add("@pLoginEmail", SqlDbType.VarChar, 50).Value=login.LoginEmail;
                da.SelectCommand.Parameters.Add("@pLoginEmail", SqlDbType.VarChar).Value=login.LoginEmail;

                //Method3: using SqlParameter Object Class
                SqlParameter pLoginEmail = new SqlParameter("@pLoginEmail", SqlDbType.VarChar, 50);
                pLoginEmail.Value = login.LoginEmail;
                pLoginEmail.Direction = ParameterDirection.Input;   //By Default Parameter Direction will be Input

                da.SelectCommand.Parameters.Add(pLoginEmail);
                */
                


                da.SelectCommand.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);

                da.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    return -1;  //Invalid
                }
                else
                {
                    return 0;   //Valid
                }
            }
        }

        public List<LoginModel> GetAllUsers()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            //string QueryStr = "spViewLoginDetail";
            string QueryStr = "SELECT * FROM LoginUsersDetail";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr,DBConnection);
                da.SelectCommand.CommandType = CommandType.Text;
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                da.Fill(dt);

                LoginModel login;
                List<LoginModel> loginList = new List<LoginModel>();

                foreach(DataRow row in dt.Rows)
                {
                    login = new LoginModel();
                    login.LoginId = (int)row["LoginId"];
                    login.LoginEmail = row["LoginEmail"].ToString();
                    login.UserFullName = row["UserFullName"].ToString();
                    login.LoginPassword = row["LoginPassword"].ToString();
                    //login.LoginRole = row["Role"].ToString();
                    //login.RoleDescription = row["RoleDescription"].ToString();
                    login.IsActive = (bool)row["IsActive"];
                    login.AccountLocked = (bool)row["AccountLocked"];
                    login.CreationDateTime = (DateTime)row["CreationDateTime"];
                    loginList.Add(login);
                }

                int countList = loginList.Count;

                return loginList;
            }
        }

        public LoginModel Find(int id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string QueryStr = "FindLoginById";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                da.SelectCommand.Parameters.AddWithValue("@pLoginId", id);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                da.Fill(dt);

                LoginModel login = new LoginModel();
                if(dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    login.LoginId = (int)row["LoginId"];
                    login.LoginEmail = row["LoginEmail"].ToString();
                    login.UserFullName = row["UserFullName"].ToString();
                    login.LoginPassword = row["LoginPassword"].ToString();
                    login.LoginRole = row["Role"].ToString();
                    login.RoleDescription = row["RoleDescription"].ToString();
                    login.IsActive = (bool)row["IsActive"];
                    login.AccountLocked = (bool)row["AccountLocked"];
                    login.CreationDateTime = (DateTime)row["CreationDateTime"];
                }

                return login;
            }
        }

        public int AddLogin(LoginModel login)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spInsertLogin";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pLoginEmail",login.LoginEmail);
                    cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    cmd.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);
                    cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    int RowsAffected = cmd.ExecuteNonQuery();

                    return RowsAffected;
                }
            }
        }

        public Object AddLogin2()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "INSERT INTO LoginUsersDetail (LoginEmail, UserFullName, LoginPassword, UserRoleId, IsActive) Values('Abcxyz@xyz.com','xyz','xyz123',2,0);SELECT SCOPE_IDENTITY()";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    //cmd.CommandText = "spInsertLogin";
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Connection = conn;
                    //cmd.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);
                    //cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    //cmd.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);
                    //cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    //cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    Object obj = cmd.ExecuteScalar();
                    //int RowsAffected = (int)(obj);

                    return obj;
                }
            }
        }

        public Object AddLoginReturnId(LoginModel login)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spInsertLoginId";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);
                    cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    cmd.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);
                    cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    Object RowsAffected = cmd.ExecuteScalar();

                    return RowsAffected;
                }
            }
        }

        public int AddLoginOutPara(LoginModel login)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spInsertLoginIdOutputPram";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);
                    cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    cmd.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);
                    cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    //Create Output Parameter which holds the IDENTITY Column Value
                    SqlParameter oParamLoginId = new SqlParameter();
                    oParamLoginId.ParameterName = "@pLoginID";
                    oParamLoginId.SqlDbType = SqlDbType.Int;
                    oParamLoginId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(oParamLoginId);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    //cmd.ExecuteNonQuery();

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if(RowsAffected == -1)
                    {
                        return (int)oParamLoginId.Value;
                    }
                    else
                    {
                        return RowsAffected;
                    }

                }
            }
        }

        public int AddLoginEncryptPass(LoginModel login)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(login.LoginPassword, "SHA1");

                    cmd.CommandText = "spInsertLogin";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);
                    cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    cmd.Parameters.AddWithValue("@pLoginPassword", encryptedPassword);
                    cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    int RowsAffected = cmd.ExecuteNonQuery();

                    return RowsAffected;
                }
            }
        }

        public void DeleteById(int id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string QueryStr = "DELETE from LoginUsersDetail WHERE (LoginId = @pLoginId)";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = QueryStr;
                da.SelectCommand.Parameters.AddWithValue("@pLoginId", id);
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                DBConnection.Close();
            }
        }

        public void UpdateLogin(LoginModel login, int LoginId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spUpdateLogin";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pLoginId", LoginId);
                    cmd.Parameters.AddWithValue("@pLoginEmail", login.LoginEmail);
                    cmd.Parameters.AddWithValue("@pUserName", login.UserFullName);
                    cmd.Parameters.AddWithValue("@pLoginPassword", login.LoginPassword);
                    cmd.Parameters.AddWithValue("@pRoleId", login.RoleId);
                    cmd.Parameters.AddWithValue("@pIsActive", login.IsActive);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}