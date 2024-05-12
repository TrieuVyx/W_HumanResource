using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Windows.Forms;

namespace HumanResource.src.View.Auth
{
    internal partial class LoginForm : Form
    {
        private LoginReqDTO loginReqDTO;
        private readonly AuthorController authorController;
        private readonly MainApplication mainApplication;
        private readonly SignUpForm signUpForm;

        public LoginForm()
        {
            InitializeComponent();
            authorController = new AuthorController();
            mainApplication = new MainApplication();
            signUpForm = new SignUpForm();

        }


        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
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
                    if (isAuthenticated == true)
                    {
                        //MessageBox.Show(isAuthenticated.ToString());
                        mainApplication.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("thông tin đăng nhập không chính xác ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ LoginForm " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            signUpForm.Show();  
            this.Hide();
        }
    }
}
