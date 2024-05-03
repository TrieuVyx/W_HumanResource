using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DbContext
{
    class GetQuery
    {
        private Dbcontext dbcontext;    
        public GetQuery()
        {
            dbcontext = new Dbcontext();
            dbcontext.connectDB();
        }
        public SqlCommand QueryLogin()
        {
            using(SqlConnection connection = dbcontext.connectOpen())
            {
                string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = @PassWords";
                connection.Open();
                return new SqlCommand(query, connection);

            }
           

        }
    }
}
