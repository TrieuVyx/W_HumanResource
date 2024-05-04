using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Controller
{
    internal class EmployeeController
    {
        private readonly EmployeeService employeeService;
        public EmployeeController() {
            employeeService = new EmployeeService();
        }
        internal List<Employees> findAllList()
        {
            try
            {
                return employeeService.findAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }
    }
}
