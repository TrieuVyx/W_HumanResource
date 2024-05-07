﻿using HumanResource.src.DTO.Request;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;

namespace HumanResource.src.Controller
{
    internal class RoleController
    {
        private RoleService roleService;
        public RoleController()
        {
            roleService = new RoleService();
        }

        internal List<RoleReqDTO> findAllRole()
        {
            try
            {
                return roleService.findAllList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ RoleService " + ex.Message);
            }
        }
    }
}
