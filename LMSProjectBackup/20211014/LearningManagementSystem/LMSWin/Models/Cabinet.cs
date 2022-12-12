using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LMSWin.Models
{
    class Cabinet
    {
        public List<CabinetModel> Cabinets()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM ListCabinet";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<CabinetModel> ListCabinet = new List<CabinetModel>();
                    CabinetModel Cabinet;

                    

                    while (DataReader.Read())
                    {
                        Cabinet = new CabinetModel();
                        Cabinet.CabinetId = (int)DataReader["CabinetId"];
                        Cabinet.Cabinet = DataReader["Cabinet"].ToString();
                        ListCabinet.Add(Cabinet);
                    }

                    DataReader.Close();

                    return ListCabinet;
                }
            }
        }

        public bool Exist(int pCabinetId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCabinet WHERE (CabinetId = {pCabinetId})";
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

        public bool Exist(string pCabinet)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCabinet WHERE (Cabinet = {pCabinet})";
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

        public CabinetModel Find(int pCabinetId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCabinet WHERE (CabinetId = {pCabinetId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    CabinetModel cabinet;

                    if (DataReader.HasRows)
                    {
                        cabinet = new CabinetModel();
                        DataReader.Read();
                        cabinet.CabinetId = (int)DataReader["CabinetId"];
                        cabinet.Cabinet = DataReader["Cabinet"].ToString();

                        return cabinet;
                    }

                    cabinet = new CabinetModel();
                    DataReader.Close();

                    return cabinet;
                }
            }
        }

        public CabinetModel Find(string pCabinet)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListCabinet WHERE (Cabinet = {pCabinet})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    CabinetModel cabinet;

                    if (DataReader.HasRows)
                    {
                        cabinet = new CabinetModel();
                        DataReader.Read();
                        cabinet.CabinetId = (int)DataReader["CabinetId"];
                        cabinet.Cabinet = DataReader["Cabinet"].ToString();

                        return cabinet;
                    }

                    cabinet = new CabinetModel();
                    DataReader.Close();

                    return cabinet;
                }
            }
        }
    }
}
