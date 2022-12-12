using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CsharpWebAppDemo.Database
{
    public partial class Db08_Disconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string QueryStr = "SELECT * FROM ListAuthor";
                    //cmd.CommandText = QueryStr;
                    //cmd.Connection = DBConnection;

                    DataTable dbTable = new DataTable();
                    //DataSet dbTable = new DataSet();

                    //Method 01
                    //SqlDataAdapter DataAdapter = new SqlDataAdapter();
                    //DataAdapter.SelectCommand = cmd;

                    //Method 02
                    //SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);

                    //Method 03
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(QueryStr,DBConnection); //No use of SqlCmd, mfa


                    DataAdapter.Fill(dbTable);
                    GridView1.DataSource = dbTable;
                    GridView1.DataBind();

                    DropDownList1.DataSource = dbTable;
                    DropDownList1.DataTextField = "AuthorName";
                    DropDownList1.DataValueField = "AuthorId";
                    DropDownList1.DataBind();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}