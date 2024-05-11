using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResource.src.View.Employee
{
    public partial class MoreEmployee : Form
    {
        private readonly EmployeeController employeeController;
        private EmployeeReqDTO employeeReqDTO;
        private readonly RoleController roleController;
        public MoreEmployee()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            employeeReqDTO = new EmployeeReqDTO();
            roleController = new RoleController();
            DataLimit();
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            string FullName = TXTHOTEN.Text;
            string Phone = txtsodienthoai.Text;
            string Email = TXTemail.Text;
            string Address = txtAddress.Text;
            string valueCboGender = cboGioiTinh.SelectedItem.ToString();
            DateTime selectedDate = txtBirthDay.Value;
            employeeReqDTO = new EmployeeReqDTO();
            try
            {
                if (int.TryParse(txtCboRole.SelectedValue.ToString(), out int roleId))
                {
                    employeeReqDTO.RoleId = roleId;
                }
                if (
                    string.IsNullOrEmpty(Phone) &&
                    string.IsNullOrEmpty(Email) &&
                    string.IsNullOrEmpty(Address) &&
                    string.IsNullOrEmpty(FullName) 
                    )
                {
                    MessageBox.Show("Vui lòng nhập các trường và không được để trông");
                }
                else
                {
                    employeeReqDTO.AddressEmployee = Address;
                    employeeReqDTO.Phone = Phone;
                    employeeReqDTO.Email = Email;
                    employeeReqDTO.EmployeeName = FullName;
                    employeeReqDTO.Gender = valueCboGender;
                    employeeReqDTO.DateOfBirth = selectedDate;
                    employeeReqDTO.RoleId = roleId;
                    bool employees = employeeController.CreateUser(employeeReqDTO);
                    if (employees)
                    {
                        MessageBox.Show("Tạo Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ MoreEmployee " + ex.Message);
            }
        }
        private void Btnxoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void DataLimit()
        {
            cboGioiTinh.SelectedIndex = 0;

            try
            {
                List<RoleReqDTO> roleReqDTO = roleController.FindAllRole();

                if (roleReqDTO.Count > 0)
                {
                    txtCboRole.DataSource = roleReqDTO;
                    txtCboRole.DisplayMember = "RoleName";
                    txtCboRole.ValueMember = "RoleId";
                    txtCboRole.SelectedIndex = 1;
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
