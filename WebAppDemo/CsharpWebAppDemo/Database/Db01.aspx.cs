using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CsharpWebAppDemo.Database
{
    public partial class Db01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connect and Open DB
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;";

            //Build SQL Command
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.TableDirect;
            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            SqlDataReader ReaderAuthor;

            try
            {
                DBConnection.Open();
                ReaderAuthor = cmd.ExecuteReader();

                //Response.Write("Is Data Available: " + ReaderAuthor.Read());
                //Response.Write("Is Data Available using Has Rows: " + ReaderAuthor.HasRows);

                //ReaderAuthor.Read();
                //Response.Write($"Id = {ReaderAuthor["AuthorId"]}, Name = {ReaderAuthor["AuthorName"]} <br>");
                //ReaderAuthor.Read();
                //Response.Write($"Id = {ReaderAuthor["AuthorId"]}, Name = {ReaderAuthor["AuthorName"]} <br>");

                while(ReaderAuthor.Read())
                {
                    Response.Write($"Id = {ReaderAuthor["AuthorId"]}, Name = {ReaderAuthor["AuthorName"]} <br>");
                }
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }


        }
    }
}