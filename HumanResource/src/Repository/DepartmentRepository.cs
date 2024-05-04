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

        internal List<DepartmentResDTO> findAllList()
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
                                DepartmentResDTO department = new DepartmentResDTO();

                                department.DepId = reader.GetInt32(reader.GetOrdinal("DepId"));
                                department.DepDesc = reader.GetString(reader.GetOrdinal("DepDesc"));
                                department.DepType = reader.GetString(reader.GetOrdinal("DepType"));
                                departmentRes.Add(department);
                            }
                        }

                    }
                    return departmentRes;

                }
            }
            catch (Exception ex)
            {
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
                                EmployeeResDTO employee = new EmployeeResDTO();
                                employee.EmployId = reader.GetInt32(reader.GetOrdinal("EmployId"));
                                employee.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                                employee.AddressEmployee = reader.GetString(reader.GetOrdinal("AddressEmployee"));
                                employee.DepId = reader.GetInt32(reader.GetOrdinal("DepId"));
                                employee.DepDesc = reader.GetString(reader.GetOrdinal("DepDesc"));
                                employee.DepType = reader.GetString(reader.GetOrdinal("DepType"));
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
                return null;
            }

        }
    }
}
