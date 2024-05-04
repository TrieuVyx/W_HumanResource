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
