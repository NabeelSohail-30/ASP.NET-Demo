using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace LMS
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
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

            if (ReaderLoginDetail.HasRows)
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                this.LblLoginError.Visible = true;
            }
        }
    }
}