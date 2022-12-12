using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CsharpWebAppDemo.Database.Models
{
    public class Author
    {

        public List<AuthorModel> GetAllAuthors()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = "SELECT * FROM ListAuthor";
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
                Author.Gender = DataReader["Gender"].ToString();
                Author.Active = (bool)DataReader["Active"];
                Author.ImageURL = DataReader["ImageURL"].ToString();
                Author.TotalPrice = double.Parse(DataReader["TotalPrice"].ToString());
                Author.Qty = int.Parse(DataReader["Qty"].ToString());
                ListAuthor.Add(Author);
            }



            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public DataView GetAllAuthors3()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string qs = "SELECT * FROM ListAuthor";
            SqlConnection conn = new SqlConnection(CS);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(qs, conn);


            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            da.Fill(ds,"Authors");

            DataView dv = ds.Tables["Authors"].DefaultView;

            conn.Close();

            return dv;

        }

        public List<AuthorModel> GetAllAuthors(string sortColumn)
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            if (string.IsNullOrEmpty(sortColumn))
            {
                cmd.CommandText = $"SELECT * FROM ListAuthor";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM ListAuthor ORDER BY {sortColumn}";
            }


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
                Author.Gender = DataReader["Gender"].ToString();
                Author.Active = (bool)DataReader["Active"];
                Author.TotalPrice = Convert.ToDouble(DataReader["TotalPrice"]);
                Author.Qty = (int)DataReader["Qty"];
                Author.ImageURL = DataReader["ImageURL"].ToString();
                ListAuthor.Add(Author);
            }



            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public List<AuthorModel> Authors()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;


            cmd.CommandText = "SELECT AuthorId, AuthorName FROM ListAuthor";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            //cmd.Parameters.AddWithValue();

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

            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public List<AuthorModel> AuthorsDisconnected()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            string QueryStr = "SELECT * FROM ListAuthor";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(QueryStr, DBConnection);

                da.Fill(dt);

                List<AuthorModel> ListAuthor = new List<AuthorModel>();
                AuthorModel Author;

                //Complicated Code
                //for (int i=0; i<dt.Rows.Count; i++)
                //{
                //    Author = new AuthorModel();
                //    Author.AuthorId = int.Parse(dt.Rows[i]["AuthorId"].ToString());
                //    Author.AuthorName = dt.Rows[i]["AuthorName"].ToString();
                //    ListAuthor.Add(Author);
                //}

                //Simplified Version
                foreach (DataRow row in dt.Rows)
                {
                    Author = new AuthorModel();
                    Author.AuthorId = int.Parse(row["AuthorId"].ToString());
                    Author.AuthorName = row["AuthorName"].ToString();
                    ListAuthor.Add(Author);
                }

                return ListAuthor;
            }

        }

        public List<AuthorModel> AuthorsDisconnectedDS()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            string QueryStr = "SELECT * FROM ListAuthor";
            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(QueryStr, DBConnection);

                da.Fill(ds);

                List<AuthorModel> ListAuthor = new List<AuthorModel>();
                AuthorModel Author;



                //Simplified Version
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Author = new AuthorModel();
                    Author.AuthorId = int.Parse(row["AuthorId"].ToString());
                    Author.AuthorName = row["AuthorName"].ToString();
                    ListAuthor.Add(Author);
                }

                return ListAuthor;
            }

        }

        public DataSet AuthorsDisconnectedDS2()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            string QueryStr = "SELECT * FROM ListAuthor";
            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(QueryStr, DBConnection);

                da.Fill(ds);

                return ds;
            }

        }

        public SqlDataReader GetAllAuthors2()
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            //SqlDataReader DataReader;

            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return cmd.ExecuteReader();

        }

        public List<AuthorModel> FindAll(string authorName)
        {
            //Connection Open
            //Build and Execute Command (Select AuthorId, AuthorName from ListAuthor)
            //Generate List<AuthorModel>
            //Return List<AuthorModel>

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = $"SELECT AuthorId, AuthorName FROM ListAuthor WHERE (AuthorName LIKE '%{authorName}%')";
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

            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public List<AuthorModel> SpGetAllAuthors()
        {

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = "spGetAuthors";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public AuthorModel FindById(int id)
        {

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = $"SELECT AuthorId, AuthorName FROM ListAuthor WHERE (AuthorId = {id})";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            DataReader = cmd.ExecuteReader();

            AuthorModel Author = new AuthorModel();

            while (DataReader.Read())
            {
                Author.AuthorId = (int)DataReader["AuthorId"];
                Author.AuthorName = DataReader["AuthorName"].ToString();
            }

            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return Author;

        }

        public AuthorModel spFindById(int id)
        {

            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.Parameters.Add("@pAuthorId", SqlDbType.Int, 4).Value = id;
            cmd.CommandText = "spGetAuthorById";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            DataReader = cmd.ExecuteReader();

            AuthorModel Author = new AuthorModel();

            while (DataReader.Read())
            {
                Author.AuthorId = (int)DataReader["AuthorId"];
                Author.AuthorName = DataReader["AuthorName"].ToString();
            }

            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return Author;

        }

        public void DeleteById(int AuthorId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string QueryStr = "DELETE from ListAuthor WHERE (AuthorId = @pId)";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = QueryStr;
                da.SelectCommand.Parameters.AddWithValue("@pId", AuthorId);
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                DBConnection.Close();
            }
        }

        public void DeleteById(List<string> ListAuthorId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            //string QueryStr = "DELETE from ListAuthor WHERE (AuthorId IN (@pId))";

            string AuthorId = "";

            foreach (string id in ListAuthorId)
            {
                AuthorId += $"{id},";
            }

            AuthorId = AuthorId.Remove(AuthorId.Length - 1, 1);

            string QueryStr = $"DELETE from ListAuthor WHERE (AuthorId IN ({AuthorId}))";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = QueryStr;
                //da.SelectCommand.Parameters.AddWithValue("@pId", AuthorId);
                //da.SelectCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = AuthorId;
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                DBConnection.Close();
            }
        }

        public void DeleteById(int original_AuthorId, string original_AuthorName)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            string QueryStr = "DELETE from ListAuthor WHERE (AuthorId = @pId AND AuthorName = @pName)";

            using (SqlConnection DBConnection = new SqlConnection(CS))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(QueryStr, DBConnection);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = QueryStr;
                da.SelectCommand.Parameters.AddWithValue("@pId", original_AuthorId);
                da.SelectCommand.Parameters.AddWithValue("@pName", original_AuthorName);
                DBConnection.Open();
                da.SelectCommand.ExecuteNonQuery();

                DBConnection.Close();
            }
        }

        public void UpdateAuthor(int authorId, string authorName, string Gender, bool Active)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "UPDATE ListAuthor SET AuthorName = @pAuthorName, Gender = @pGender, Active = @pActive WHERE AuthorId = @pAuthorId";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@pAuthorName", authorName);
                    cmd.Parameters.AddWithValue("@pGender", Gender);
                    cmd.Parameters.AddWithValue("@pActive", Active);
                    cmd.Parameters.AddWithValue("@pAuthorId", authorId);
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddAuthor(string AuthorName, string Gender, bool Active)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "INSERT INTO ListAuthor(AuthorName, Gender, Active) VALUES(@pAuthorName, @pGender, @pActive)";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@pAuthorName", AuthorName);
                    cmd.Parameters.AddWithValue("@pGender", Gender);
                    cmd.Parameters.AddWithValue("@pActive", Active);
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int UpdateAuthor(int original_authorId, string original_authorName, string original_Gender, bool original_Active, string authorName, string Gender, bool Active)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "UPDATE ListAuthor SET AuthorName = @pAuthorName, Gender = @pGender, Active = @pActive WHERE AuthorId = @pOrgAuthorId AND AuthorName = @pOrgAuthorName AND Gender = @pOrgGender AND Active = @pOrgActive";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@pOrgAuthorName", original_authorName);
                    cmd.Parameters.AddWithValue("@pOrgAuthorId", original_authorId);
                    cmd.Parameters.AddWithValue("@pAuthorName", authorName);
                    cmd.Parameters.AddWithValue("@pGender", Gender);
                    cmd.Parameters.AddWithValue("@pActive", Active);
                    cmd.Parameters.AddWithValue("@pOrgGender", original_Gender);
                    cmd.Parameters.AddWithValue("@pOrgActive", original_Active);
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public List<AuthorModel> GetAllAuthorsPageWise(int StartIndex, int MaximumRows)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = "spGetAuthorsPageWise";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StartIndex", StartIndex);
            cmd.Parameters.AddWithValue("@MaximumRows", MaximumRows);
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
                Author.Gender = DataReader["Gender"].ToString();
                Author.Active = (bool)DataReader["Active"];
                Author.ImageURL = DataReader["ImageURL"].ToString();
                ListAuthor.Add(Author);
            }



            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }

        public int Count()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(AuthorId) FROM ListAuthor";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            cmd.Dispose();

            return count;

        }

        public List<AuthorModel> GetAllAuthorsPageWise2(int PageIndex, int PageSize)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            SqlConnection conn = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader DataReader;

            cmd.CommandText = "spGetAuthorsPageWise2";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageIndex", PageIndex);
            cmd.Parameters.AddWithValue("@PageSize", PageSize);
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
                Author.Gender = DataReader["Gender"].ToString();
                Author.Active = (bool)DataReader["Active"];
                Author.ImageURL = DataReader["ImageURL"].ToString();
                ListAuthor.Add(Author);
            }
            conn.Close();
            cmd.Dispose();
            DataReader.Close();

            return ListAuthor;

        }
    }
}