using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.View.Role
{
    public partial class Update : Form
    {
        private readonly RoleController roleController;
        private  RoleReqDTO roleReqDTO = new RoleReqDTO();
        public Update()
        {
            InitializeComponent();
            roleController = new RoleController();
            txtRoleId.Enabled = false;
            txtRoleId.ReadOnly = true;
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;
        internal new void ControlAdded(List<RoleReqDTO> roleReqDTOs)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();

            foreach (var roleReqDTO in roleReqDTOs)
            {
                txtRoleId.Text = roleReqDTO.RoleId.ToString();
                txtRoleName.Text = roleReqDTO.RoleName;
                txtRoleDesc.Text = roleReqDTO.RoleDesc;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string RoleId = txtRoleId.Text;
                string RoleName = txtRoleName.Text;
                string RoleDesc = txtRoleDesc.Text;
                roleReqDTO = new RoleReqDTO();
                try
                {

                    if (
                        string.IsNullOrEmpty(RoleName) &&
                        string.IsNullOrEmpty(RoleDesc) &&
                        string.IsNullOrEmpty(RoleId)
                        )
                    {
                        MessageBox.Show("Vui lòng nhập các trường và không được để trông");
                    }
                    else
                    {
                        roleReqDTO.RoleId = int.Parse(RoleId);
                        roleReqDTO.RoleName = RoleName;
                        roleReqDTO.RoleDesc = RoleDesc;

                        bool role = roleController.UpdateUser(roleReqDTO);
                        if (role)
                        {
                            MessageBox.Show("Update Thành Công, vui lòng reset lại kiểm tra");
                        }
                        else
                        {
                            MessageBox.Show("Không thể tạo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Phát Sinh Từ Update role " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
