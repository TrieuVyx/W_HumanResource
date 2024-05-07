using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResource.src.View.Department
{
    public partial class AddEmployeeCome : Form
    {
        private EmployeeAndDepartmentReqDTO employeeAndDepartmentReqDTO;
        private DepartmentController departmentController;
        private DepartmentResDTO departmentResDTO;
        private EmployeeController employeeController;
        private EmployeeReqDTO employeeReqDTO;
        private DepartmentReqDTO departmentReqDTO;
        public AddEmployeeCome()
        {
            InitializeComponent();
            departmentController = new DepartmentController();
            departmentResDTO = new DepartmentResDTO();
            employeeAndDepartmentReqDTO = new EmployeeAndDepartmentReqDTO();
            employeeController = new EmployeeController();
            employeeReqDTO = new EmployeeReqDTO();
            departmentReqDTO = new DepartmentReqDTO();
            List();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                string employId = txtEmployeeId.Text;
                string depId = txtDepartmentId.Text;
                employeeReqDTO = new EmployeeReqDTO();

                if (!string.IsNullOrEmpty(employId))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn chuyển đổi phòng ban không?!", "Xác nhận câp nhật", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        employeeReqDTO.DepId = int.Parse(depId);
                        employeeReqDTO.EmployId = int.Parse(employId);
                        bool employees = employeeController.moveDepart(employeeReqDTO);
                        if (employees)
                        {
                            MessageBox.Show("Bạn đã di chuyển nhân viên đến nơi khác ^, vui lòng reset lại để cập nhật");
                        }
                        else
                        {
                            MessageBox.Show("đã xảy ra lỗi vui lòng thử lại");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Bạn đã huỷ lựa chọn");
                    }
                }
                else
                {
                    MessageBox.Show("ID không được để trống: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void List()
        {
            List<DepartmentResDTO> departments = departmentController.findAllList();
            dataGridDepartMent.DataSource = departments;
            dataGridDepartMent.CellContentClick += addId;
            List<EmployeeAndDepartmentReqDTO> employeeAndDepartmentReqDTO = employeeController.FindAllUserNotDep();
            dataGridEmployee.DataSource = employeeAndDepartmentReqDTO;
            dataGridEmployee.CellContentClick += addIDEmploy;
            txtAmout.Text = employeeAndDepartmentReqDTO.Count.ToString();
            txtAmout.ReadOnly = true;
            txtAmout.Enabled = false;
            txtDepartmentId.ReadOnly = true;
            txtDepartmentId.Enabled = false;
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Enabled = false;
            txtListEmployInDepartment.Enabled = false;
            txtListEmployInDepartment.Enabled = false;

        }

        private void addIDEmploy(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataEmploy = dataGridEmployee.Rows[indexOfContent];
            txtEmployeeId.Text = dataEmploy.Cells[0].Value.ToString();
        }

        private void addId(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataDep = dataGridDepartMent.Rows[indexOfContent];
            txtDepartmentId.Text = dataDep.Cells[0].Value.ToString();
            txtListEmployInDepartment.Text = dataDep.Cells[1].Value.ToString();
        }

        private void btbReset_Click(object sender, EventArgs e)
        {
            List();
            txtAmout.Clear();
            txtDepartmentId.Clear();
            txtEmployeeId.Clear();
            txtListEmployInDepartment.Clear();
            txtDepartmentId.Clear();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            string DepName = txtListEmployInDepartment.Text;
            if (!string.IsNullOrEmpty(DepName))
            {
                employeeDep(DepName);
            }
            else
            {
                MessageBox.Show("Tên Phòng Ban không được trống: ");
            }
        }
        private void employeeDep(string DepDecs)
        {
            departmentReqDTO = new DepartmentReqDTO();

            try
            {
                departmentReqDTO.DepDesc = DepDecs;
                List<EmployeeResDTO> employees = departmentController.FindNameDepart(departmentReqDTO);
                if (employees.Count > 0)
                {
                    dataEmployeeDepart.DataSource = employees;
                    txtAmoutEmploy.Text = employees.Count.ToString();
                    txtAmoutEmploy.Enabled = false;
                    txtAmoutEmploy.ReadOnly = true;
                }
                else
                {
                    dataEmployeeDepart.DataSource = null;
                    MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
