using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Windows.Forms;

namespace HumanResource.src.Service
{
    internal class AuthorService
    {
        private readonly AuthorRepository authorRepository;

        public AuthorService()
        {
            authorRepository = new AuthorRepository();
        }

        internal bool Authorization(LoginReqDTO loginReqDTO)
        {
            try
            {
                bool check = authorRepository.Authorization(loginReqDTO);
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

        internal bool RegisterAccount(RegisterReqDTO registerReqDTO)
        {
            try
            {
                bool check = authorRepository.RegisterAccount(registerReqDTO);
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
