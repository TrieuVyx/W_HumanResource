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
    internal class EducationRepository
    {
        private readonly Dbcontext dbcontext;
        public EducationRepository() {
        dbcontext = new Dbcontext();    
        }

        internal List<EducationResDTO> FindAllEducation()
        {
            List<EducationResDTO> employeeRes = new List<EducationResDTO>();
            try
            {
                //employee
                using (SqlConnection connection = dbcontext.ConnectOpen())
                {
                    string query = "SELECT * FROM Education ;";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EducationResDTO employee = new EducationResDTO
                                {
                                    EducationId = reader.GetInt32(reader.GetOrdinal("EducationId")),
                                    EducationName = reader.GetString(reader.GetOrdinal("EducationName")),
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
                new Exception("Lỗi Phát Sinh Từ EducationRepository " + ex.Message);

                return null;
            }
        }
    }
}
