using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.src.DbContext;
using System.Data.SqlClient;
using HumanResource.src.Entity;

namespace HumanResource.src.Repository
{
   
    internal class EmployeeRepository
    {

        private Dbcontext dbContext;
        private EmployeeResDTO employeeResDTO;
        private Employees employees;
        private DepartmentReqDTO departmentReqDTO;
        public EmployeeRepository ()
        {
            dbContext = new Dbcontext ();
            employeeResDTO = new EmployeeResDTO ();
            departmentReqDTO = new DepartmentReqDTO ();
            employees = new Employees ();   
        }

        internal List<EmployeeReqDTO> createUser(EmployeeReqDTO employeeReqDTO)
        {
            List<EmployeeReqDTO> employees = new List<EmployeeReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "INSERT INTO Employee (EmployId, Email, EmployeeName, AddressEmployee, Phone, RoleId,  DateOfBirth, Gender) VALUES (@EmployId, @Email, @EmployeeName, @AddressEmployee,@Phone ,@RoleId,@DateOfBirth,@Gender);";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        sqlCommand.Parameters.AddWithValue("@EmployeeName", employeeReqDTO.EmployeeName);
                        sqlCommand.Parameters.AddWithValue("@AddressEmployee", employeeReqDTO.AddressEmployee);
                        sqlCommand.Parameters.AddWithValue("@Phone", employeeReqDTO.Phone);
                        sqlCommand.Parameters.AddWithValue("@Email", employeeReqDTO.Email);
                        sqlCommand.Parameters.AddWithValue("@Gender", employeeReqDTO.Gender);
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", employeeReqDTO.DateOfBirth);
                        sqlCommand.Parameters.AddWithValue("@RoleId", employeeReqDTO.RoleId);
                        connection.Open();

                        //using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        //{
                        //    while (reader.Read())
                        //    {
                        //        EmployeeReqDTO employees1 = new EmployeeReqDTO();
                        //        employees1.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                        //        employees1.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                        //        employees1.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                        //        employees1.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                        //        employees1.Email = reader.GetString(reader.GetOrdinal("Email"));
                        //        employees1.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        //        employees1.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                        //        employees1.RoleId = reader.GetInt32(reader.GetOrdinal("RoleId"));
                        //        employees.Add(employees1);
                        //    }
                        //}
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<Employees> findAllList()
        {
            List<Employees> employeeRes = new List<Employees>();
            try
            {

                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employees employee= new Employees();

                                employee.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employee.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                                employee.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                                employee.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                                employee.Avatar = reader.GetString(reader.GetOrdinal("Avatar"));
                                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                                employeeRes.Add(employee);
                            }
                        }
                    }
                    return employeeRes;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<EmployeeReqDTO> findAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            List<EmployeeReqDTO> employees = new List<EmployeeReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee WHERE EmployId = @EmployId ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeReqDTO employees1 = new EmployeeReqDTO();
                                employees1.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employees.Add(employees1);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<EmployeeReqDTO> findAndDetail(EmployeeReqDTO employeeReqDTO)
        {
            List<EmployeeReqDTO> employees = new List<EmployeeReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r\r\nWHERE e.EmployId = @EmployId\r\nAND  e.DepId =  d.DepId\r\nAND e.EducationId = ed.EducationId\r\nAND e.DegreeId = de.DegreeId\r\nAND e.RoleId = r.RoleId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeReqDTO employees1 = new EmployeeReqDTO();
                                employees1.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employees1.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                                employees1.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                                employees1.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                                employees1.Email = reader.GetString(reader.GetOrdinal("Email"));
                                employees1.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                                employees1.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                                employees1.EducationName = reader.GetString(reader.GetOrdinal("EducationName"));
                                employees1.DegreeName = reader.GetString(reader.GetOrdinal("DegreeName"));
                                employees1.DepDesc = reader.GetString(reader.GetOrdinal("DepDesc"));
                                employees1.RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
                                employees.Add(employees1);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<EmployeeReqDTO> findAndUpdate(EmployeeReqDTO employeeReqDTO)
        {
            List<EmployeeReqDTO> employees = new List<EmployeeReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee WHERE EmployId = @EmployId ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeReqDTO employees1 = new EmployeeReqDTO();
                                employees1.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employees.Add(employees1);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<Employees> FindNameEmployee(Employees employee)
        {
            List<Employees> employees = new List<Employees>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee WHERE EmployeeName LIKE  '%' + @EmployeeName + '%'";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employees employees1 = new Employees();
                                employees1.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employees1.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                                employees1.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                                employees1.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                                employees1.Email = reader.GetString(reader.GetOrdinal("Email"));
                                employees1.Avatar = reader.GetString(reader.GetOrdinal("Avatar"));
                                employees1.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                                employees.Add(employees1);
                            }
                        }
                        connection.Close();
                    }
                    return (employees);

                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
