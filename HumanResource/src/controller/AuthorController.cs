using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Windows.Forms;

namespace HumanResource.src.Controller
{
    internal class AuthorController
    {
        private readonly AuthorService authorService;

        public AuthorController()
        {
            authorService = new AuthorService();
        }
        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        internal bool Authorization(LoginReqDTO loginReqDTO)
        {
            try
            {
                bool author = authorService.Authorization(loginReqDTO);
                if (author)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorController " + ex.Message);
                return false;
            }
        }

        internal bool RegisterAccount(RegisterReqDTO registerReqDTO)
        {
            try
            {

                bool author = authorService.RegisterAccount(registerReqDTO);
                if (author)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorController " + ex.Message);
                return false;
            }
        }
    }
}
