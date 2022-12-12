using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CsharpWebAppDemo
{
    public partial class C18_AdRotatorDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindAdRotator();
        }

        private void BindAdRotator()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string QueryStr = "SELECT * FROM AdvertisementDetails";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(QueryStr,DBConnection);

                da.Fill(dt);

                AdRotator1.DataSource = dt;
                AdRotator1.DataBind();
            }
        }
    }
}