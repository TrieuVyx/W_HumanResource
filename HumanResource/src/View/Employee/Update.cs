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
        private EmployeeReqDTO employeeReqDTO;
        public Update()
        {
            InitializeComponent();
            employeeReqDTO = new EmployeeReqDTO();
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
                //txtID.Text = employeeReq.EmployId.ToString();
                //txtEmail.Text = employeeReq.Email;
                //txtGender.Text = employeeReq.Gender;
                //txtPhone.Text = employeeReq.Phone;
                //txtDepartment.Text = employeeReq.
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
