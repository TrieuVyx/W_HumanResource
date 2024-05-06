using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace HumanResource.src.View.Auth
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }
        public bool checKAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
        }

        Modify modify = new Modify();

        private void txtMk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tentk = txttentk.Text;
            string matkhau = txtMk.Text;
            string xacnhamatkau = txtxacnhanMK.Text;
            string email = txtEmail.Text;

            if (!checKAccount(tentk)) { MessageBox.Show("vui long nhap ten tk tu 6-24 ky tu"); return; }
            if (!checKAccount(matkhau)) { MessageBox.Show("vui long nhap mat khau tu 6-24 kuy tu"); return; }
            if (xacnhamatkau != matkhau) { MessageBox.Show("vui long nhap dung mat khau"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("vui long nhap dung dinh dang email"); return; }
            if (modify.taikhoans("select* from Account where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email da ton tai"); return; }
            try
            {
                string query = "Insert into Account values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
            }
            catch
            {
                MessageBox.Show("Ten tk da duoc dang ky");
            }
        }
    }
}
