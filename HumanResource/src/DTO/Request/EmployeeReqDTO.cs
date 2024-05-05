using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Request
{
    internal class EmployeeReqDTO
    {
        private int employId;
        private string email;
        private string employeeName;
        private string addressEmployee;
        private DateTime dateOfBirth;
        private string phone;
        private string gender;
        private int roleId;

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
    }
}
