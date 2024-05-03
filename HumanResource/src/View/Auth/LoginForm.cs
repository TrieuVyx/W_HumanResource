using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
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
    internal partial class LoginForm : Form
    {
        private LoginReqDTO loginReqDTO;
        private AuthorController authorController;
        public LoginForm()
        {
            InitializeComponent();
            authorController = new AuthorController();
        }
        public LoginForm(AuthorController authorController, LoginReqDTO loginReqDTO)
        {
            this.authorController = authorController;
            this.loginReqDTO = loginReqDTO;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string InEmail = txtEmail.Text;
                string InPass = txtPassWord.Text;
                loginReqDTO = new LoginReqDTO();

                if (InEmail == null ||
                   InPass == null ||
                   InEmail == "" ||
                    InPass == "")
                {
                    MessageBox.Show("Vui lòng nhập email và mật khẩu!");
                }
                else
                {
                    loginReqDTO.InEmail = InEmail;
                    loginReqDTO.InPass = InPass;
                    bool isAuthenticated = authorController.Authorization(loginReqDTO);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ LoginForm " + ex.Message);
            }
        }

       
    }
}
