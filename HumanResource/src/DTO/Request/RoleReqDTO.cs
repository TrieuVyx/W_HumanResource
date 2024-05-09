namespace HumanResource.src.DTO.Request
{
    internal class RoleReqDTO
    {
        private int roleId;
        private string roleDesc;
        private string roleName;
        private int employId;
        public RoleReqDTO() { }
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }

        public string RoleDesc
        {
            get { return roleDesc; }
            set { roleDesc = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
    }
}
