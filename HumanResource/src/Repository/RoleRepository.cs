using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.src.DbContext;

namespace HumanResource.src.Repository
{
    internal class RoleRepository
    {
        private Dbcontext dbContext;
        private RoleReqDTO roleReqDTO;
        public RoleRepository() { 
            dbContext = new Dbcontext();
            roleReqDTO = new RoleReqDTO();
        }

        internal List<RoleReqDTO> findAllList()
        {
            List<RoleReqDTO> roleReq= new List<RoleReqDTO>();
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
                                RoleReqDTO roles = new RoleReqDTO();

                                roles.RoleId = reader.GetInt32(reader.GetOrdinal("RoleId"));
                                roles.RoleDesc = reader.GetString(reader.GetOrdinal("RoleDesc"));
                                roles.RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
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
                return null;
            }
        }
    }
}
