using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                    string query = "INSERT INTO Employee ( Email, EmployeeName, AddressEmployee, Phone, RoleId,  DateOfBirth, Gender) VALUES ( @Email, @EmployeeName, @AddressEmployee,@Phone ,@RoleId,@DateOfBirth,@Gender);";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {

                        //sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
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
                //employee
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
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    //Avatar = reader.GetString(reader.GetOrdinal("Avatar"))
                                };
                                employeeRes.Add(employee);
                            }
                        }
                        connection.Close(); 
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
                        connection.Close();
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
                                    LEFT JOIN EmployeeHistory eh ON e.EmployId = eh.EmployId
                                    LEFT JOIN Salary s ON e.SalaryId = s.SalaryId
                                    LEFT JOIN Account ac ON e.AccountId = ac.AccountId
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

                                    EducationId = reader.IsDBNull(reader.GetOrdinal("EducationId")) ? 0 : reader.GetInt32(reader.GetOrdinal("EducationId")),
                                    DegreeId = reader.IsDBNull(reader.GetOrdinal("DegreeId")) ? 0 : reader.GetInt32(reader.GetOrdinal("DegreeId")),
                                    EducationName = reader.IsDBNull(reader.GetOrdinal("EducationName")) ? string.Empty : reader.GetString(reader.GetOrdinal("EducationName")),
                                    DegreeName = reader.IsDBNull(reader.GetOrdinal("DegreeName")) ? string.Empty : reader.GetString(reader.GetOrdinal("DegreeName")),
                                    DepDesc = reader.IsDBNull(reader.GetOrdinal("DepDesc")) ? string.Empty : reader.GetString(reader.GetOrdinal("DepDesc")),
                                    RoleName = reader.IsDBNull(reader.GetOrdinal("RoleName")) ? string.Empty : reader.GetString(reader.GetOrdinal("RoleName")),
                                    RoleId = reader.IsDBNull(reader.GetOrdinal("RoleId")) ? 0 : reader.GetInt32(reader.GetOrdinal("RoleId")),
                                    DepId = reader.IsDBNull(reader.GetOrdinal("DepId")) ? 0 : reader.GetInt32(reader.GetOrdinal("DepId")),
                                    AccountId = reader.IsDBNull(reader.GetOrdinal("AccountId")) ? 0 : reader.GetInt32(reader.GetOrdinal("AccountId")),
                                    SalaryAmount = reader.IsDBNull(reader.GetOrdinal("SalaryAmount")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryAmount")),
                                    StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("StartDate")),
                                    Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? string.Empty : reader.GetString(reader.GetOrdinal("Avatar")),

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
                    string query = "UPDATE Employee SET EmployeeName = @EmployeeName, AddressEmployee = @AddressEmployee, Phone = @Phone, Email = @Email, DateOfBirth = @DateOfBirth , Gender = @Gender ,AccountId = @AccountId ,DepId = @DepId , EducationId = @EducationId, RoleId = @RoleId, DegreeId = @DegreeId WHERE  EmployId = @EmployId ";
                    //string query = "UPDATE Employee SET EmployeeName = @EmployeeName, AddressEmployee = @AddressEmployee, Phone = @Phone, Email = @Email, DateOfBirth = @DateOfBirth , Gender = @Gender , DepId = @DepId, DegreeId = @DegreeId,EducationId = @EducationId WHERE EmployId = @EmployId";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        sqlCommand.Parameters.AddWithValue("@AccountId", employeeReqDTO.AccountId);
                        sqlCommand.Parameters.AddWithValue("@DegreeId", employeeReqDTO.DegreeId);
                        sqlCommand.Parameters.AddWithValue("@EducationId", employeeReqDTO.EducationId);
                        sqlCommand.Parameters.AddWithValue("@RoleId", employeeReqDTO.RoleId);
                        sqlCommand.Parameters.AddWithValue("@DepId", employeeReqDTO.DepId);
                        sqlCommand.Parameters.AddWithValue("@EmployeeName", employeeReqDTO.EmployeeName);
                        sqlCommand.Parameters.AddWithValue("@AddressEmployee", employeeReqDTO.AddressEmployee);
                        sqlCommand.Parameters.AddWithValue("@Phone", employeeReqDTO.Phone);
                        sqlCommand.Parameters.AddWithValue("@Email", employeeReqDTO.Email);
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", employeeReqDTO.DateOfBirth);
                        sqlCommand.Parameters.AddWithValue("@Gender", employeeReqDTO.Gender);
                   
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


        internal List<EmployeeResProfileDTO> ExportPositionHistory(EmployeeResProfileDTO employeeResProfile)
        {
            List<EmployeeResProfileDTO> employees = new List<EmployeeResProfileDTO>();
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
                                EmployeeResProfileDTO employees1 = new EmployeeResProfileDTO
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
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    DateOfBirth = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    SalaryAmount = reader.IsDBNull(reader.GetOrdinal("SalaryAmount")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryAmount")),
                                    RelationShip = reader.IsDBNull(reader.GetOrdinal("RelationShip")) ? string.Empty : reader.GetString(reader.GetOrdinal("Relationship")),
                                    PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? string.Empty : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    AddressRelative = reader.IsDBNull(reader.GetOrdinal("AddressRelative")) ? string.Empty : reader.GetString(reader.GetOrdinal("AddressRelative")),
                                    FullName = reader.IsDBNull(reader.GetOrdinal("RelativeName")) ? string.Empty : reader.GetString(reader.GetOrdinal("RelativeName")),

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

        internal List<EmployeeRotationResDTO> ExportRotationHistory(EmployeeRotationReqDTO employeeRotationReqDTO)
        {
            List<EmployeeRotationResDTO> employees = new List<EmployeeRotationResDTO>();
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
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeRotationReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeRotationResDTO employees1 = new EmployeeRotationResDTO
                                {

                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("StartDate")),
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

        internal List<EmployeeReferencesResDTO> FindReferences(EmployeeReferenceReqDTO employeeReferenceReqDTO)
        {
            List<EmployeeReferencesResDTO> employees = new List<EmployeeReferencesResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = @"SELECT * FROM Employee E 
                                    LEFT JOIN RelativeEmployee RE ON E.RelativeId = RE.RelativeId
                                    WHERE EmployId = @EmployId";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReferenceReqDTO.EmployId);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeReferencesResDTO employees1 = new EmployeeReferencesResDTO
                                {

                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    RelativeId = reader.GetInt32(reader.GetOrdinal("RelativeId")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    AddressRelative = reader.GetString(reader.GetOrdinal("AddressRelative")),
                                    Relationship = reader.GetString(reader.GetOrdinal("Relationship")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),

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

        internal bool UpdateHistory(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                using (SqlConnection connection = dbContext.ConnectOpen())
                {
                    string query = "INSERT INTO EmployeeHistory (EmployId, StartDate, Staging,Activities)\r\nVALUES \r\n    (@EmployId, @StartDate,@Staging,@Activities);";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EmployId", employeeReqDTO.EmployId);
                        sqlCommand.Parameters.AddWithValue("@StartDate", DateTime.Now);
                        sqlCommand.Parameters.AddWithValue("@Activities", "Transfer");
                        sqlCommand.Parameters.AddWithValue("@Staging", "Active");

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

        public void SaveFile(byte[] fileData, int employId)
        {
            
            using (SqlConnection connection = dbContext.ConnectOpen())
            {
                string base64Image = Convert.ToBase64String(fileData);

                string query = "UPDATE Employee SET Avatar = @Avatar WHERE EmployId = @EmployId";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Avatar", base64Image);
                    sqlCommand.Parameters.AddWithValue("@EmployId", employId);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    connection.Close();
                }
            }
        }
       
    }
}
