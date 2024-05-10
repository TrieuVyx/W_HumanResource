using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Request
{
    internal class EmployeeRotationReqDTO
    {
        private int employId;
        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }
    }
}
