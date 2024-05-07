namespace HumanResource.src.DTO.Request
{
    internal class EmployeeAndDepartmentReqDTO
    {
        private int employId;
        private string email;
        private string employeeName;
        private string addressEmployee;
        private string phone;
        private string gender;
        public EmployeeAndDepartmentReqDTO()
        {

        }


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


    }
}
