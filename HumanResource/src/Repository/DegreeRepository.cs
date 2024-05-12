using HumanResource.src.DbContext;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Repository
{
    internal class DegreeRepository
    {
        private readonly Dbcontext dbcontext;
        public DegreeRepository() { 
        dbcontext = new Dbcontext();
        
        }

        internal List<DegreeResDTO> FindAllDegree()
        {
            List<DegreeResDTO> employeeRes = new List<DegreeResDTO>();
            try
            {
                //employee
                using (SqlConnection connection = dbcontext.ConnectOpen())
                {
                    string query = "SELECT * FROM Degree ;";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DegreeResDTO employee = new DegreeResDTO
                                {
                                    DegreeId = reader.GetInt32(reader.GetOrdinal("DegreeId")),
                                    DegreeName = reader.GetString(reader.GetOrdinal("DegreeName")),
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
                new Exception("Lỗi Phát Sinh Từ DegreeRepository " + ex.Message);

                return null;
            }
        }
    }
}
