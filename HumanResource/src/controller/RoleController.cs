using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Controller
{
    internal class RoleController
    {
        private readonly RoleService roleService;
        public RoleController()
        {
            roleService = new RoleService();
        }

        internal bool CreateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleService.CreateUser(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

  

        internal List<RoleReqDTO> FindAllRole()
        {
            try
            {
                return roleService.FindAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        internal bool FindAndDelete(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleService.FindAndDelete(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        internal List<RoleReqDTO> FindAndDetail(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleService.FindAndDetail(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        internal List<RoleResDTO> FindAndWatch(RoleResDTO roleResDTO)
        {
            try
            {
                return roleService.FindAndWatch(roleResDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        internal bool UpdateUser(RoleReqDTO roleReqDTO)
        {
            try
            {
                return roleService.UpdateUser(roleReqDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }
    }
}
