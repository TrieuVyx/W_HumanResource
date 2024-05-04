using HumanResource.src.DTO.Request;
using HumanResource.src.DbContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.src.Entity;
using HumanResource.src.DTO.Response;

namespace HumanResource.src.Repository
{
    internal class DepartmentRepository
    {
        private Dbcontext dbContext;
        private EmployeeResDTO employeeResDTO;
        
        public DepartmentRepository()
        {
            dbContext = new Dbcontext();
            employeeResDTO = new EmployeeResDTO();  
        }
        public DepartmentRepository(Dbcontext dbcontext)
        {
            this.dbContext = dbcontext;
        }
        //internal bool FindNameDepart(DepartmentReqDTO departmentReqDTO)
        //{
        //    try
        //    {
        //        List<Employee> employees = new List<Employee>();
        //        BindingSource bindingSource = new BindingSource();
        //        using (SqlConnection connection = dbContext.connectOpen())
        //        {
        //            string query = "SELECT * FROM  Employee e, Department d   WHERE e.DepId = d.DepId AND DepDesc LIKE '%' + @DepDesc + '%'";
        //            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
        //            {
        //                sqlCommand.Parameters.AddWithValue("@DepDesc", departmentReqDTO.DepDesc );
        //                connection.Open();
        //                int count = (int)sqlCommand.ExecuteScalar();
        //                using (SqlDataReader reader = sqlCommand.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Employee employee = new Employee();
        //                        employee.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
        //                        employee.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
        //                        employees.Add(employee); 
        //                    }
        //                }
        //                connection.Close();
        //                if (count > 0)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        internal List<EmployeeResDTO> FindNameDepart(DepartmentReqDTO departmentReqDTO)
        {
            List<EmployeeResDTO> employees = new List<EmployeeResDTO>();
            try
            {
                using (SqlConnection connection = dbContext.connectOpen())
                {
                    string query = "SELECT * FROM Employee e, Department d WHERE e.DepId = d.DepId AND DepDesc LIKE @DepDesc ";
                    //string query = "SELECT * FROM Employee e, Department d WHERE e.DepId = d.DepId AND DepDesc LIKE '%' + @DepDesc + '%'";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DepDesc", departmentReqDTO.DepDesc);
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeResDTO employee = new EmployeeResDTO();
                                employee.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employee.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                                employee.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return employees;
        }
    }
}
