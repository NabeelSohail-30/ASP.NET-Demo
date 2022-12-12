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
    public partial class Db06_Edit : System.Web.UI.Page
    {
        int Id;
        string Name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropDownAuthor();
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Id = int.Parse(ListAuthor.SelectedValue);
            Name = ListAuthor.SelectedItem.ToString();
            TextBox1.Text = Name;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Id = int.Parse(ListAuthor.SelectedValue);
            if (Id > -1)
            {
                string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = $"UPDATE ListAuthor SET AuthorName = '{TextBox1.Text}' WHERE (AuthorId = {Id})";
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = conn;

                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        int RowsAffected = cmd.ExecuteNonQuery();

                        Response.Write(RowsAffected);
                        Response.Redirect("Db06-Edit.aspx");
                    }
                }
            }
        }
    }
}