using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //internal bool FindNameDepart(DepartmentReqDTO departmentReqDTO)
        //{
        //    try
        //    {
        //        bool depart = departmentRepository.FindNameDepart(departmentReqDTO);
        //        if (depart)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
        //        return false;

        //    }
        //}
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
                return departmentRepository.findAllList();
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
                return departmentRepository.findIdDepartMent(departmentReqDTO);
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
                return departmentRepository.findAndDelete(employeeResDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DepartmentService " + ex.Message);
            };
        }
    }
}
