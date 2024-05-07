using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class EmployeeHistoryService
    {
        private readonly EmployeeHistoryRepository employeeHistoryRepository;


        public EmployeeHistoryService()
        {

            employeeHistoryRepository = new EmployeeHistoryRepository();
        }

        internal List<EmployeeHistoryReqDTO> FindHistory()
        {
            try
            {
                return employeeHistoryRepository.FindHistory();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeHistoryService " + ex.Message);
            }
        }
    }
}
