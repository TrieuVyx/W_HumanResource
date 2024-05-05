using HumanResource.src.Controller;
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

namespace HumanResource.src.View.Department
{
    public partial class Update : Form
    {
        private List<DepartmentResDTO> departmentRes;
        private EmployeeResDTO employeeResDTO;
        private DepartmentController departmentController;
        private DepartmentReqDTO departmentReqDTO;
        private EmployeeReqDTO employeeReqDTO;

        public Update()
        {
            InitializeComponent();
            departmentRes = new List<DepartmentResDTO>();
            employeeResDTO = new EmployeeResDTO();
            departmentController = new DepartmentController();
            departmentReqDTO = new DepartmentReqDTO();
            employeeReqDTO = new EmployeeReqDTO();
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
                employeeDep(txtDesc.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string DepPlace = txtDepPlace.Text;
                string DepType = txtDepType.Text;
                string Desc = txtDesc.Text;
                string Id = txtIDDepartment.Text;
               
                departmentReqDTO = new DepartmentReqDTO();
                if (!string.IsNullOrEmpty(txtIDDepartment.Text))
                {
                    departmentReqDTO.DepId = int.Parse(txtIDDepartment.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?!", "Xác nhận câp nhật", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        departmentReqDTO.DepId = int.Parse(Id);
                        departmentReqDTO.DepDesc = Desc;
                        departmentReqDTO.DepPlace = DepPlace;
                        departmentReqDTO.DepType = DepType;

                        bool employeeReqs = departmentController.findAndUpdate(departmentReqDTO);
                        if (employeeReqs)
                        {
                            MessageBox.Show("CẬP NHẬT THÀNH CÔNG, VUI LÒNG ẤN RESET ĐỂ CẬP NHẬT LẠI");
                        }
                        else
                        {
                            MessageBox.Show("CẬP NHẬT THẤT BẠI");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    GridViewEmployee.DataSource = employees;
                    GridViewEmployee.CellContentClick += GridViewEmployee_CellContentClick;
                    txtIDEmployee.ReadOnly = true;
                    txtIDEmployee.Enabled = false;
                }
                else
                {
                    GridViewEmployee.DataSource = null;
                    MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void GridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = GridViewEmployee.Rows[indexOfContent];
            txtIDEmployee.Text = dataGridViewRow.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtIDEmployee.Text))
                {
                    employeeResDTO.EmployId = int.Parse(txtIDEmployee.Text);

                    List<EmployeeResDTO> employeeRes = departmentController.findAndDelete(employeeResDTO);
                    MessageBox.Show("Bạn đã xoá nhân viên ra khỏi phòng ban");
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

      
    }
}
