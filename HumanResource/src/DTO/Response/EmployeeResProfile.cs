using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class EmployeeResProfile
    {
        private int employId;
        private string employeeName;
        private string email;
        private string addressEmployee;
        private DateTime dateOfBirth;
        private string phone;
        private string gender;
        private string roleName;
        //private string fullName;
        private string depDesc;
        private string educationName;
        private string degreeName;
        private int salaryAmount;
        private string relationship;
        private string phoneNumber;
        private string addressRelative;

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
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

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
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


        //public string FullName
        //{
        //    get { return fullName; }
        //    set { fullName = value; }
        //}

        public int SalaryAmount
        {
            get { return salaryAmount; }
            set { salaryAmount = value; }
        }
        public string RelationShip
        {
            get { return relationship; }
            set { relationship = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string AddressRelative
        {
            get { return addressRelative; }
            set { addressRelative = value; }
        }
    }
}

//E.EmployeeName, E.Email,  E.AddressEmployee, E.DateOfBirth, E.Phone, 
//       E.Gender, R.RoleName, D.DepDesc, S.SalaryAmount, Edu.EducationName, Deg.DegreeName, 
//       RE.FullName as RelativeName, RE.Relationship, RE.PhoneNumber, RE.AddressRelative