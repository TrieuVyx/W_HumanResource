using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Controller
{
    internal class DepartmentController
    {
        private readonly DepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        public DepartmentController(DepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        internal List<DepartmentResDTO> FindAllList()
        {
            try
            {
                return departmentService.FindAllList();
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
                return departmentService.FindAndDelete(employeeResDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }

        internal bool FindAndUpdate(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                return departmentService.FindAndUpdate(departmentReqDTO);
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
                return departmentService.FindIdDepartMent(departmentReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }

        internal List<EmployeeResDTO> FindNameDepart(DepartmentReqDTO departmentReqDTO)
        {
            try
            {
                return departmentService.FindNameDepart(departmentReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            }
        }
    }
}
