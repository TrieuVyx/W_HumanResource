namespace HumanResource.src.DTO.Response
{
    internal class EmployeeResDTO
    {
        private int employId;
        private string employeeName;
        private string addressEmployee;
        private string depDesc;


        public EmployeeResDTO()
        {
        }

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }
        public string DepDesc
        {
            get { return depDesc; }
            set { depDesc = value; }
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
    }
}
