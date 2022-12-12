using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListCountryRepo
    {
        public List<ListCountryModel> Find()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            List<ListCountryModel> ListCountry = new List<ListCountryModel>();
            ListCountryModel Country = null;
            ListContinentRepo Continent = new ListContinentRepo();

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM ListCountry";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Country = new ListCountryModel();
                            Country.CountryId = (int)dr["CountryId"];
                            Country.Country = dr["Country"].ToString();
                            Country.ContinentId = (int)dr["ContinentId"];
                            Country.Continent = Continent.Find((int)dr["ContinentId"]);
                            ListCountry.Add(Country);
                        }
                    }

                    dr.Close();
                    dr = null;
                }
            }

            return ListCountry;
        }

        public ListCountryModel Find(int Id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            ListCountryModel Country = null;
            ListContinentRepo Continent = new ListContinentRepo();


            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM ListCountry WHERE CountryId = {Id}";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        Country = new ListCountryModel();
                        Country.CountryId = (int)dr["CountryId"];
                        Country.Country = dr["Country"].ToString();
                        Country.ContinentId = (int)dr["ContinentId"];
                        Country.Continent = Continent.Find((int)dr["ContinentId"]);

                    }

                    dr.Close();
                    dr = null;
                }
            }

            return Country;
        }

        public List<ListCountryModel> FindByContinent(int Id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            List<ListCountryModel> ListCountry = new List<ListCountryModel>();
            ListCountryModel Country = null;
            ListContinentRepo Continent = new ListContinentRepo();


            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM ListCountry WHERE ContinentId = {Id}";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Country = new ListCountryModel();
                            Country.CountryId = (int)dr["CountryId"];
                            Country.Country = dr["Country"].ToString();
                            ListCountry.Add(Country);
                        }
                    }

                    dr.Close();
                    dr = null;
                }
            }

            return ListCountry;
        }
    }
}