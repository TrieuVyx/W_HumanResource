using HumanResource.src.DTO.Request;
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

        internal bool createUser(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.createUser(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
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

        internal List<EmployeeAndDepartmentReqDTO> FindAllUserNotDep()
        {
            try
            {
                return employeeService.FindAllUserNotDep();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal bool findAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.findAndDelete(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<EmployeeReqDTO> findAndDetail(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.findAndDetail(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal bool findAndUpdate(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.findAndUpdate(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<Employees> FindNameEmployee(Employees employee)
        {
            try
            {
                return employeeService.FindNameEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal bool moveDepart(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.moveDepart(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }
    }
}
