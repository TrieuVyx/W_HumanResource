using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.View.Employee;
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
    public partial class ListRole : Form
    {
        private readonly RoleController roleController = new RoleController();
        private  RoleReqDTO roleReqDTO;
        private RoleResDTO roleResDTO;
        public ListRole()
        {
            InitializeComponent();
            roleResDTO = new RoleResDTO(); 
            roleReqDTO = new RoleReqDTO();
            txtIdAmount.Enabled = false;
            txtIdRole.Enabled = false;
            txtIdAmount.ReadOnly = true;
            txtIdRole.ReadOnly = true;
            txtIdEmployee.ReadOnly = true;
            txtIdEmployee.Enabled = false;
            ShowRole();
        }
        private void ShowRole()
        {
            try
            {
                List<RoleReqDTO> role = roleController.FindAllRole();
                ViewRoleData.DataSource = role;
                txtIdAmount.Text = role.Count.ToString();
                ViewRoleData.CellContentClick += AddId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        private void AddId(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = ViewRoleData.Rows[indexOfContent];
            txtIdRole.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtIdEmployee.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                Create create = new Create();
                create.ControlAdded();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdEmployee.Text))
                {
                    roleResDTO.EmployId = int.Parse(txtIdEmployee.Text);
                    List<RoleResDTO> employeeRes = roleController.FindAndWatch(roleResDTO);
                    if (employeeRes.Count > 0)
                    {
                        ViewDataEmployee.DataSource = employeeRes;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
                else
                {
                    MessageBox.Show("ID không được để trống: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ShowRole();
            txtIdAmount.Clear();
            txtIdRole.Clear();
            txtIdEmployee.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdRole.Text))
                {
                    roleReqDTO.RoleId = int.Parse(txtIdRole.Text);
                    List<RoleReqDTO> roleReqDTOs = roleController.FindAndDetail(roleReqDTO);
                    if (roleReqDTOs.Count > 0)
                    {
                        Update update = new Update();
                        update.ControlAdded(roleReqDTOs);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
                else
                {
                    MessageBox.Show("ID không được để trống: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdRole.Text))
                {
                    roleReqDTO.RoleId = int.Parse(txtIdRole.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool role = roleController.FindAndDelete(roleReqDTO);
                        if (role)
                        {
                            MessageBox.Show("Xoá thành công, vui lòng reset để kiểm tra ^");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Bạn đã huỷ lựa chọn");

                    }

                }
                else
                {
                    MessageBox.Show("ID không được để trống: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
