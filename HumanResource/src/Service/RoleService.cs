using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Service
{
    internal class RoleService
    {
        private RoleRepository roleRepository;
        public RoleService() {
            roleRepository  = new RoleRepository();
        }

        internal List<RoleReqDTO> findAllList()
        {
            try
            {
                return roleRepository.findAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }
    }
}
