using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
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

        internal bool CreateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleRepository.CreateUser(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
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

        internal bool FindAndDelete(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleRepository.FindAndDelete(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }

        internal List<RoleReqDTO> FindAndDetail(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleRepository.FindAndDetail(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }

        internal List<RoleResDTO> FindAndWatch(RoleResDTO roleResDTO)
        {
            try
            {

                return roleRepository.FindAndWatch(roleResDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }

        internal bool UpdateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleRepository.UpdateUser(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }
    }
}
