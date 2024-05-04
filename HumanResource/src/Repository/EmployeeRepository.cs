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
    }
}
