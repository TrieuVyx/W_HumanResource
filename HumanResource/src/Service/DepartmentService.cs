using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class DepartmentService
    {
        private DepartmentRepository departmentRepository;
        public DepartmentService(DepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
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

        internal List<DepartmentResDTO> findAllList()
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

        internal List<DepartmentResDTO> findIdDepartMent(DepartmentReqDTO departmentReqDTO)
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


        internal List<EmployeeResDTO> findAndDelete(EmployeeResDTO employeeResDTO)
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

        internal bool findAndUpdate(DepartmentReqDTO departmentReqDTO)
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
