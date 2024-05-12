using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HumanResource.src.Repository
{
    internal class AuthorRepository
    {
        private readonly Dbcontext dbContext;
        
        //private GetQuery getQuery;
        public AuthorRepository()
        {
            dbContext = new Dbcontext();
            //getQuery = new GetQuery();


        }
       
        internal bool Authorization(LoginReqDTO loginReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    //string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = CONVERT(nvarchar(max), HASHBYTES('MD5', @PassWords), 2)";
                    string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = @PassWords";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    //using (SqlCommand sqlCommand = getQuery.QueryLogin())
                    {
                        string password = dbContext.HashMD5(loginReqDTO.InPass);
                        sqlCommand.Parameters.AddWithValue("@Email", loginReqDTO.InEmail);
                        sqlCommand.Parameters.AddWithValue("@PassWords", dbContext.HashMD5(loginReqDTO.InPass));
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

        internal List<AuthorResDTO> Permission(LoginReqDTO loginReqDTO)
        {
            List<AuthorResDTO> authorRes = new List<AuthorResDTO>();
            try
            {
                //employee
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "SELECT * FROM Employee ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", loginReqDTO.InEmail);
                        connection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AuthorResDTO authorResDTO = new AuthorResDTO
                                {
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    RoleDesc = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    RoleName = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                };
                                authorRes.Add(authorResDTO);
                            }
                        }
                        connection.Close();
                    }
                    return authorRes;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ AuthorRepository " + ex.Message);

                return null;
            }
        }

        internal bool RegisterAccount(RegisterReqDTO registerReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    //string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND PassWords = CONVERT(nvarchar(max), HASHBYTES('MD5', @PassWords), 2)";
                    string query = "INSERT INTO Account (Email, FullName, PassWords) VALUES (@Email, @FullName, @PassWords);";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    //using (SqlCommand sqlCommand = getQuery.QueryLogin())
                    {
                        string password = dbContext.HashMD5(registerReqDTO.PassWords);
                        sqlCommand.Parameters.AddWithValue("@Email", registerReqDTO.Email);
                        sqlCommand.Parameters.AddWithValue("@FullName", registerReqDTO.FullName);
                        sqlCommand.Parameters.AddWithValue("@PassWords", password);
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                        connection.Close();
                        return true;
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
