using HumanResource.src.DTO.Request;
using HumanResource.src.Entity;
using HumanResource.src.Repository;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.src.DTO.Response;

namespace HumanResource.src.Controller
{
    internal class DepartmentController
    {
        private DepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        public DepartmentController(DepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        internal List<DepartmentResDTO> findAllList()
        {
            try
            {
                return departmentService.findAllList();
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
                return departmentService.findAndDelete(employeeResDTO);
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
                return departmentService.findIdDepartMent(departmentReqDTO);
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
