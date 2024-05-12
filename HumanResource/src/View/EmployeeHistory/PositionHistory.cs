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

namespace HumanResource.src.View.EmployeeHistory
{
    public partial class PositionHistory : Form
    {
        public PositionHistory()
        {
            InitializeComponent();
            Lock();
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;
        internal new void ControlAdded(List<EmployeeResProfileDTO> employeeReqs)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
            foreach (var employeeReq in employeeReqs)
            {
                txtEmployeeName.Text = employeeReq.EmployeeName;
                txtEmployeeId.Text = employeeReq.EmployId.ToString();
                txtEmail.Text = employeeReq.Email;
                txtEduName.Text = employeeReq.EducationName;

                txtFullName.Text = employeeReq.FullName;    
                txtGender.Text = employeeReq.Gender;    
                txtRelationShip.Text = employeeReq.RelationShip;
                txtSalaryAmout.Text = employeeReq.SalaryAmount.ToString();

                txtDepDes.Text = employeeReq.DepDesc;
                txtDegreeName.Text = employeeReq.DegreeName;
                txtAddressEmployee.Text = employeeReq.AddressEmployee;
                txtAddressRelative.Text = employeeReq.AddressRelative;

                txtDateOfBirth.Text = employeeReq.DateOfBirth.ToString();
                txtRoleName.Text = employeeReq.RoleName;
                txtPhone.Text = employeeReq.Phone;
                txtPhoneNumber.Text = employeeReq.PhoneNumber;


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void Lock()
        {
            txtAddressEmployee.Enabled = false;
            txtAddressEmployee.ReadOnly = true;

            txtAddressRelative.Enabled = false; 
            txtAddressRelative.ReadOnly = true;

            txtDateOfBirth.Enabled = false;
            txtDateOfBirth.ReadOnly = true;

            txtDegreeName.Enabled = false;  
            txtDegreeName.ReadOnly = true;

            txtDepDes.Enabled = false;
            txtDepDes.ReadOnly = true;  

            txtEduName.Enabled = false;
            txtEduName.ReadOnly = true;

            txtEmail.Enabled = false;
            txtEmail.ReadOnly = true;


            txtPhone.Enabled = false;
            txtPhone.ReadOnly = true;   

            txtEmployeeId.Enabled = false;
            txtEmployeeId.ReadOnly = true;

            txtGender.Enabled = false;
            txtGender.ReadOnly = true;

            txtSalaryAmout.Enabled = false;
            txtSalaryAmout.ReadOnly = true;

            txtFullName.Enabled = false;
            txtFullName.ReadOnly = true;

            txtRelationShip.Enabled = false;    
            txtRelationShip.ReadOnly = true;    


            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.ReadOnly = true;

            txtRoleName.Enabled = false;
            txtRoleName.ReadOnly = true;

            txtEmployeeName.Enabled = false;
            txtEmployeeName.ReadOnly = true;

        }        
    }
}
