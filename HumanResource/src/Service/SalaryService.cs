using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Service
{
    internal class SalaryService
    {
        private readonly SalaryrRepository _salaryrRepository;
        public SalaryService()
        {
            _salaryrRepository = new SalaryrRepository();
        }

        internal List<SalaryResDTO> FindAllList()
        {
            try
            {
                return _salaryrRepository.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ SalaryService " + ex.Message);
            }
        }

        internal List<SalaryEmployeeResDTO> FindEmployee(SalaryReqDTO salaryReqDTO)
        {
            try
            {

                return _salaryrRepository.FindEmployee(salaryReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ SalaryController " + ex.Message);
            }
        }
    }
}