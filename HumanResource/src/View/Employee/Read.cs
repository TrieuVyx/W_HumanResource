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

    public partial class Read : Form
    {
        private EmployeeReqDTO employeeReqDTO;

        public Read()
        {
            InitializeComponent();
            employeeReqDTO = new EmployeeReqDTO();
            Lock();
        }
        int x = 175;
        int y = 10;
        int height = 470;
        int width = 700;
        internal void ControlAdded(List<EmployeeReqDTO> employeeReqDTO)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
            foreach (var employeeReq in employeeReqDTO)
            {
                txtID.Text = employeeReq.EmployId.ToString();
                txtEmail.Text = employeeReq.Email;
                txtGender.Text = employeeReq.Gender;
                txtPhone.Text = employeeReq.Phone;  
                txtEmployeeeName.Text = employeeReq.EmployeeName;
                txtAddress.Text = employeeReq.AddressEmployee;
                txtBirthday.Text = employeeReq.DateOfBirth.ToString();
                txtDegreee.Text = employeeReq.DegreeName;
                txtDepartment.Text = employeeReq.DepDesc;
                txtEducation.Text = employeeReq.EducationName;
                txtRole.Text = employeeReq.RoleName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


        }

        private void Lock() {
            txtAddress.ReadOnly = true;
            txtAddress.Enabled = false;
            txtBirthday.ReadOnly = true;
            txtBirthday.Enabled = false;
            txtDepartment.ReadOnly = true;
            txtDepartment.Enabled = false;
            txtEmail.ReadOnly = true;
            txtEmail.Enabled = false;
            txtEmployeeeName.ReadOnly = true;
            txtEmployeeeName.Enabled = false;
            txtGender.ReadOnly = true;
            txtGender.Enabled = false;
            txtID.ReadOnly = true;
            txtID.Enabled = false;
            txtRole.ReadOnly = true;
            txtRole.Enabled = false;
            txtEducation.ReadOnly = true;
            txtEducation.Enabled = false;
            txtDegreee.ReadOnly = true;
            txtDegreee.Enabled = false;
            txtPhone.ReadOnly = true;
            txtPhone.Enabled = false;
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
