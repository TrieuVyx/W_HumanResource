using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class EducationResDTO
    {
        private int educationId;
        private string educationName;

        public int EducationId
        {
            get { return educationId; }
            set { educationId = value; }
        }

        public string EducationName
        {
            get { return educationName; }
            set { educationName = value; }
        }
    }
}
