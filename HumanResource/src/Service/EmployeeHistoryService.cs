using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class EmployeeHistoryService
    {
        private EmployeeHistoryRepository employeeHistoryRepository;
        private EmployeeHistoryReqDTO employeeHistoryReqDTO;

        public EmployeeHistoryService()
        {

            employeeHistoryRepository = new EmployeeHistoryRepository();
            employeeHistoryReqDTO = new EmployeeHistoryReqDTO();
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
