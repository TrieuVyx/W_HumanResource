using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class RoleResDTO

    {
        private string roleName;
        private string employeeName;
        private int employId;
        private int accountId;
        public RoleResDTO() { }
        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
   
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }


    }
}
