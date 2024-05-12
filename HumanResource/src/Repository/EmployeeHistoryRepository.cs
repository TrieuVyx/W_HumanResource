using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HumanResource.src.Repository
{
    internal class EmployeeHistoryRepository
    {
        private readonly Dbcontext dbcontext;
        //private EmployeeHistoryReqDTO employeeHistoryReqDTO;
        public EmployeeHistoryRepository()
        {
            dbcontext = new Dbcontext();
            //employeeHistoryReqDTO = new EmployeeHistoryReqDTO();
        }

        internal List<EmployeeHistoryReqDTO> FindHistory()
        {
            List<EmployeeHistoryReqDTO> employeeHistoryReqDTO = new List<EmployeeHistoryReqDTO>();
            try
            {

                using (SqlConnection connection = dbcontext.ConnectOpen())
                {
                    string query = "SELECT * FROM EmployeeHistory";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeHistoryReqDTO employeeHistoryReqDTO1 = new EmployeeHistoryReqDTO
                                {
                                    HistoryId = reader.GetInt32(reader.GetOrdinal("HistoryId")),
                                    EmployId = reader.GetInt32(reader.GetOrdinal("EmployId")),
                                    Staging = reader.GetString(reader.GetOrdinal("Staging"))
                                };
                                int startDateOrdinal = reader.GetOrdinal("StartDate");
                                int endDateOrdinal = reader.GetOrdinal("EndDate");
                                if (!reader.IsDBNull(startDateOrdinal))
                                {
                                    employeeHistoryReqDTO1.StartDate = reader.GetDateTime(startDateOrdinal);
                                }
                                if (!reader.IsDBNull(endDateOrdinal))
                                {
                                    employeeHistoryReqDTO1.EndDate = reader.GetDateTime(endDateOrdinal);
                                }
                                employeeHistoryReqDTO.Add(employeeHistoryReqDTO1);
                            }
                        }
                        connection.Close(); 
                    }
                    return employeeHistoryReqDTO;

                }
            }
            catch (Exception ex)
            {
                new Exception("Lỗi Phát Sinh Từ EmployeeHistoryRepository " + ex.Message);

                return null;
            }
        }
    }
}
