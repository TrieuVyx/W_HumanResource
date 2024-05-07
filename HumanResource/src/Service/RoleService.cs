using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Service
{
    internal class RoleService
    {
        private readonly RoleRepository roleRepository;
        public RoleService()
        {
            roleRepository = new RoleRepository();
        }

        internal List<RoleReqDTO> FindAllList()
        {
            try
            {
                return roleRepository.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }
    }
}
