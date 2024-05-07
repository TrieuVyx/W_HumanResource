using System.Data.SqlClient;

namespace HumanResource.src.DbContext
{
    class GetQuery
    {
        private readonly Dbcontext dbcontext;
        public GetQuery()
        {
            dbcontext = new Dbcontext();
            dbcontext.ConnectDB();
        }
        public SqlCommand QueryLogin()
        {
            using (SqlConnection connection = dbcontext.ConnectOpen())
            {
                string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = @PassWords";
                connection.Open();
                return new SqlCommand(query, connection);

            }


        }
    }
}
