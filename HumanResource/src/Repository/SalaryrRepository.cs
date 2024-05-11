using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
namespace HumanResource.src.Repository
{
    internal class SalaryrRepository
    {
        private readonly Dbcontext _dbContcext;
        public SalaryrRepository() {
            _dbContcext = new Dbcontext();  
        }

        internal List<SalaryResDTO> FindAllList()
        {

            List<SalaryResDTO> salaryResDTOs = new List<SalaryResDTO>();
            try
            {
                using (SqlConnection connection = _dbContcext.ConnectOpen())
                {
                    string query = "SELECT * FROM Salary";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SalaryResDTO roles = new SalaryResDTO
                                {
                                    SalaryId = reader.GetInt32(reader.GetOrdinal("SalaryId")),
                                    SalaryAmount = reader.GetInt32(reader.GetOrdinal("SalaryAmount")),
                                    SalaryDesc = reader.GetString(reader.GetOrdinal("SalaryDesc"))
                                };
                                salaryResDTOs.Add(roles);
                            }
                        }
                        connection.Close();
                    }
                    return salaryResDTOs;
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ RoleRepository " + ex.Message);

                return null;
            }
        }

        internal List<SalaryEmployeeResDTO> FindEmployee(SalaryReqDTO salaryReqDTO)
        {
            List<SalaryEmployeeResDTO> salaryResDTOs = new List<SalaryEmployeeResDTO>();
            try
            {
                using (SqlConnection connection = _dbContcext.ConnectOpen())
                {
                    string query = @"
                                    SELECT *
                                    FROM Salary s
                                    LEFT JOIN Employee e ON e.SalaryId = s.SalaryId
                                    WHERE s.SalaryId = @SalaryId";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@SalaryId", salaryReqDTO.SalaryId);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SalaryEmployeeResDTO roles = new SalaryEmployeeResDTO
                                {
                                    SalaryAmount = reader.GetInt32(reader.GetOrdinal("SalaryAmount")),
                                    SalaryDesc = reader.GetString(reader.GetOrdinal("SalaryDesc")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                };
                                salaryResDTOs.Add(roles);
                            }
                        }
                        connection.Close();
                    }
                    return salaryResDTOs;
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
