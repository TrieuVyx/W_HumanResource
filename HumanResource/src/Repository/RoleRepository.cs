using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HumanResource.src.Repository
{
    internal class RoleRepository
    {
        private readonly Dbcontext dbContext;
        //private RoleReqDTO roleReqDTO;
        public RoleRepository()
        {
            dbContext = new Dbcontext();
            //roleReqDTO = new RoleReqDTO();
        }

        internal List<RoleReqDTO> FindAllList()
        {
            List<RoleReqDTO> roleReq = new List<RoleReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Roles";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RoleReqDTO roles = new RoleReqDTO
                                {
                                    RoleId = reader.GetInt32(reader.GetOrdinal("RoleId")),
                                    RoleDesc = reader.GetString(reader.GetOrdinal("RoleDesc")),
                                    RoleName = reader.GetString(reader.GetOrdinal("RoleName"))
                                };
                                roleReq.Add(roles);
                            }
                        }
                        connection.Close();
                    }
                    return roleReq;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ RoleRepository " + ex.Message);

                return null;
            }
        }
    }
}
