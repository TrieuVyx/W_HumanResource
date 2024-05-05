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
    public partial class Update : Form
    {

        private EmployeeController employeeController;
        private EmployeeReqDTO employeeReqDTO;
        public Update()
        {
            InitializeComponent();
            employeeReqDTO = new EmployeeReqDTO();
            employeeController = new EmployeeController();
            txtBirthday.Format = DateTimePickerFormat.Custom;
            txtBirthday.CustomFormat = "dd/MM/yyyy";
            Lock();
        }
        int x = 175;
        int y = 10;
        int height = 470;
        int width = 700;
        internal void ControlAdded(List<EmployeeReqDTO> employeeReqs)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
            foreach (var employeeReq in employeeReqs)
            {
                TxtEmail.Text = employeeReq.Email;
                TxtAddress.Text = employeeReq.AddressEmployee;
                TxtFullName.Text = employeeReq.EmployeeName;
                TxtID.Text = employeeReq.EmployId.ToString();
                TxtPhone.Text = employeeReq.Phone;
                txtBirthday.Value = employeeReq.DateOfBirth;

                if (employeeReq.Gender == "Male")
                {
                    RdMale.Checked = true;
                }
                else
                {
                    RdFemale.Checked = false;
                }

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lock()
        {
            TxtID.ReadOnly = true;
            TxtID.Enabled = false;
        }

        private void btnRefer_Click(object sender, EventArgs e)
        {

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string FullName = TxtFullName.Text;
                string Phone = TxtPhone.Text;
                string Email = TxtEmail.Text;
                string Address = TxtAddress.Text;
                string Id = TxtID.Text;
                string Gender = string.Empty;

                if (RdMale.Checked)
                {
                    Gender = "Male";
                }
                else if (RdFemale.Checked)
                {
                    Gender = "Female";
                }
                DateTime selectedDate = txtBirthday.Value;
                employeeReqDTO = new EmployeeReqDTO();
                if (!string.IsNullOrEmpty(TxtID.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(TxtID.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?!", "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        employeeReqDTO.EmployId = int.Parse(Id);
                        employeeReqDTO.AddressEmployee = Address;
                        employeeReqDTO.Phone = Phone;
                        employeeReqDTO.Email = Email;
                        employeeReqDTO.EmployeeName = FullName;
                        employeeReqDTO.DateOfBirth = selectedDate;
                        employeeReqDTO.Gender = Gender;
                        bool employeeReqs = employeeController.findAndUpdate(employeeReqDTO);
                        if (employeeReqs)
                        {
                            MessageBox.Show("CẬP NHẬT THÀNH CÔNG, VUI LÒNG ẤN RESET ĐỂ CẬP NHẬT LẠI");
                        }
                        else
                        {
                            MessageBox.Show("CẬP NHẬT THẤT BẠI");
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
