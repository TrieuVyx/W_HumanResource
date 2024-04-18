using HumanResource.src.DbContext;
using HumanResource.src.View.Employee;
using HumanResource.src.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class MainApplication : Form
    {
        private Dbcontext dbcontext;
        private Point Point;


        ListEmployee employee = new ListEmployee();
        ListDep department = new ListDep();
        Dashboard dashboard = new Dashboard();  

        private bool buttonFormSalary = false;
        private bool buttonFormDepartment= false;
        private bool buttonFormEmployee = false;
        private bool buttonFormDashboard= true;
        private bool buttonRole = false;


        public MainApplication()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (buttonFormDashboard)
            {
                dashboard.MdiParent = this;
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Bounds = new Rectangle(175, 10, 700, 400);
                dashboard.Show();

                employee.Hide();
                department.Hide();
            }

        }
        private MainApplication main;
        private void ConnectToDatabase()
        {

            dbcontext = new Dbcontext();
            dbcontext.connectDB();

        }

        private void connectDB(object sender, EventArgs e)
        {
            ConnectToDatabase();

        }

        private void ButtonSalary(object sender, EventArgs e)
        {

        }

        private void ButtonEmployee(object sender, EventArgs e)
        {
            buttonFormEmployee = true;

            if (buttonFormEmployee)
            {
                employee.MdiParent = this;
                employee.StartPosition = FormStartPosition.Manual;
                employee.Bounds = new Rectangle(175, 10, 700, 400);
                employee.Show();


                department.Hide();
                dashboard.Hide();   

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
                department.Bounds = new Rectangle(175, 10, 700, 400);


                buttonFormEmployee = false;
                buttonFormDashboard = false;

                department.Show();
                employee.Hide();
                dashboard.Hide();


            }

        }
        
        private void ButtonDashboard(object sender, EventArgs e)
        {
            buttonFormDashboard = true;

            if (buttonFormDashboard)
            {
                dashboard.MdiParent = this;
                dashboard.StartPosition = FormStartPosition.Manual;
                dashboard.Bounds = new Rectangle(175, 10, 700, 400);

                buttonFormDepartment = false;
                buttonFormEmployee = false;
                
                
                dashboard.Show();

                employee.Hide();
                department.Hide();
            }
        }
    }
}
