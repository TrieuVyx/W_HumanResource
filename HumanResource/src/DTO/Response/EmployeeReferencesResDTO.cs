using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Response
{
    internal class EmployeeReferencesResDTO
    {
        private int relativeId;
        private int employId;
        private string fullName;
        private string relationship;
        private string phoneNumber;
        private string addressRelative;
        public EmployeeReferencesResDTO() { }
        public int RelativeId
        {
            get { return relativeId; }
            set { relativeId = value; }
        }

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Relationship
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
