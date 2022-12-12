using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace LMS
{
    class Role
    {
        public List<RoleModel> Roles()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM LoginUserRole";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<RoleModel> roles = new List<RoleModel>();
                    RoleModel role;

                    while (DataReader.Read())
                    {
                        role = new RoleModel();
                        role.RoleId = (int)DataReader["RoleId"];
                        role.Role = DataReader["Role"].ToString();
                        role.RoleDescription = DataReader["RoleDescription"].ToString();
                        role.UserCreatedById = (int)DataReader["UserCreatedById"];
                        role.CreationDateTime = (DateTime)DataReader["CreationDateTime"];
                        role.UserLastUpdatedById = (int)DataReader["UserLastUpdatedById"];
                        role.LastUpdatedDateTime = (DateTime)DataReader["LastUpdatedDateTime"];

                        roles.Add(role);
                    }

                    DataReader.Close();

                    return roles;
                }
            }
        }

        public RoleModel Find(int pRoleId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM LoginUserRole WHERE(RoleId = {pRoleId})";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    RoleModel role = new RoleModel();

                    if (DataReader.HasRows)
                    {
                        DataReader.Read();
                        role.RoleId = (int)DataReader["RoleId"];
                        role.Role = DataReader["Role"].ToString();
                        role.RoleDescription = DataReader["RoleDescription"].ToString();
                        role.UserCreatedById = (int)DataReader["UserCreatedById"];
                        role.CreationDateTime = (DateTime)DataReader["CreationDateTime"];
                        role.UserLastUpdatedById = (int)DataReader["UserLastUpdatedById"];
                        role.LastUpdatedDateTime = (DateTime)DataReader["LastUpdatedDateTime"];
                    }

                    DataReader.Close();

                    return role;
                }
            }
        }
    }
}
