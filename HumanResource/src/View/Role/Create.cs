using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HumanResource.src.View.Role
{
    public partial class Create : Form
    {
        private readonly RoleController roleController = new RoleController();
        private  RoleReqDTO roleReqDTO = new RoleReqDTO();
        public Create()
        {
            InitializeComponent();
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;
        internal new void ControlAdded()
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string RoleName = txtRoleName.Text;
            string RoleDesc = txtRoleDesc.Text;
            roleReqDTO = new RoleReqDTO();
            try
            {
            
                if (
                    string.IsNullOrEmpty(RoleName) &&
                    string.IsNullOrEmpty(RoleDesc)
                    )
                {
                    MessageBox.Show("Vui lòng nhập các trường và không được để trông");
                }
                else
                {
                    roleReqDTO.RoleName = RoleName;
                    roleReqDTO.RoleDesc = RoleDesc;
                    bool role = roleController.CreateUser(roleReqDTO);
                    if (role)
                    {
                        MessageBox.Show("Tạo Thành Công, vui lòng reset lại kiểm tra");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ Create role " + ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRoleDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRoleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
