using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class Books
    {
        public List<BooksDetail> GetAllBooks()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM BooksDetail";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<BooksDetail> listBooks = new List<BooksDetail>();
                    BooksDetail book;

                    while (DataReader.Read())
                    {
                        book = new BooksDetail();

                        book.BookId = (int)DataReader["BookId"];
                        book.BookName = DataReader["BookName"].ToString();
                        book.CategoryId = (int)DataReader["CategoryId"];
                        book.LanguageId = (int)DataReader["LanguageId"];
                        book.AuthorId = (int)DataReader["AuthorId"];
                        book.PublisherId = (int)DataReader["PublisherId"];
                        book.BookPages = (int)DataReader["BookPages"];
                        book.Quantity = (Int16)DataReader["Quantity"];
                        book.CabinetId = (int)DataReader["CabinetId"];
                        book.ShelveId = (int)DataReader["ShelveId"];

                        listBooks.Add(book);
                    }
                    DataReader.Close();
                    return listBooks;
                }

            }
        }
    }
}