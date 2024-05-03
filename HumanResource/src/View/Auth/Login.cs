using HumanResource.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.View.Auth
{
    public partial class Login : Form
    {
        private AuthorController authorController;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String InEmail = txtEmail.Text;
            String InPass = txtPassWord.Text;
            MessageBox.Show(InEmail.ToString());
            MessageBox.Show(InPass.ToString());

        }
    }
}
