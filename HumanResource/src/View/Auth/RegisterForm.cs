//using HumanResource.src.DbContext;
//using System;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;

//namespace HumanResource.src.View.Auth
//{
//    public partial class RegisterForm : Form
//    {
//        private readonly LoginForm loginForm;
//        public RegisterForm()
//        {
//            InitializeComponent();
//            loginForm = new LoginForm();

//        }

//        private void BtnClose_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//        }

//        public bool ChecKAccount(string ac)
//        {
//            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
//        }
//        public bool CheckEmail(string email)
//        {
//            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
//        }

//        readonly Modify modify = new Modify();

//        private void Button2_Click(object sender, EventArgs e)
//        {
//            string tentk = txttentk.Text;
//            string matkhau = txtMk.Text;
//            string xacnhamatkau = txtxacnhanMK.Text;
//            string email = txtEmail.Text;

//            if (!ChecKAccount(tentk)) { MessageBox.Show("vui long nhap ten tk tu 6-24 ky tu"); return; }
//            if (!ChecKAccount(matkhau)) { MessageBox.Show("vui long nhap mat khau tu 6-24 kuy tu"); return; }
//            if (xacnhamatkau != matkhau) { MessageBox.Show("vui long nhap dung mat khau"); return; }
//            if (!CheckEmail(email)) { MessageBox.Show("vui long nhap dung dinh dang email"); return; }
//            if (modify.Taikhoans("select* from Account where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email da ton tai"); return; }
//            try
//            {
//                string query = "Insert into Account values('" + tentk + "','" + matkhau + "','" + email + "')";
//                modify.Command(query);
//            }
//            catch
//            {
//                MessageBox.Show("Ten tk da duong dang ky");
//            }
//        }

//        private void Label2_Click(object sender, EventArgs e)
//        {
//            loginForm.Show();
//            this.Close();
//        }
//    }
//}
