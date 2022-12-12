using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS
{
    public class Author
    {
        public List<AuthorModel> Authors()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT AuthorId, AuthorName FROM ListAuthor";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<AuthorModel> ListAuthor = new List<AuthorModel>();
                    AuthorModel Author;

                    

                    while (DataReader.Read())
                    {
                        Author = new AuthorModel();
                        Author.AuthorId = (int)DataReader["AuthorId"];
                        Author.AuthorName = DataReader["AuthorName"].ToString();
                        ListAuthor.Add(Author);
                    }

                    DataReader.Close();

                    return ListAuthor;
                }
            }
        }

        public int Add(AuthorModel pAuthor)
        {
            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"INSERT INTO ListAuthor(AuthorName) VALUES ('{pAuthor.AuthorName}'); SELECT SCOPE_IDENTITY()";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    int AuthorId = Convert.ToInt32(cmd.ExecuteScalar());

                    return AuthorId;
                }
            }
        }

        public bool Exist(int pAuthorId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListAuthor WHERE (AuthorId = {pAuthorId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    if (DataReader.HasRows)
                    {
                        return true;
                    }

                    DataReader.Close();

                    return false;
                }
            }
        }

        public bool Exist(string pAuthor)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListAuthor WHERE (Author = '{pAuthor}')";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    if (DataReader.HasRows)
                    {
                        return true;
                    }

                    DataReader.Close();

                    return false;
                }
            }
        }

        public AuthorModel Find(int pAuthorId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListAuthor WHERE (AuthorId = {pAuthorId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    AuthorModel author;

                    if (DataReader.HasRows)
                    {
                        author = new AuthorModel();
                        DataReader.Read();
                        author.AuthorId = (int)DataReader["AuthorId"];
                        author.AuthorName = DataReader["Author"].ToString();
                        return author;
                    }

                    author = new AuthorModel();

                    DataReader.Close();

                    return author;
                }
            }
        }

        public AuthorModel Find(string pAuthor)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListAuthor WHERE (Author = '{pAuthor}')";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    AuthorModel author;

                    if (DataReader.HasRows)
                    {
                        author = new AuthorModel();
                        DataReader.Read();
                        author.AuthorId = (int)DataReader["AuthorId"];
                        author.AuthorName = DataReader["Author"].ToString();
                        return author;
                    }

                    author = new AuthorModel();

                    DataReader.Close();

                    return author;
                }
            }
        }
    }
}