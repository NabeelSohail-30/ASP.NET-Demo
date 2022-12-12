using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace CsharpWebAppDemo.Database.Models
{
    public class Category
    {
        public List<CategoryModel> GetAllCategories()
        {
            List<CategoryModel> listCategory = new List<CategoryModel>();
            //string CS = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;MultipleActiveResultSets=True;";

            string CS = ConfigurationManager.AppSettings["SqlDbCS"];
            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT CategoryId, Category FROM ListCategory";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DataReader;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    CategoryModel Category;

                    while (DataReader.Read())
                    {
                        Category = new CategoryModel();
                        Category.CategoryId = (int)DataReader["CategoryId"];
                        Category.Category = DataReader["Category"].ToString();
                        listCategory.Add(Category);
                    }
                    DataReader.Close();
                }

            }

            return listCategory;
            //conn.Close();
            //cmd.Dispose();
            
        }
    }
}