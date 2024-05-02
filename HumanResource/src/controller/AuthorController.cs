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
        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }
        public void Authorization(String InEmail, String InPass)

        {
            bool author = authorService.Authenticate(InEmail, InPass);

            if(author)
            {
                MessageBox.Show("Login Success");
            }
            else { 
                MessageBox.Show("Login Failure");
            }
        }
    }
}
