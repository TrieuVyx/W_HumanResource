using HumanResource.src.DTO.Request;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        internal void Authenticate(LoginReqDTO loginReq)
        {
            try
            {
                authorRepository.CheckLogin(loginReq);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ AuthorService " + ex.Message);

            }
        }
    }
}
