using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CsharpWebAppDemo.Database
{
    public partial class Db02 : System.Web.UI.Page
    {
        
        //Connect and Open DB
        SqlConnection DBConnection = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;MultipleActiveResultSets=True;");
        //SqlConnection DBConnection = new SqlConnection("Data Source=NABEELS-WORK;Initial Catalog=DemoLMS;User Id=Demo;Password=Nabeel30;MultipleActiveResultSets=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader DataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropDownAuthor();
                FillDropDownCategory();
                //FillDropDownAuthorMethod2();
            }

        }

        private void FillDropDownCategory()
        {
            cmd.CommandText = "SELECT * FROM ListCategory";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            //SqlDataReader ReaderCategory;

            if(DBConnection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.Open();
            }

            DataReader = cmd.ExecuteReader();

            //Add Items in DropDown
            DDCategory.Items.Clear();
            DDCategory.Items.Add(new ListItem("Select Category", "-1"));
            while (DataReader.Read())
            {
                DDCategory.Items.Add(new ListItem(DataReader["Category"].ToString(), DataReader["CategoryId"].ToString()));
            }

            DBConnection.Close();
        }


        private void FillDropDownAuthor()
        {
            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            //SqlDataReader ReaderAuthor;

            if (DBConnection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.Open();
            }

            DataReader = cmd.ExecuteReader();   //Execute First Command

            //Add Items in DropDown
            DDAuthor.Items.Clear();
            DDAuthor.Items.Add(new ListItem("Select Author", "-1"));
            while (DataReader.Read())
            {
                DDAuthor.Items.Add(new ListItem(DataReader["AuthorName"].ToString(), DataReader["AuthorId"].ToString()));
            }

            //DBConnection.Close();
            DataReader.Close();
        }

        private void FillDropDownAuthorMethod2()
        {
            //int NumOfRows = 0;
            //SqlCommand cmdCount = new SqlCommand();
            //cmdCount.CommandText = "SELECT * FROM ListAuthor";
            //cmdCount.Connection = DBConnection;

            //SqlDataReader ReaderAuthorCount;

            //cmd.Dispose();

            //ReaderAuthorCount = cmdCount.ExecuteReader();

            //while (ReaderAuthorCount.Read())
            //{
            //    NumOfRows++;
            //}


            //ListItem[] ListAuthor = new ListItem[50];

            //for (int a = 0; a < 50; a++)
            //{
            //    ListAuthor[a] = new ListItem();
            //}

            //ListAuthor[0].Text = "Select Author";
            //ListAuthor[0].Value = "-1";
            //ListAuthor[0].Selected = true;

            //for (int a = 1; a < ListAuthor.Length; a++)
            //{
            //    ReaderAuthor.Read();
            //    ListAuthor[a].Text = ReaderAuthor["AuthorName"].ToString();
            //    ListAuthor[a].Value = ReaderAuthor["AuthorId"].ToString();
            //}

            //this.DDAuthor.Items.AddRange(ListAuthor); 
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Button Event Fired <br>");
            Response.Write($"Author - Selected Text = {DDAuthor.SelectedItem}, Selected Value = {DDAuthor.SelectedValue}");
            Response.Write($"Category - Selected Text = {DDCategory.SelectedItem}, Selected Value = {DDCategory.SelectedValue}");
        }

        protected void DDAuthor_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Response.Write($"Selected Text = {DDAuthor.SelectedItem}, Selected Value = {DDAuthor.SelectedValue}");
        }
    }
}