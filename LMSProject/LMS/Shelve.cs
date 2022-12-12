using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS
{
    public class Shelve
    {
        public List<ShelveModel> Shelves()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM ListShelve";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<ShelveModel> ListShelve = new List<ShelveModel>();
                    ShelveModel Shelve;

                    while (DataReader.Read())
                    {
                        Shelve = new ShelveModel();
                        Shelve.ShelveId = (int)DataReader["ShelveId"];
                        Shelve.Shelve = (int)DataReader["Shelve"];
                        ListShelve.Add(Shelve);
                    }

                    DataReader.Close();

                    return ListShelve;
                }
            }
        }

        public bool Exist(int pShelveId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListShelve WHERE (ShelveId = {pShelveId})";
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

        public bool Exist(string pShelve)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListShelve WHERE (Shelve = {pShelve})";
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

        public ShelveModel Find(int pShelveId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListShelve WHERE (ShelveId = {pShelveId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    ShelveModel shelve;

                    if (DataReader.HasRows)
                    {
                        shelve = new ShelveModel();
                        DataReader.Read();
                        shelve.ShelveId = (int)DataReader["ShelveId"];
                        shelve.Shelve = (int)DataReader["Shelve"];
                        return shelve;
                    }

                    shelve = new ShelveModel();

                    DataReader.Close();

                    return shelve;
                }
            }
        }

        public ShelveModel Find(string pShelve)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListShelve WHERE (Shelve = {pShelve})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    ShelveModel shelve;

                    if (DataReader.HasRows)
                    {
                        shelve = new ShelveModel();
                        DataReader.Read();
                        shelve.ShelveId = (int)DataReader["ShelveId"];
                        shelve.Shelve = (int)DataReader["Shelve"];
                        return shelve;
                    }

                    shelve = new ShelveModel();

                    DataReader.Close();

                    return shelve;
                }
            }
        }
    }
}