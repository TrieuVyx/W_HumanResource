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
    
        public EmployeeResDTO() { }
        
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
        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}
        //public string Avatar
        //{
        //    get { return avatar; }
        //    set { avatar = value; }
        //}

        public string AddressEmployee
        {
            get { return addressEmployee; }
            set { addressEmployee = value; }
        }

        //public string Phone
        //{
        //    get { return phone; }
        //    set { phone = value; }
        //}

    }
}
