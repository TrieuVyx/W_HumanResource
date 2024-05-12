using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Request
{
    internal class AuthorResDTO
    {
        private string roleDesc;
        private string roleName;
        private string fullName;
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

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }


    }
}
