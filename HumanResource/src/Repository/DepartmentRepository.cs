using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HumanResource.src.Repository
{
    internal class DepartmentRepository
    {
        private readonly Dbcontext dbContext;
        //private EmployeeResDTO employeeResDTO;
        //private DepartmentReqDTO departmentReqDTO;

        public DepartmentRepository()
        {
            dbContext = new Dbcontext();
            //employeeResDTO = new EmployeeResDTO();
            //departmentReqDTO = new DepartmentReqDTO();
        }
        public DepartmentRepository(Dbcontext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        internal List<DepartmentResDTO> FindAllList()
        {

            List<DepartmentResDTO> departmentRes = new List<DepartmentResDTO>();
            try
            {

                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Department";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DepartmentResDTO department = new DepartmentResDTO
                                {
                                    DepId = reader.GetInt32(reader.GetOrdinal("DepId")),
                                    DepDesc = reader.GetString(reader.GetOrdinal("DepDesc")),
                                    DepType = reader.GetString(reader.GetOrdinal("DepType")),
                                    DepPlace = reader.GetString(reader.GetOrdinal("DepPlace"))
                                };
                                departmentRes.Add(department);
                            }
                        }
                    }
                    return departmentRes;

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ DepartmentRepository " + ex.Message);

                return null;
            }
        }

        internal List<EmployeeResDTO> FindAndDelete(EmployeeResDTO employeeResDTO)
        {
            List<EmployeeResDTO> employees = new List<EmployeeResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "UPDATE Employee SET DepId = NULL WHERE EmployId IN (SELECT e.EmployId FROM Department d,Employee e WHERE d.DepId = e.DepId AND e.EmployId = @EmployId) ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeResDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeResDTO employee = new EmployeeResDTO
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"))
                                };
                                employees.Add(employee);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ DepartmentRepository " + ex.Message);

                return null;
            }
        }

        internal bool FindAndUpdate(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "UPDATE Department SET DepPlace = @DepPlace, DepType = @DepType, DepDesc = @DepDesc WHERE DepId = @DepId ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DepId", departmentReqDTO.DepId);
                        sqlCommand.Parameters.AddWithValue("@DepPlace", departmentReqDTO.DepPlace);
                        sqlCommand.Parameters.AddWithValue("@DepType", departmentReqDTO.DepType);
                        sqlCommand.Parameters.AddWithValue("@DepDesc", departmentReqDTO.DepDesc);

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
                new Exception("Lỗi Phát Sinh Từ DepartmentRepository " + ex.Message);

                return false;
            }
        }

        internal List<DepartmentResDTO> FindIdDepartMent(DepartmentReqDTO departmentReqDTO)
        {
            List<DepartmentResDTO> departments = new List<DepartmentResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Department  WHERE DepId = @DepId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DepId", departmentReqDTO.DepId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DepartmentResDTO departmentRes = new DepartmentResDTO
                                {
                                    DepId = reader.GetInt32(reader.GetOrdinal("DepId")),
                                    DepDesc = reader.GetString(reader.GetOrdinal("DepDesc")),
                                    DepPlace = reader.GetString(reader.GetOrdinal("DepPlace")),
                                    DepType = reader.GetString(reader.GetOrdinal("DepType"))
                                };
                                departments.Add(departmentRes);
                            }
                        }
                        connection.Close();
                    }
                    return (departments);

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ DepartmentRepository " + ex.Message);

                return null;
            }
        }

        internal List<EmployeeResDTO> FindNameDepart(DepartmentReqDTO departmentReqDTO)
        {
            List<EmployeeResDTO> employees = new List<EmployeeResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee e, Department d WHERE e.DepId = d.DepId AND DepDesc LIKE @DepDesc ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DepDesc", departmentReqDTO.DepDesc);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeResDTO employee = new EmployeeResDTO
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    DepDesc = reader.GetString(reader.GetOrdinal("DepDesc"))
                                };
                                employees.Add(employee);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ DepartmentRepository " + ex.Message);

                return null;
            }

        }
    }
}
