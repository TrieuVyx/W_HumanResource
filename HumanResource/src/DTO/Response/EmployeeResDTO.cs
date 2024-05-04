using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class EmployeeResDTO
    {
        private int employId;
        private string email;
        private string employeeName;
        private string avatar;
        private string addressEmployee;
        private string phone;
        private string depDesc;

        public EmployeeResDTO() {
        }
        
        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }
        public string DepDesc
        {
            get { return depDesc; }
            set { depDesc = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        
        public string AddressEmployee
        {
            get { return addressEmployee; }
            set { addressEmployee = value; }
        }
    }
}
