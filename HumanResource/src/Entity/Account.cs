namespace HumanResource.src.Entity
{
    internal class Account
    {
        private int accountId;
        private string fullName;
        private string passWords;
        private string email;
        private int roleId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

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

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
    }
}
