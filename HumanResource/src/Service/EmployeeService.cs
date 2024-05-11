using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class EmployeeService
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();


        }


        internal bool CreateUser(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeRepository.CreateUser(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal List<EmployeeResProfileDTO> ExportPositionHistory(EmployeeResProfileDTO employeeResProfile)
        {
            try
            {
                return employeeRepository.ExportPositionHistory(employeeResProfile);
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
                return employeeRepository.ExportRotationHistory(employeeRotationReqDTO);
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
                return employeeRepository.ExportWorkHistory(employeeHistoryRes);
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
        //        return employeeRepository.ExportPositionHistory(employeeReqDTO);
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
                return employeeRepository.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal List<EmployeeAndDepartmentReqDTO> FindAllUserNotDep()
        {
            try
            {
                return employeeRepository.FindAllUserNotDep();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal bool FindAndDelete(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeRepository.FindAndDelete(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal List<EmployeeReqDTO> FindAndDetail(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeRepository.FindAndDetail(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal bool FindAndUpdate(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeRepository.FindAndUpdate(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal List<Employees> FindNameEmployee(Employees employee)
        {
            try
            {
                return employeeRepository.FindNameEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal List<EmployeeReferencesResDTO> FindReferences(EmployeeReferenceReqDTO employeeReferenceReqDTO)
        {
            try
            {
                return employeeRepository.FindReferences(employeeReferenceReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }

        internal bool MoveDepart(EmployeeReqDTO employeeReqDTO)
        {
            try
            {
                return employeeRepository.MoveDepart(employeeReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EmployeeService " + ex.Message);
            }
        }
    }
}
