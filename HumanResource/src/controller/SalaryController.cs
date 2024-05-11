using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Controller
{
    internal class SalaryController
    {
        private readonly SalaryService _salaryService;
        public SalaryController() {
        _salaryService = new SalaryService();
        }

        internal List<SalaryResDTO> FindAllList()
        {
            try
            {
                return _salaryService.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ SalaryController " + ex.Message);
            }
        }

        internal List<SalaryEmployeeResDTO> FindEmployee(SalaryReqDTO salaryReqDTO)
        {
            try
            {
                return _salaryService.FindEmployee(salaryReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ SalaryController " + ex.Message);
            }
        }
    }
}
