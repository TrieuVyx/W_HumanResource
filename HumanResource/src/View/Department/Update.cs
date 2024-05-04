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

namespace HumanResource.src.View.Department
{
    public partial class Update : Form
    {
        private List<DepartmentResDTO> departmentRes;

        public Update()
        {
            InitializeComponent();
            departmentRes = new List<DepartmentResDTO>();
           
        }
        int x = 175; 
        int y = 10;
        int height = 470;
        int width = 700;
        internal void ControlAdded(List<DepartmentResDTO> departmentRes)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent; 
            this.Show();
            foreach (var department in departmentRes)
            {
                txtIDDepartment.Text = department.DepId.ToString();
                txtIDDepartment.ReadOnly = true;
                txtIDDepartment.Enabled = false;
                txtDesc.Text = department.DepDesc;
                txtDepPlace.Text = department.DepPlace;  
                txtDepType.Text = department.DepType;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
