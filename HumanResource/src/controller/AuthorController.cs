using HumanResource.src.DbContext;
using HumanResource.src.DTO.Request;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.Controller
{
    internal class AuthorController
    {
        private AuthorService authorService;

        public AuthorController()
        {
            authorService = new AuthorService();
        }
        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        internal bool Authorization(LoginReqDTO loginReq)
        {
            try
            {
                authorService.Authenticate(loginReq);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorController " + ex.Message);
                return false;
            }
        }
    }
}
