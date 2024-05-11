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


        private bool BtnEmployeeReport_Clicks= false;
        private bool BtnDepartmentReport_Clicks = false;
        private bool BtnSalaryReport_Clicks = false;
        private bool BtnRolesReport_Clicks = false;
        private bool BtnEducationReport_Clicks = false;
        private bool BtnDegreeReport_Clicks = false;
        private bool BtnEmployeeHistoryReport_Clicks = false;
        private bool BtnRelativeEmployeeReport_Clicks = false;
        private bool BtnAccountReport_Clicks = false;

        int width = 800;
        int height = 450;
        int x = 180;
        int y = 10;
        private void BtnEmployeeReport_Click(object sender, EventArgs e)
        {
            BtnEmployeeReport_Clicks=true;
            if (BtnEmployeeReport_Clicks)
            {
                employeeForm.MdiParent = this;
                employeeForm.StartPosition = FormStartPosition.Manual;
                employeeForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Show();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide(); 
                salaryForm.Hide();   
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }

        }

        private void BtnDepartmentReport_Click(object sender, EventArgs e)
        {
            BtnDepartmentReport_Clicks = true;
            if (BtnDepartmentReport_Clicks)
            {
                departmentForm.MdiParent = this;
                departmentForm.StartPosition = FormStartPosition.Manual;
                departmentForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Show();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnSalaryReport_Click(object sender, EventArgs e)
        {
            BtnSalaryReport_Clicks = true;
            if (BtnSalaryReport_Clicks)
            {
                salaryForm.MdiParent = this;
                salaryForm.StartPosition = FormStartPosition.Manual;
                salaryForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Show();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnRolesReport_Click(object sender, EventArgs e)
        {
            BtnRolesReport_Clicks = true;
            if (BtnRolesReport_Clicks)
            {
                roleForm.MdiParent = this;
                roleForm.StartPosition = FormStartPosition.Manual;
                roleForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Show();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnEducationReport_Click(object sender, EventArgs e)
        {
            BtnEducationReport_Clicks = true;
            if (BtnEducationReport_Clicks)
            {
                educationForm.MdiParent = this;
                educationForm.StartPosition = FormStartPosition.Manual;
                educationForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Show();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnDegreeReport_Click(object sender, EventArgs e)
        {
            BtnDegreeReport_Clicks = true;
            if (BtnDegreeReport_Clicks)
            {
                degreeForm.MdiParent = this;
                degreeForm.StartPosition = FormStartPosition.Manual;
                degreeForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Show();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnEmployeeHistoryReport_Click(object sender, EventArgs e)
        {
            BtnEmployeeHistoryReport_Clicks = true;
            if (BtnEmployeeHistoryReport_Clicks)
            {
                employeeHistoryForm.MdiParent = this;
                employeeHistoryForm.StartPosition = FormStartPosition.Manual;
                employeeHistoryForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Show();
                accountForm.Hide();
            }
        }

        private void BtnRelativeEmployeeReport_Click(object sender, EventArgs e)
        {
            BtnRelativeEmployeeReport_Clicks = true;
            if (BtnRelativeEmployeeReport_Clicks)
            {
                relavtiveEmployeeForm.MdiParent = this;
                relavtiveEmployeeForm.StartPosition = FormStartPosition.Manual;
                relavtiveEmployeeForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Show();
                employeeHistoryForm.Hide();
                accountForm.Hide();
            }
        }

        private void BtnAccountReport_Click(object sender, EventArgs e)
        {
            BtnAccountReport_Clicks = true;
            if (BtnAccountReport_Clicks)
            {
                accountForm.MdiParent = this;
                accountForm.StartPosition = FormStartPosition.Manual;
                accountForm.Bounds = new Rectangle(x, y, width, height);
                employeeForm.Hide();
                roleForm.Hide();
                educationForm.Hide();
                degreeForm.Hide();
                salaryForm.Hide();
                departmentForm.Hide();
                relavtiveEmployeeForm.Hide();
                employeeHistoryForm.Hide();
                accountForm.Show();
            }
        }
    }
}
