using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class SalaryEmployeeResDTO
    {
        private string employeeName;
        private string gender;
        private int salaryAmount;
        private string salaryDesc;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int SalaryAmount
        {
            get { return salaryAmount; }
            set { salaryAmount = value; }
        }

        public string SalaryDesc
        {
            get { return salaryDesc; }
            set { salaryDesc = value; }
        }

    }
}
