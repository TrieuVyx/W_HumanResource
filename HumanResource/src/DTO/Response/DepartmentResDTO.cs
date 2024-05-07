namespace HumanResource.src.DTO.Response
{
    internal class DepartmentResDTO

    {
        private int depId;
        private string depDesc;
        private string depType;
        private string depPlace;
        public DepartmentResDTO() { }

        public int DepId
        {
            get { return depId; }
            set { depId = value; }
        }

        public string DepDesc
        {
            get { return depDesc; }
            set { depDesc = value; }
        }

        public string DepType
        {
            get { return depType; }
            set { depType = value; }
        }
        public string DepPlace
        {
            get { return depPlace; }
            set { depPlace = value; }
        }
    }
}
