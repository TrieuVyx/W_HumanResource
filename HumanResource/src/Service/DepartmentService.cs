using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class DepartmentService
    {
        private readonly DepartmentRepository departmentRepository;

        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }

        internal List<EmployeeResDTO> FindNameDepart(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                return departmentRepository.FindNameDepart(departmentReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }

        internal List<DepartmentResDTO> FindAllList()
        {
            try
            {
                return departmentRepository.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }

        internal List<DepartmentResDTO> FindIdDepartMent(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                return departmentRepository.FindIdDepartMent(departmentReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }


        internal List<EmployeeResDTO> FindAndDelete(EmployeeResDTO employeeResDTO)
        {
            try
            {
                return departmentRepository.FindAndDelete(employeeResDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            };
        }

        internal bool FindAndUpdate(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                return departmentRepository.FindAndUpdate(departmentReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }
    }
}
