using System;

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
        private DateTime? startDate;
        private int salaryAmount;
        private int accountId;
        private int educationId;
        private int degreeId;
        public DateTime? StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

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

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
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
        public int EducationId
        {
            get { return educationId; }
            set { educationId = value; }
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

        public int DepId
        {
            get { return depId; }
            set { depId = value; }
        }

        public int DegreeId
        {
            get { return degreeId; }
            set { degreeId = value; }
        }
        public int SalaryAmount
        {
            get { return salaryAmount; }
            set { salaryAmount = value; }
        }
    }
}
