using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class EmployeeRotationResDTO
    {
        private DateTime? startDate;
        private DateTime? endDate;
        private string staging;
        private string employeeName;


 
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public DateTime? StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Staging
        {
            get { return staging; }
            set { staging = value; }
        }
    }
}
