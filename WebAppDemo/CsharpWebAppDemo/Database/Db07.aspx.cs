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
    public partial class Db07 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //FillDropDownAuthor();
                //FillDropDownAuthor2();
                //FillDropDownAuthor3();
                FillDataGrid();
                FillDropDownAuthorSp();
            }
        }

        private void FillDataGrid()
        {
            Author author = new Author();
            GridView1.DataSource = author.Authors();
            GridView1.DataBind();
        }

        private void FillDropDownAuthor()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM ListAuthor";
                    cmd.Connection = DBConnection;

                    //SqlDataReader to store the Result returns by SqlCommand
                    SqlDataReader ReaderAuthor;

                    if (DBConnection.State == System.Data.ConnectionState.Closed)
                    {
                        DBConnection.Open();
                    }

                    ReaderAuthor = cmd.ExecuteReader();   //Execute First Command

                    //Add Items in DropDown
                    ListAuthor.Items.Clear();
                    //ListAuthor.Items.Add(new ListItem("Select Author", "-1"));
                    //while (ReaderAuthor.Read())
                    //{
                    //    ListAuthor.Items.Add(new ListItem(ReaderAuthor["AuthorName"].ToString(), ReaderAuthor["AuthorId"].ToString()));
                    //}

                    //Fill List Author Drop Down Using Data Binding
                    ListAuthor.DataTextField = "AuthorName";
                    ListAuthor.DataValueField = "AuthorId";
                    ListAuthor.DataSource = ReaderAuthor;
                    ListAuthor.DataBind();  //Populate - Iterate DataSource Property Object

                    ReaderAuthor.Close();
                }
            }
        }

        private void FillDropDownAuthor2()
        {
            Author author = new Author();
            List<AuthorModel> ListAuthor = new List<AuthorModel>();
            ListAuthor = author.GetAllAuthors();

            //this.ListAuthor.Items.Add(new ListItem("Select Author", "-1"));
            //foreach (AuthorModel AuthorDetail in ListAuthor.GetAllAuthors())
            //{
            //    //Response.Write($"<br> {AuthorDetail.AuthorId}, {AuthorDetail.AuthorName}");
            //    this.ListAuthor.Items.Add(new ListItem(AuthorDetail.AuthorName, AuthorDetail.AuthorId.ToString()));
            //}

            //this.ListAuthor.DataSource = author.GetAllAuthors();
            //or
            this.ListAuthor.DataSource = ListAuthor;
            this.ListAuthor.DataTextField = "AuthorName";
            this.ListAuthor.DataValueField = "AuthorId";
            this.ListAuthor.DataBind();
        }

        private void FillDropDownAuthorSp()
        {
            Author author = new Author();
            List<AuthorModel> ListAuthor = new List<AuthorModel>();
            ListAuthor = author.SpGetAllAuthors();

            this.ListAuthor.DataSource = ListAuthor;
            this.ListAuthor.DataTextField = "AuthorName";
            this.ListAuthor.DataValueField = "AuthorId";
            this.ListAuthor.DataBind();
        }

        private void FillDropDownAuthor3()
        {
            Author author = new Author();

            this.ListAuthor.DataSource = author.GetAllAuthors2();
            this.ListAuthor.DataTextField = "AuthorName";
            this.ListAuthor.DataValueField = "AuthorId";
            this.ListAuthor.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(ListAuthor.SelectedValue);
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            //AuthorModel modelAuthor = author.FindById(int.Parse(TxtAuthorId.Text));
            AuthorModel modelAuthor = author.spFindById(int.Parse(TxtAuthorId.Text));

            TxtAuthorName.Text = modelAuthor.AuthorName;
        }
    }
}