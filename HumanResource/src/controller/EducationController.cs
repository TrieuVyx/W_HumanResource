using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Controller
{
    internal class EducationController
    {

        private readonly EducationService educationService;
        public EducationController() {
        
            educationService = new EducationService();  
        
        }

        internal List<EducationResDTO> FindAllEducation()
        {
            try
            {
                return educationService.FindAllEducation();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ EducationController " + ex.Message);
            }
        }
    }
}
