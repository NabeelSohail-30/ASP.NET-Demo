using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS
{
    public class Language
    {
        public List<LanguageModel> Languages()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM ListLanguage";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<LanguageModel> ListLanguage = new List<LanguageModel>();
                    LanguageModel Language;

                    
                    while (DataReader.Read())
                    {
                        Language = new LanguageModel();
                        Language.LanguageId = (int)DataReader["LanguageId"];
                        Language.Language = DataReader["Language"].ToString();
                        ListLanguage.Add(Language);
                    }

                    DataReader.Close();

                    return ListLanguage;
                }
            }
        }

        public bool Exist(int pLanguageId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListLanguage WHERE (LanguageId = {pLanguageId})";
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

        public bool Exist(string pLanguage)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListLanguage WHERE (Language = '{pLanguage}')";
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

        public LanguageModel Find(int pLanguageId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListLanguage WHERE (LanguageId = {pLanguageId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    LanguageModel language;

                    if (DataReader.HasRows)
                    {
                        language = new LanguageModel();
                        language.LanguageId = (int)DataReader["LanguageId"];
                        language.Language = DataReader["Language"].ToString();
                        return language;
                    }

                    language = new LanguageModel();

                    DataReader.Close();

                    return language;
                }
            }
        }

        public LanguageModel Find(string pLanguage)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListLanguage WHERE (LanguageId = '{pLanguage}')";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    LanguageModel language;

                    if (DataReader.HasRows)
                    {
                        language = new LanguageModel();
                        language.LanguageId = (int)DataReader["LanguageId"];
                        language.Language = DataReader["Language"].ToString();
                        return language;
                    }

                    language = new LanguageModel();

                    DataReader.Close();

                    return language;
                }
            }
        }
    }
}