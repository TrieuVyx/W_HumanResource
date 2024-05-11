using ReportViewer.EnityForm;
using ReportViewer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewer
{
    public partial class MainReport : Form
    {
        private readonly EmployeeForm employeeForm;
        private readonly EmployeeHistoryForm employeeHistoryForm;
        private readonly SalaryForm salaryForm;
        private readonly AccountForm accountForm;
        private readonly EducationForm educationForm;
        private readonly RelavtiveEmployeeForm relavtiveEmployeeForm;
        private readonly DegreeForm degreeForm;
        private readonly RoleForm roleForm;
        private readonly DepartmentForm departmentForm;
        public MainReport()
        {
            InitializeComponent();
            IsMdiContainer = true;  
            employeeForm = new EmployeeForm();
            employeeHistoryForm = new EmployeeHistoryForm();
            relavtiveEmployeeForm = new RelavtiveEmployeeForm();
            departmentForm = new DepartmentForm();  
            roleForm = new RoleForm();
            degreeForm = new DegreeForm();
            salaryForm = new SalaryForm();
            accountForm = new AccountForm();
            educationForm = new EducationForm();
        }


        private bool BtnEmployeeReport_Clicks = false;
        private bool BtnDepartmentReport_Clicks = false;
        private bool BtnSalaryReport_Clicks = false;
        private bool BtnRolesReport_Clicks = false;
        private bool BtnEducationReport_Clicks = false;
        private bool BtnDegreeReport_Clicks = false;
        private bool BtnEmployeeHistoryReport_Clicks = false;
        private bool BtnRelativeEmployeeReport_Clicks = false;
        private bool BtnAccountReport_Clicks = false;

        private void BtnEmployeeReport_Click(object sender, EventArgs e)
        {
            BtnEmployeeReport_Clicks=true;
            if (BtnEmployeeReport_Clicks)
            {

            }

        }

        private void BtnDepartmentReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalaryReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnRolesReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnEducationReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnDegreeReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmployeeHistoryReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnRelativeEmployeeReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnAccountReport_Click(object sender, EventArgs e)
        {

        }
    }
}
