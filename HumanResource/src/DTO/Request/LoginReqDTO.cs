using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Request
{
    internal class LoginReqDTO
    {
        private string inEmail;
        private string inPass;

        public LoginReqDTO()
        {
        }

        public LoginReqDTO(string inEmail, string inPass)
        {
            this.inEmail = inEmail;
            this.inPass = inPass;
        }
        public string InEmail
        {
            get { return inEmail; }
            set { inEmail = value; }
        }

        public string InPass
        {
            get { return inPass; }
            set { inPass = value; }
        }
    }
}
