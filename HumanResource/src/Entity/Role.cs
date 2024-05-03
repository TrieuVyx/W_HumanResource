using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Entity
{
    internal class Role
    {
        private int roleId;
        private string roleDesc;
        private string roleName;

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        public string RoleDesc
        {
            get { return roleDesc; }
            set { roleDesc = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
    }
}
