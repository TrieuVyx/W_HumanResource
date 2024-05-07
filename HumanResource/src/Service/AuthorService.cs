using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Windows.Forms;

namespace HumanResource.src.Service
{
    internal class AuthorService
    {
        private AuthorRepository authorRepository;

        public AuthorService()
        {
            authorRepository = new AuthorRepository();
        }
        public AuthorService(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        internal bool Authenticate(LoginReqDTO loginReq)
        {
            try
            {
                bool check = authorRepository.CheckLogin(loginReq);
                if (check)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorService " + ex.Message);
                return false;

            }
        }
    }
}
