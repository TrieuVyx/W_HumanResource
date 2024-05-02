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
        public AuthorService(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        internal bool Authenticate(string inEmail, string inPass)
        {
            try {
                authorRepository.CheckLogin(inEmail, inPass);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
