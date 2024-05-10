﻿using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HumanResource.src.Repository
{

    internal class EmployeeRepository
    {

        private readonly Dbcontext dbContext;
        //private EmployeeResDTO employeeResDTO;
        //private Employees employees;
        //private DepartmentReqDTO departmentReqDTO;
        public EmployeeRepository()
        {
            dbContext = new Dbcontext();
            //employeeResDTO = new EmployeeResDTO ();
            //departmentReqDTO = new DepartmentReqDTO ();
            //employees = new Employees ();   
        }
        internal bool CreateUser(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
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
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return false;
            }
        }

        internal List<Employees> FindAllList()
        {
            List<Employees> employeeRes = new List<Employees>();
            try
            {

                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "SELECT * FROM Employee";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employees employee = new Employees
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender"))
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal List<EmployeeAndDepartmentReqDTO> FindAllUserNotDep()
        {
            List<EmployeeAndDepartmentReqDTO> employeeRes = new List<EmployeeAndDepartmentReqDTO>();
            try
            {

                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "SELECT * FROM Employee WHERE DepId IS NULL";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeAndDepartmentReqDTO employee = new EmployeeAndDepartmentReqDTO
                                {
                                    //employee.DepId = reader.GetInt32(reader.GetOrdinal("DepId"));
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender"))
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal bool FindxAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "DELETE FROM Employee WHERE EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return false;
            }
        }

        internal List<EmployeeReqDTO> FindAndDetail(EmployeeReqDTO employeeReqDTO)
        {
            List<EmployeeReqDTO> employees = new List<EmployeeReqDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    //string query = "SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r\r\nWHERE e.EmployId = @EmployId\r\nAND  e.DepId =  d.DepId\r\nAND e.EducationId = ed.EducationId\r\nAND e.DegreeId = de.DegreeId\r\nAND e.RoleId = r.RoleId";
                    string query = @"SELECT *
                        FROM Employee e
                        LEFT JOIN Department d ON e.DepId = d.DepId
                        LEFT JOIN Education ed ON e.EducationId = ed.EducationId
                        LEFT JOIN Degree de ON e.DegreeId = de.DegreeId
                        LEFT JOIN Roles r ON e.RoleId = r.RoleId
                        WHERE e.EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeReqDTO employees1 = new EmployeeReqDTO
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),



                                    EducationName = reader.IsDBNull(reader.GetOrdinal("EducationName")) ? string.Empty : reader.GetString(reader.GetOrdinal("EducationName")),
                                    DegreeName = reader.IsDBNull(reader.GetOrdinal("DegreeName")) ? string.Empty : reader.GetString(reader.GetOrdinal("DegreeName")),
                                    DepDesc = reader.IsDBNull(reader.GetOrdinal("DepDesc")) ? string.Empty : reader.GetString(reader.GetOrdinal("DepDesc")),
                                    RoleName = reader.IsDBNull(reader.GetOrdinal("RoleName")) ? string.Empty : reader.GetString(reader.GetOrdinal("RoleName")),
                                    RoleId = reader.IsDBNull(reader.GetOrdinal("RoleId")) ? 0 : reader.GetInt32(reader.GetOrdinal("RoleId")),
                                    DepId = reader.IsDBNull(reader.GetOrdinal("DepId")) ? 0 : reader.GetInt32(reader.GetOrdinal("DepId"))
                                };
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal bool FindAndUpdate(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "UPDATE Employee SET EmployeeName = @EmployeeName, AddressEmployee = @AddressEmployee, Phone = @Phone, Email = @Email, DateOfBirth = @DateOfBirth , Gender = @Gender  WHERE EmployId = @EmployId";
                    //string query = "UPDATE Employee SET EmployeeName = @EmployeeName, AddressEmployee = @AddressEmployee, Phone = @Phone, Email = @Email, DateOfBirth = @DateOfBirth , Gender = @Gender , DepId = @DepId, DegreeId = @DegreeId,EducationId = @EducationId WHERE EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        sqlCommand.Parameters.AddWithValue("@EmployeeName", employeeReqDTO.EmployeeName);
                        sqlCommand.Parameters.AddWithValue("@AddressEmployee", employeeReqDTO.AddressEmployee);
                        sqlCommand.Parameters.AddWithValue("@Phone", employeeReqDTO.Phone);
                        sqlCommand.Parameters.AddWithValue("@Email", employeeReqDTO.Email);
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", employeeReqDTO.DateOfBirth);
                        sqlCommand.Parameters.AddWithValue("@Gender", employeeReqDTO.Gender);
                        //sqlCommand.Parameters.AddWithValue("@EducationId", employeeReqDTO.Gender);
                        //sqlCommand.Parameters.AddWithValue("@DepId", employeeReqDTO.Gender);
                        //sqlCommand.Parameters.AddWithValue("@DegreeId", employeeReqDTO.Gender);
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return false;
            }
        }

        internal List<Employees> FindNameEmployee(Employees employee)
        {
            List<Employees> employees = new List<Employees>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
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
                                Employees employees1 = new Employees
                                {
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Avatar = reader.GetString(reader.GetOrdinal("Avatar")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender"))
                                };
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }

        }

        internal bool MoveDepart(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "UPDATE Employee SET DepId = @DepId WHERE EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        sqlCommand.Parameters.AddWithValue("@DepId", employeeReqDTO.DepId);

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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return false;
            }
        }

        internal bool FindAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            throw new NotImplementedException();
        }


        internal List<EmployeeResProfile> ExportPositionHistory(EmployeeResProfile employeeResProfile)
        {
            List<EmployeeResProfile> employees = new List<EmployeeResProfile>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = @"SELECT E.EmployId, E.EmployeeName, E.Email,  E.AddressEmployee, E.DateOfBirth, E.Phone, 
                                           E.Gender, R.RoleName, D.DepDesc, S.SalaryAmount, Edu.EducationName, Deg.DegreeName, 
                                           RE.FullName as RelativeName, RE.Relationship, RE.PhoneNumber, RE.AddressRelative
                                    FROM Employee E
                                    LEFT JOIN Roles R ON E.RoleId = R.RoleId
                                    LEFT JOIN Department D ON E.DepId = D.DepId
                                    LEFT JOIN Salary S ON E.SalaryId = S.SalaryId
                                    LEFT JOIN Education Edu ON E.EducationId = Edu.EducationId
                                    LEFT JOIN Degree Deg ON E.DegreeId = Deg.DegreeId
                                    LEFT JOIN RelativeEmployee RE ON E.RelativeId = RE.RelativeId
                                    WHERE E.EmployId = @EmployId";
                    
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeResProfile.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeResProfile employees1 = new EmployeeResProfile
                                {

                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    RoleName = reader.IsDBNull(reader.GetOrdinal("RoleName")) ? string.Empty : reader.GetString(reader.GetOrdinal("RoleName")),
                                    DegreeName = reader.IsDBNull(reader.GetOrdinal("DegreeName")) ? string.Empty : reader.GetString(reader.GetOrdinal("DegreeName")),
                                    EducationName = reader.IsDBNull(reader.GetOrdinal("EducationName")) ? string.Empty : reader.GetString(reader.GetOrdinal("EducationName")),
                                    DepDesc = reader.IsDBNull(reader.GetOrdinal("DepDesc")) ? string.Empty : reader.GetString(reader.GetOrdinal("DepDesc")),
                                    //FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? string.Empty : reader.GetString(reader.GetOrdinal("FullName")),
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    DateOfBirth = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    SalaryAmount = reader.IsDBNull(reader.GetOrdinal("SalaryAmount")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryAmount")),
                                    RelationShip = reader.IsDBNull(reader.GetOrdinal("RelationShip")) ? string.Empty : reader.GetString(reader.GetOrdinal("Relationship")),
                                    PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? string.Empty : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    AddressRelative = reader.IsDBNull(reader.GetOrdinal("AddressRelative")) ? string.Empty : reader.GetString(reader.GetOrdinal("AddressRelative")),

                                };
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }

        internal List<EmployeeHistoryResDTO> ExportWorkHistory(EmployeeHistoryResDTO employeeHistoryRes)
        {
            List<EmployeeHistoryResDTO> employees = new List<EmployeeHistoryResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = @"SELECT E.EmployId, E.EmployeeName, EH.StartDate, EH.EndDate, EH.Staging
                                    FROM Employee E
                                    INNER JOIN EmployeeHistory EH ON E.EmployId = EH.EmployId
                                    WHERE E.EmployId =  @EmployId 
                                    ORDER BY EH.StartDate;";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeHistoryRes.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeHistoryResDTO employees1 = new EmployeeHistoryResDTO
                                {

                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("StartDate")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("EndDate")),
                                    Staging = reader.GetString(reader.GetOrdinal("Staging")),

                                };
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
                new Exception("Lỗi Phát Sinh Từ EmployeeRepository " + ex.Message);

                return null;
            }
        }
    }
}
