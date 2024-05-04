using HumanResource.src.Controller;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
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
    public partial class ListEmployee : Form
    {
        private EmployeeController employeeController;
        private EmployeeResDTO employeeResDTO;
        public ListEmployee()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            employeeResDTO = new EmployeeResDTO();  
            ShowEmployee();
        }
        private void ShowEmployee()
        {
            try
            {
                List<Employees> employeeRes = employeeController.findAllList();
                GridViewEmployee.DataSource = employeeRes;
                txtAmout.Text = employeeRes.Count.ToString();
                txtSearchBox.Clear();
                AutoMode();
                GridViewLock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListEmployee " + ex.Message);
            }
        }

       
        private void AutoMode()
        {
            txtAmout.ReadOnly = true;
            txtAmout.Enabled = false;
        }
        private void GridViewLock()
        {
            GridViewEmployee.ReadOnly = true;
            //GridViewDepartment.Enabled = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        
    }
}
