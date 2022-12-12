using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;MultipleActiveResultSets=True;";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}