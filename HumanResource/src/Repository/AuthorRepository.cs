using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;

namespace HumanResource.src.Repository
{
    internal class AuthorRepository
    {
        private Dbcontext dbContext;
        private GetQuery getQuery;
        public AuthorRepository()
        {
            dbContext = new Dbcontext();
            getQuery = new GetQuery();

        }
        public AuthorRepository(Dbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        internal bool CheckLogin(LoginReqDTO loginReq)
        {
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    //string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = CONVERT(nvarchar(max), HASHBYTES('MD5', @PassWords), 2)";
                    string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = @PassWords";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    //using (SqlCommand sqlCommand = getQuery.QueryLogin())
                    {
                        string password = dbContext.HashMD5(loginReq.InPass);
                        sqlCommand.Parameters.AddWithValue("@Email", loginReq.InEmail);
                        sqlCommand.Parameters.AddWithValue("@PassWords", dbContext.HashMD5(loginReq.InPass));
                        //sqlCommand.Parameters.AddWithValue("@PassWords", loginReq.InPass);
                        connection.Open();
                        int count = (int)sqlCommand.ExecuteScalar();
                        connection.Close();
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorRepository " + ex.Message);
                return false;
            }

        }
      
    }
}
