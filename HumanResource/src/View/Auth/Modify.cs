using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Principal;

namespace HumanResource.src.View.Auth
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand SqlCommand;
        SqlDataReader DataReader;
        public List<NTAccount> taikhoans(string query)
        {
            List<NTAccount> taikhoans = new List<NTAccount>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                DataReader = SqlCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    taikhoans.Add(new NTAccount(DataReader.GetString(0), DataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
            return taikhoans;

        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}



