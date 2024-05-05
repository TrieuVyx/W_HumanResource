using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        private int depId;
        private string roleName;
        private string depDesc;
        private string educationName;
        private string degreeName;
        private string departmentName;
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
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
        public string DepDesc
        {
            get { return depDesc; }
            set { depDesc = value; }
        }
        public string EducationName
        {
            get { return educationName; }
            set { educationName = value; }
        }
        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public int DepId
        {
            get { return depId; }
            set { depId = value; }
        }
    }
}
