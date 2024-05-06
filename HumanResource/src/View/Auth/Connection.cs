using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumanResource.src.View.Auth
{
    internal class Connection
    {

        private static string _connectionString;
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
