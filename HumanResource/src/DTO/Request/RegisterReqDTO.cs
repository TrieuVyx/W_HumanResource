using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HumanResource.src.DTO.Request
{
    internal class RegisterReqDTO
    {
        private string fullName;
        private string passWords;
        private string email;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public RegisterReqDTO() { }
        public string PassWords
        {
            get { return passWords; }
            set { passWords = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
