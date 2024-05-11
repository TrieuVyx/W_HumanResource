using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Service
{
    internal class EducationService
    {
        private readonly EducationRepository educationRepository;
        public EducationService() {
            educationRepository = new EducationRepository();
        }

        internal List<EducationResDTO> FindAllEducation()
        {
            try
            {
                return educationRepository.FindAllEducation();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EducationService " + ex.Message);
            }
        }
    }
}
