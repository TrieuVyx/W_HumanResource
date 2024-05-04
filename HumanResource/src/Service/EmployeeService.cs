using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Service
{
    internal class EmployeeService
    {
        private readonly EmployeeRepository employeeRepository;
        public EmployeeService() {
            employeeRepository = new EmployeeRepository();  


        }    
        internal List<Employees> findAllList()
        {
            try
            {
                return employeeRepository.findAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }

        }
    }
}
