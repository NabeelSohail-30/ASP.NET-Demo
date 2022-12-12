using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS
{
    public class Publisher
    {
        public List<PublisherModel> Publishers()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM ListPublisher";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<PublisherModel> ListPublisher = new List<PublisherModel>();
                    PublisherModel Publisher;

                    
                    while (DataReader.Read())
                    {
                        Publisher = new PublisherModel();
                        Publisher.PublisherId = (int)DataReader["PublisherId"];
                        Publisher.Publisher = DataReader["Publisher"].ToString();
                        ListPublisher.Add(Publisher);
                    }

                    DataReader.Close();

                    return ListPublisher;
                }
            }
        }

        public int Add(PublisherModel pPublisher)
        {
            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"INSERT INTO ListPublisher(Publisher) VALUES ('{pPublisher.Publisher}'); SELECT SCOPE_IDENTITY()";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    int PublisherId = Convert.ToInt32(cmd.ExecuteScalar());

                    return PublisherId;
                }
            }
        }

        public bool Exist(int pPublisherId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListPublisher WHERE (PublisherId = {pPublisherId})";
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

        public bool Exist(string pPublisher)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListPublisher WHERE (Publisher = '{pPublisher}')";
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

        public PublisherModel Find(int pPublisherId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListPublisher WHERE (PublisherId = {pPublisherId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    PublisherModel publisher;

                    if (DataReader.HasRows)
                    {
                        DataReader.Read();
                        publisher = new PublisherModel();
                        publisher.PublisherId = (int)DataReader["PublisherId"];
                        publisher.Publisher = DataReader["Publisher"].ToString();
                        return publisher;
                    }

                    publisher = new PublisherModel();
                    publisher.PublisherId = (int)DataReader["PublisherId"];
                    publisher.Publisher = DataReader["Publisher"].ToString();

                    DataReader.Close();

                    return publisher;

                }
            }
        }

        public PublisherModel Find(string pPublisher)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM ListPublisher WHERE (Publisher = '{pPublisher}')";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    PublisherModel publisher;

                    if (DataReader.HasRows)
                    {
                        DataReader.Read();
                        publisher = new PublisherModel();
                        publisher.PublisherId = (int)DataReader["PublisherId"];
                        publisher.Publisher = DataReader["Publisher"].ToString();
                        return publisher;
                    }

                    publisher = new PublisherModel();
                    publisher.PublisherId = (int)DataReader["PublisherId"];
                    publisher.Publisher = DataReader["Publisher"].ToString();

                    DataReader.Close();

                    return publisher;

                }
            }
        }
    }
}