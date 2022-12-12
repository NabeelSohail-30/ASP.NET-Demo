using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CsharpWebAppDemo.Database
{
    public partial class Db05 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                FillDropDown();
        }

        private void FillDropDown()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = "SELECT AuthorId, AuthorName FROM ListAuthor; SELECT CategoryId, Category FROM ListCategory;";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            DataReader = cmd.ExecuteReader();

            //Add Items in DropDown
            ListAuthor.Items.Clear();
            ListAuthor.Items.Add(new ListItem("Select Author", "-1"));
            while (DataReader.Read())
            {
                ListAuthor.Items.Add(new ListItem(DataReader["AuthorName"].ToString(), DataReader["AuthorId"].ToString()));
            }

            if (DataReader.NextResult())
            {
                ListCategory.Items.Clear();
                ListCategory.Items.Add(new ListItem("Select Category", "-1"));
                while (DataReader.Read())
                {
                    ListCategory.Items.Add(new ListItem(DataReader["Category"].ToString(), DataReader["CategoryId"].ToString()));
                }
            }

            conn.Close();
        }
    }
}