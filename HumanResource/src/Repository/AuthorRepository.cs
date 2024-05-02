using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.src.DbContext;

namespace HumanResource.src.Repository
{
    internal class AuthorRepository
    {
        private Dbcontext dbContext;

        public AuthorRepository(Dbcontext dbContext)
        {
            this.dbContext = dbContext;
        }

        internal bool CheckLogin(string inEmail, string inPass)
        {
            try {
                SqlCommand sqlCommand = new SqlCommand();
                String Query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND PassWords = @PassWords";
                dbContext.connectDB();
                sqlCommand.CommandText = Query;

                sqlCommand.Parameters.AddWithValue("@Email", inEmail);
                sqlCommand.Parameters.AddWithValue("@PassWords", inPass);
                int result = (int)sqlCommand.ExecuteScalar();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
