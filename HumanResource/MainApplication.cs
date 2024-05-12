using HumanResource.src.View;
using HumanResource.src.View.Auth;
using HumanResource.src.View.Department;
using HumanResource.src.View.Employee;
using HumanResource.src.View.Role;
using HumanResource.src.View.Salary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class MainApplication : Form
    {


        readonly ListEmployee employee = new ListEmployee();
        readonly ListDep department = new ListDep();
        readonly Dashboard _dashboard = new Dashboard();
        readonly ListSalary listSalary = new ListSalary();
        readonly AddEmployeeCome employeeCome = new AddEmployeeCome();
        readonly ListRole role = new ListRole();
        //readonly RegisterForm registerForm;
        readonly int height = 470;
        readonly int width = 700;
        private bool buttonFormSalary = false;
        private bool buttonFormDepartment = false;
        private bool buttonFormEmployee = false;
        private bool buttonFormDashboard = true;
        private bool buttonFormRole = false;
        private bool buttonEmployDepartment = false;

        public MainApplication()
        {

            InitializeComponent();
            this.IsMdiContainer = true;
            if (buttonFormDashboard)
            {
                _dashboard.MdiParent = this;
                _dashboard.StartPosition = FormStartPosition.Manual;
                _dashboard.Bounds = new Rectangle(175, 10, width, height);
                _dashboard.Show();
                employee.Hide();
                department.Hide();
                listSalary.Hide();
                employeeCome.Hide();
                role.Hide();
            }

        }


        private void ButtonSalary(object sender, EventArgs e)
        {
            buttonFormSalary = true;
            if (buttonFormSalary)
            {
                listSalary.MdiParent = this;
                listSalary.StartPosition = FormStartPosition.Manual;
                listSalary.Bounds = new Rectangle(175, 10, width, height);
                employee.Hide();
                department.Hide();
                _dashboard.Hide();
                listSalary.Show();
                employeeCome.Hide();
                role.Hide();
                buttonFormDepartment = false;
                buttonFormDashboard = false;
            }
        }
        private void ButtonEmployeeDepartment(object sender, EventArgs e)
        {
            buttonEmployDepartment = true;

            if (buttonEmployDepartment)
            {
                employeeCome.MdiParent = this;
                employeeCome.StartPosition = FormStartPosition.Manual;
                employeeCome.Bounds = new Rectangle(175, 10, width, height);
                buttonFormEmployee = false;
                buttonFormDashboard = false;
                department.Hide();
                employee.Hide();
                _dashboard.Hide();
                listSalary.Hide();
                employeeCome.Show();
                role.Hide();    
            }

        }
        private void ButtonEmployee(object sender, EventArgs e)
        {

            buttonFormEmployee = true;

            if (buttonFormEmployee)
            {
                employee.MdiParent = this;
                employee.StartPosition = FormStartPosition.Manual;
                employee.Bounds = new Rectangle(175, 10, width, height);
                employee.Show();
                department.Hide();
                _dashboard.Hide();
                listSalary.Hide();
                employeeCome.Hide();
                role.Hide();    
                buttonFormDepartment = false;
                buttonFormDashboard = false;

            }

        }
        private void MainApplication_Load(object sender, EventArgs e)
        {


        }

        private void ButtonDepartment(object sender, EventArgs e)
        {
            buttonFormDepartment = true;

            if (buttonFormDepartment)
            {
                department.MdiParent = this;
                department.StartPosition = FormStartPosition.Manual;
                department.Bounds = new Rectangle(175, 10, width, height);
                buttonFormEmployee = false;
                buttonFormDashboard = false;
                department.Show();
                employee.Hide();
                _dashboard.Hide();
                listSalary.Hide();
                employeeCome.Hide();
                role.Hide();

            }

        }

        private void ButtonDashboard(object sender, EventArgs e)
        {
            buttonFormDashboard = true;

            if (buttonFormDashboard)
            {
                _dashboard.MdiParent = this;
                _dashboard.StartPosition = FormStartPosition.Manual;
                _dashboard.Bounds = new Rectangle(175, 10, width, height);
                buttonFormDepartment = false;
                buttonFormEmployee = false;
                _dashboard.Show();
                employee.Hide();
                department.Hide();
                listSalary.Hide();
                employeeCome.Hide();
                role.Hide() ;   
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ShowRegister();
            this.Close();
        }

        private void ShowRegister()
        {
            try
            {
                //registerForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            buttonFormRole = true;

            if (buttonFormRole)
            {
                role.MdiParent = this;
                role.StartPosition = FormStartPosition.Manual;
                role.Bounds = new Rectangle(175, 10, width, height);
                buttonFormDepartment = false;
                buttonFormEmployee = false;
                _dashboard.Hide();
                employee.Hide();
                department.Hide();
                listSalary.Hide();
                employeeCome.Hide();
                role.Show();    
            }
        }

        internal new void ControlAdded(bool isAuthenticated)
        {
            MessageBox.Show(isAuthenticated.ToString());
        }
    }
}
