using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS
{
    public class Category
    {
        public List<CategoryModel> Categories()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM ListCategory";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<CategoryModel> ListCategory = new List<CategoryModel>();
                    CategoryModel Category;

                    

                    while (DataReader.Read())
                    {
                        Category = new CategoryModel();
                        Category.CategoryId = (int)DataReader["CategoryId"];
                        Category.Category = DataReader["Category"].ToString();
                        ListCategory.Add(Category);
                    }

                    DataReader.Close();

                    return ListCategory;
                }
            }
        }

        public int Add(CategoryModel pCategory)
        {
            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"INSERT INTO ListCategory(Category) VALUES ('{pCategory.Category}'); SELECT SCOPE_IDENTITY()";
                    
                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;

                    if(OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }

                    int categoryId = Convert.ToInt32(cmd.ExecuteScalar());

                    return categoryId;
                }
            }
        }

        public bool Exist(int pCategoryId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT CategoryId FROM ListCategory WHERE (CategoryId = {pCategoryId})";
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

        public bool Exist(string pCategory)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT CategoryId FROM ListCategory WHERE (Category = '{pCategory}')";
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

        public CategoryModel Find(int pCategoryId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCategory WHERE (CategoryId = {pCategoryId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    CategoryModel category;

                    if (DataReader.HasRows)
                    {
                        category = new CategoryModel();
                        DataReader.Read();
                        category.CategoryId = (int)DataReader["CategoryId"];
                        category.Category = DataReader["Category"].ToString();
                        return category;
                    }

                    category = new CategoryModel();

                    DataReader.Close();

                    return category;
                }
            }
        }

        public CategoryModel Find(string pCategory)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCategory WHERE (Category = '{pCategory}')";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    CategoryModel category;

                    if (DataReader.HasRows)
                    {
                        category = new CategoryModel();
                        DataReader.Read();
                        category.CategoryId = (int)DataReader["CategoryId"];
                        category.Category = DataReader["Category"].ToString();
                        return category;
                    }
                    category = new CategoryModel();

                    DataReader.Close();

                    return category;
                }
            }
        }
    }
}