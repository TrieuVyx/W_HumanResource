namespace HumanResource.src.Entity
{

    internal class RelativeEmployee
    {
        private int relativeId;
        private int employeeId;
        private string fullName;
        private string relationship;
        private string phoneNumber;
        private string addressRelative;

        public int RelativeId
        {
            get { return relativeId; }
            set { relativeId = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
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
