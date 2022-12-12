using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CsharpWebAppDemo.Db;
using System.Data.SqlClient;

namespace CsharpWebAppDemo.Database.Models
{
    public class Dashboard: DbConnection
    {

        //Fields & Properties


        public string FindAuthor(int id)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"SELECT AuthorName FROM ListAuthor WHERE (AuthorId = {id})";
                    //cmd.ex

                    return "MyAuthorName";
                }
            }

        }
    }
}