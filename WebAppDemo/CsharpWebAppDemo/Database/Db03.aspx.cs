using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CsharpWebAppDemo.Database
{
    public partial class Db03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connect and Open DB
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;";

            //Build SQL Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            SqlDataReader ReaderAuthor;

            DBConnection.Open();
            ReaderAuthor = cmd.ExecuteReader();

            //Add Items in DropDown
            Table1.Rows.Add(new TableRow());
           
        }
    }
}