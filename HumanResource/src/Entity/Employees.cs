using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Entity
{

    internal class Employees
    {
        private int employId;
        private string email;
        private string employeeName;
        private string avatar;
        private string addressEmployee;
        private string phone;
        private int roleId;
        private int accountId;
        private int depId;
        private int salaryId;
        private int educationId;
        private int degreeId;
        private int relativeId;
        public Employees() { }
        public Role Role { get; set; }
        public Account Account { get; set; }
        public Department Department { get; set; }
        public Salary Salary { get; set; }
        public Education Education { get; set; }
        public Degree Degree { get; set; }
        public RelativeEmployee Relative { get; set; }
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

        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string AddressEmployee
        {
            get { return addressEmployee; }
            set { addressEmployee = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public int DepId
        {
            get { return depId; }
            set { depId = value; }
        }

        public int SalaryId
        {
            get { return salaryId; }
            set { salaryId = value; }
        }

        public int EducationId
        {
            get { return educationId; }
            set { educationId = value; }
        }

        public int DegreeId
        {
            get { return degreeId; }
            set { degreeId = value; }
        }

        public int RelativeId
        {
            get { return relativeId; }
            set { relativeId = value; }
        }
    }
}
