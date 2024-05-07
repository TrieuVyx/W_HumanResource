using HumanResource.src.View;
using HumanResource.src.View.Department;
using HumanResource.src.View.Employee;
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
        readonly Dashboard dashboard = new Dashboard();
        readonly ListSalary listSalary = new ListSalary();
        readonly AddEmployeeCome employeeCome = new AddEmployeeCome();
        readonly int height = 470;
        readonly int width = 700;

        private bool buttonFormSalary = false;
        private bool buttonFormDepartment = false;
        private bool buttonFormEmployee = false;
        private bool buttonFormDashboard = true;
        //private bool buttonRole = false;
        private bool buttonEmployDepartment = false;

        public MainApplication()
        {

            InitializeComponent();
            this.IsMdiContainer = true;
            if (buttonFormDashboard)
            {
                dashboard.MdiParent = this;
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Bounds = new Rectangle(175, 10, width, height);


                dashboard.Show();
                employee.Hide();
                department.Hide();
                listSalary.Hide();
                employeeCome.Hide();

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
                dashboard.Hide();
                listSalary.Show();
                employeeCome.Hide();
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
                dashboard.Hide();
                listSalary.Hide();
                employeeCome.Show();

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
                dashboard.Hide();
                listSalary.Hide();
                employeeCome.Hide();

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
                dashboard.Hide();
                listSalary.Hide();
                employeeCome.Hide();


            }

        }

        private void ButtonDashboard(object sender, EventArgs e)
        {
            buttonFormDashboard = true;

            if (buttonFormDashboard)
            {
                dashboard.MdiParent = this;
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Bounds = new Rectangle(175, 10, width, height);
                buttonFormDepartment = false;
                buttonFormEmployee = false;
                dashboard.Show();
                employee.Hide();
                department.Hide();
                listSalary.Hide();
                employeeCome.Hide();

            }
        }


    }
}
