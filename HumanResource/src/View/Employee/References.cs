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

namespace HumanResource.src.View.Employee
{
    public partial class References : Form
    {
        public References()
        {
            InitializeComponent();
            txtID.Enabled = false;
            txtID.ReadOnly = true;
            txtIDRelative.Enabled = false; 
            txtIDRelative.ReadOnly = true; 
            txtPhone.Enabled = false;
            txtPhone.ReadOnly = true;
            txtAddress.Enabled = false;
            txtAddress.ReadOnly = true;
            txtFullName.Enabled = false;
            txtFullName.ReadOnly = true;
            txtRelationShip.Enabled = false;
            txtRelationShip.ReadOnly = true;
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;
        internal new void ControlAdded(List<EmployeeReferencesResDTO> employeeReqs)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
            foreach (var employeeReq in employeeReqs)
            {
                txtID.Text = employeeReq.EmployId.ToString();
                txtIDRelative.Text = employeeReq.RelativeId.ToString();
                txtRelationShip.Text = employeeReq.Relationship;
                txtFullName.Text = employeeReq.FullName;
                txtAddress.Text = employeeReq.AddressRelative;
                txtPhone.Text = employeeReq.PhoneNumber;
            }
        }

        

        private void TxtClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
