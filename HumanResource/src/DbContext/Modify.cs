using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Principal;

namespace HumanResource.src.DbContext
{
    internal class Modify
    {
        SqlCommand SqlCommand;
        SqlDataReader DataReader;
        private readonly Dbcontext dbcontext;
        public Modify()
        {
            this.dbcontext = new Dbcontext();
        }
        public List<NTAccount> Taikhoans(string query)
        {
            List<NTAccount> taikhoans = new List<NTAccount>();
            using (SqlConnection connection = dbcontext.ConnectOpen())
            {
                connection.Open();
                SqlCommand = new SqlCommand(query, connection);
                DataReader = SqlCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    taikhoans.Add(new NTAccount(DataReader.GetString(0), DataReader.GetString(1)));
                }

                connection.Close();
            }
            return taikhoans;

        }
        public void Command(string query)
        {
            using (SqlConnection connection = dbcontext.ConnectOpen())
            {
                connection.Open();
                SqlCommand = new SqlCommand(query, connection);
                SqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
