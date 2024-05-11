using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Controller
{
    internal class DegreeController
    {
        private readonly DegreeRepository degreeRepository;
        public DegreeController() {
            degreeRepository = new DegreeRepository();  
        }

        internal List<DegreeResDTO> FindAllDegree()
        {
            try
            {
                return degreeRepository.FindAllDegree();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ DegreeController " + ex.Message);
            }
        }
    }
}
