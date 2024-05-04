using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.src.Entity;
using HumanResource.src.Service;
using HumanResource.src.DTO.Response;
using System.Web.UI.WebControls;
using Microsoft.IdentityModel.Tokens;
using HumanResource.src.View.Department;

namespace HumanResource.src.View.Department
{
    public partial class ListDep : Form
    {
        private DepartmentReqDTO departmentReqDTO;
        private DepartmentController departmentController;
        private EmployeeResDTO employeeResDTO;
        public ListDep()
        {
            InitializeComponent();
            departmentController = new DepartmentController();
            departmentReqDTO = new DepartmentReqDTO();
            employeeResDTO = new EmployeeResDTO();  
            ShowDepartment();
        }
      
        private void ShowDepartment()
        {
            try
            {
                List<DepartmentResDTO> departments = departmentController.findAllList();
                GridViewDepartment.DataSource = departments;
                txtAmout.Text = departments.Count.ToString();
                txtSearch.Clear();  
                AutoMode();
                GridViewLock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListDep " + ex.Message);
            }
        }
        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            string txtSearchValue = txtSearch.Text;
            departmentReqDTO = new DepartmentReqDTO();
            try
            {
                if (string.IsNullOrEmpty(txtSearchValue))
                {
                    MessageBox.Show("Vui lòng nhập PHÒNG BAN bạn muốn tìm.");
                }
                else
                {
                    departmentReqDTO.DepDesc = txtSearchValue;
                    List<EmployeeResDTO> employees = departmentController.FindNameDepart(departmentReqDTO);
                    if (employees.Count > 0)
                    {
                        GridViewDepartment.DataSource = employees;
                        txtAmout.Text = employees.Count.ToString();

                        AutoMode();

                        GridViewDepartment.CellContentClick += GridViewDepartment_CellContentClick;
                    }
                    else
                    {
                        GridViewDepartment.DataSource = null;
                        MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListDep " + ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowDepartment();
        }
        private void AutoMode()
        {
            txtAmout.ReadOnly = true;
            txtAmout.Enabled = false;
        }
        private void GridViewLock()
        {
            GridViewDepartment.ReadOnly = true;
            //GridViewDepartment.Enabled = false;
        }
        private void GridViewDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = GridViewDepartment.Rows[indexOfContent];
            txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtDepartmentName.Text = dataGridViewRow.Cells[1].Value.ToString();
        }
        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    departmentReqDTO.DepId = int.Parse(txtID.Text);

                    List<DepartmentResDTO> departmentRes = departmentController.findIdDepartMent(departmentReqDTO);
                    if (departmentRes.Count > 0)
                    {
                        Update update = new Update();
                        update.ControlAdded(departmentRes);
                        this.Hide();
                    }
                    else      
                    {
                        MessageBox.Show("Không tìm thấy");                       
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

        private void btnDeleteEmploy_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    employeeResDTO.EmployId = int.Parse(txtID.Text);

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
