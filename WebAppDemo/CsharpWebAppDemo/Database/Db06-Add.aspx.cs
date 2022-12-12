using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.Database
{
    public partial class Db06_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropDownAuthor();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //cmd.CommandText = $"INSERT INTO ListAuthor (AuthorName) VALUES ('{TextBox1.Text}')";
                    cmd.CommandText = $"INSERT INTO ListAuthor (AuthorName) VALUES (@pAuthorName)";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@pAuthorName", TextBox1.Text);

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    int RowsAffected = cmd.ExecuteNonQuery();

                    //Response.Write(RowsAffected);

                    //FillDropDownAuthor();
                    Response.Redirect("Db06-Add.aspx");
                }
            }      
        }

        private void FillDropDownAuthor()
        {
            Author ListAuthor = new Author();

            this.ListAuthor.Items.Add(new ListItem("Select Author", "-1"));
            foreach (AuthorModel AuthorDetail in ListAuthor.GetAllAuthors())
            {
                this.ListAuthor.Items.Add(new ListItem(AuthorDetail.AuthorName, AuthorDetail.AuthorId.ToString()));
            }
        }
    }
}