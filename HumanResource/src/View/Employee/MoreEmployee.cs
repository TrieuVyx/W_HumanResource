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

namespace HumanResource.src.View.Employee
{
    public partial class MoreEmployee : Form
    {
        private EmployeeController employeeController;
        private EmployeeReqDTO employeeReqDTO;
        private RoleReqDTO roleReqDTO;
        private RoleController roleController;
        public MoreEmployee()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            employeeReqDTO = new EmployeeReqDTO();
            roleReqDTO = new RoleReqDTO();
            roleController = new RoleController();
            DataLimit();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string FullName = TXTHOTEN.Text;
            string Phone = txtsodienthoai.Text;
            string Email = TXTemail.Text;
            string Address = txtAddress.Text;
            string Id = txtid.Text;



            employeeReqDTO = new EmployeeReqDTO();
            try
            {
                //if (string.IsNullOrEmpty(txtSearchValue))
                //{
                //    MessageBox.Show("Vui lòng nhập PHÒNG BAN bạn muốn tìm.");
                //}
                //else
                //{
                //    departmentReqDTO.DepDesc = txtSearchValue;
                //    List<EmployeeResDTO> employees = departmentController.FindNameDepart(departmentReqDTO);
                //    if (employees.Count > 0)
                //    {
                //        GridViewDepartment.DataSource = employees;
                //        txtAmout.Text = employees.Count.ToString();

                //        AutoMode();

                //        GridViewDepartment.CellContentClick += GridViewDepartment_CellContentClick;
                //    }
                //    else
                //    {
                //        GridViewDepartment.DataSource = null;
                //        MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ MoreEmployee " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void DataLimit()
        {
            cboGioiTinh.SelectedIndex = 0;
            try
            {
                List<RoleReqDTO> roles = roleController.findAllRole();
                if(roles.Count > 0 )
                {
                    txtCboRole.DataSource = roles;
                }
                else
                {
                    txtCboRole.DataSource = null;
                    MessageBox.Show("Lỗi không tồn tại danh sách Roles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ MoreEmployee " + ex.Message);

            }
        }
    }
}
