using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListContinentRepo
    {
        public List<ListContinentModel> Find()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            List<ListContinentModel> ListContinent = new List<ListContinentModel>();
            ListContinentModel Continent = null;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM ListContinent";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Continent = new ListContinentModel();
                            Continent.ContinentId = (int)dr["ContinentId"];
                            Continent.Continent = dr["Continent"].ToString();
                            ListContinent.Add(Continent);
                        }
                    }

                    dr.Close();
                    dr = null;
                }
            }

            return ListContinent;
        }

        public ListContinentModel Find(int Id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            ListContinentModel Continent = null;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM ListContinent WHERE ContinentId = {Id}";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        Continent = new ListContinentModel();
                        Continent.ContinentId = (int)dr["ContinentId"];
                        Continent.Continent = dr["Continent"].ToString();
                    }

                    dr.Close();
                    dr = null;
                }
            }

            return Continent;
        }
    }
}