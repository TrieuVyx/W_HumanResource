using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace HumanResource.src.Repository
{
    internal class AccountRepository
    {
        private readonly Dbcontext dbcontext;

        public AccountRepository() {
            dbcontext = new Dbcontext();
        }

        internal List<AccountResDTO> FindAllAccount()
        {
            List<AccountResDTO> employeeRes = new List<AccountResDTO>();
            try
            {
                //employee
                using (SqlConnection connection = dbcontext.ConnectOpen())
                {
                    string query = "SELECT * FROM Account ;";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AccountResDTO employee = new AccountResDTO
                                {
                                    AccountId = reader.GetInt32(reader.GetOrdinal("AccountId")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    //AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    //Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    //Email = reader.GetString(reader.GetOrdinal("Email")),
                                    //Gender = reader.GetString(reader.GetOrdinal("Gender"))
                                };
                                employeeRes.Add(employee);
                            }
                        }
                    }
                    return employeeRes;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ AccountRepository " + ex.Message);

                return null;
            }
        }
    }
}
