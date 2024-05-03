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
        public AuthorRepository()
        {
            dbContext = new Dbcontext();
            dbContext.connectDB();

        }
        public AuthorRepository(Dbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        internal void CheckLogin(LoginReqDTO loginReq)
        {
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = @PassWords";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", loginReq.InEmail);
                        sqlCommand.Parameters.AddWithValue("@PassWords", loginReq.InPass);
                        connection.Open(); // Open the connection before executing the command
                        int count = (int)sqlCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công! từ AuthorRepo");
                            //return true;
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại! từ AuthorRepo");
                            //return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorRepository " + ex.Message);
            }

        }
    }
}