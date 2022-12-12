using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListCityRepo
    {
        public List<ListCityModel> Find()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            List<ListCityModel> ListCities = new List<ListCityModel>();
            ListCityModel Cities = null;
            ListCountryRepo Country = new ListCountryRepo();

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM ListCity";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Cities = new ListCityModel();
                            Cities.CityId = (int)dr["CityId"];
                            Cities.City = dr["City"].ToString();
                            Cities.CountryId = (int)dr["CountryId"];
                            Cities.Country = Country.Find(Cities.CountryId);
                            ListCities.Add(Cities);
                        }
                    }

                    dr.Close();
                    dr = null;
                }
            }

            return ListCities;
        }

        public ListCityModel Find(int Id)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            ListCityModel Cities = null;
            ListCountryRepo Country = new ListCountryRepo();

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM ListCity WHERE CityId = {Id}";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        Cities = new ListCityModel();
                        Cities.CityId = (int)dr["CityId"];
                        Cities.CountryId = (int)dr["CountryId"];
                        Cities.City = dr["City"].ToString();
                        Cities.Country = Country.Find(Cities.CountryId);

                    }

                    dr.Close();
                    dr = null;
                }
            }

            return Cities;
        }
    }
}