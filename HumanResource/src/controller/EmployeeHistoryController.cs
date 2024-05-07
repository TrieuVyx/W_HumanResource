using HumanResource.src.DTO.Request;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Controller
{
    internal class EmployeeHistoryController
    {
        private readonly EmployeeHistoryService employeeHistoryService;
        //private EmployeeHistoryReqDTO employeeHistoryReqDTO;
        public EmployeeHistoryController()
        {
            employeeHistoryService = new EmployeeHistoryService();
            //employeeHistoryReqDTO = new EmployeeHistoryReqDTO();
        }

        internal List<EmployeeHistoryReqDTO> FindHistory()
        {
            try
            {
                return employeeHistoryService.FindHistory();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeHistoryController " + ex.Message);
            }
        }
    }
}
