using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using Microsoft.Identity.Client;
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

        internal bool CreateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "INSERT INTO Roles (RoleId, RoleName, RoleDesc) VALUES (@RoleId, @RoleName, @RoleDesc)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {

                        sqlCommand.Parameters.AddWithValue("@RoleId", roleReqDTO.RoleId);
                        sqlCommand.Parameters.AddWithValue("@RoleName", roleReqDTO.RoleName);
                        sqlCommand.Parameters.AddWithValue("@RoleDesc", roleReqDTO.RoleDesc);
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
                new Exception("Lỗi Phát Sinh Từ RoleRepository " + ex.Message);

                return false;
            }
        }

        internal List<RoleReqDTO> FindAllList()
        {
            List<RoleReqDTO> roleReq = new List<RoleReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "SELECT * FROM Roles r , Employee e WHERE r.RoleId = e.RoleId";
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
                                    RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"))
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

        internal bool FindAndDelete(RoleReqDTO roleReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "DELETE FROM Roles WHERE RoleId = @RoleId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@RoleId", roleReqDTO.RoleId);
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                        connection.Close();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ RoleRepository " + ex.Message);

                return false;
            }
        }

        internal List<RoleReqDTO> FindAndDetail(RoleReqDTO roleReqDTO)
        {
            List<RoleReqDTO> roleReqs = new List<RoleReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    //string query = "SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r\r\nWHERE e.EmployId = @EmployId\r\nAND  e.DepId =  d.DepId\r\nAND e.EducationId = ed.EducationId\r\nAND e.DegreeId = de.DegreeId\r\nAND e.RoleId = r.RoleId";
                    string query = @"SELECT *
                        FROM Roles
                        WHERE RoleId = @RoleId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@RoleId", roleReqDTO.RoleId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RoleReqDTO roleReq = new RoleReqDTO
                                {
                                    RoleId = reader.GetInt32(reader.GetOrdinal("RoleId")),
                                    RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                    RoleDesc = reader.GetString(reader.GetOrdinal("RoleDesc")),
                                };
                                roleReqs.Add(roleReq);
                            }
                        }
                        connection.Close();
                    }
                    return (roleReqs);

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal List<RoleResDTO> FindAndWatch(RoleResDTO roleResDTO)
        {
            List<RoleResDTO> roleReqs = new List<RoleResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    //string query = "SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r\r\nWHERE e.EmployId = @EmployId\r\nAND  e.DepId =  d.DepId\r\nAND e.EducationId = ed.EducationId\r\nAND e.DegreeId = de.DegreeId\r\nAND e.RoleId = r.RoleId";
                    string query = @"SELECT *
                        FROM Employee e
                        LEFT JOIN Account a ON e.AccountId = a.AccountId
                        LEFT JOIN Roles r ON e.RoleId = r.RoleId

                        WHERE e.EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", roleResDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RoleResDTO roleRes = new RoleResDTO
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    AccountId = reader.GetInt32(reader.GetOrdinal("AccountId")),
                                    RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"))
                            
    };
                                roleReqs.Add(roleRes);
                            }
                        }
                        connection.Close();
                    }
                    return (roleReqs);

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal bool UpdateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "UPDATE Roles SET RoleId = @RoleId, RoleName = @RoleName, RoleDesc = @RoleDesc WHERE RoleId = @RoleId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@RoleId", roleReqDTO.RoleId);
                        sqlCommand.Parameters.AddWithValue("@RoleName", roleReqDTO.RoleName);
                        sqlCommand.Parameters.AddWithValue("@RoleDesc", roleReqDTO.RoleDesc);
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                        connection.Close();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ RoleRepository " + ex.Message);

                return false;
            }
        }
    }
}
