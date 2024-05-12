using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HumanResource.src.View.Auth
{
    public partial class SignUpForm : Form
    {
        private  RegisterReqDTO _registerReqDTO;
        private readonly AuthorController _authorController;
        private readonly LoginForm _loginForm;
        public SignUpForm()
        {
            InitializeComponent(); ;
            _registerReqDTO = new RegisterReqDTO();
            _authorController = new AuthorController();
            _loginForm = new LoginForm();
        }
        public bool ChecKAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            _registerReqDTO = new RegisterReqDTO();
            try {
                string tentk = txttentk.Text;
                string matkhau = txtMk.Text;
                string xacnhamatkau = txtxacnhanMK.Text;
                string email = txtEmail.Text;
                if (!ChecKAccount(tentk)) { MessageBox.Show("vui long nhap ten tk tu 6-24 ky tu"); return; }
                if (!ChecKAccount(matkhau)) { MessageBox.Show("vui long nhap mat khau tu 6-24 kuy tu"); return; }
                if (xacnhamatkau != matkhau) { MessageBox.Show("vui long nhap dung mat khau"); return; }
                if (!CheckEmail(email)) { MessageBox.Show("vui long nhap dung dinh dang email"); return; }
                _registerReqDTO.Email = email;
                _registerReqDTO.FullName = tentk;
                _registerReqDTO.PassWords = matkhau;
                bool registerAccount = _authorController.RegisterAccount(_registerReqDTO);
                if (registerAccount)
                {
                    MessageBox.Show("Bạn đã đăng ký tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi này từ SignUpForm " + ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }
    }
}
