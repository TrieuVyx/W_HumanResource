using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Controller
{
    internal class EmployeeController
    {
        private readonly EmployeeService employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        internal bool CreateUser(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.CreateUser(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<EmployeeResProfile> ExportPositionHistory(EmployeeResProfile employeeResProfile)
        {
        
            try
            {
                return employeeService.ExportPositionHistory(employeeResProfile);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<EmployeeRotationResDTO> ExportRotationHistory(EmployeeRotationReqDTO employeeRotationReqDTO)
        {
            try
            {
                return employeeService.ExportRotationHistory(employeeRotationReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<EmployeeHistoryResDTO> ExportWorkHistory(EmployeeHistoryResDTO employeeHistoryRes)
        {
            try
            {
                return employeeService.ExportWorkHistory(employeeHistoryRes);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        //internal List<EmployeeResProfile> ExportPositionHistory(EmployeeReqDTO employeeReqDTO)
        //{
        //    try
        //    {
        //        return employeeService.ExportPositionHistory(employeeReqDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
        //    }
        //}

        internal List<Employees> FindAllList()
        {
            try
            {
                return employeeService.FindAllList();
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

        internal bool FindAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.FindAndDelete(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal List<EmployeeReqDTO> FindAndDetail(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.FindAndDetail(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }

        internal bool FindAndUpdate(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.FindAndUpdate(employeeReqDTO);
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

        internal bool MoveDepart(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeService.MoveDepart(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeController " + ex.Message);
            }
        }
    }
}
