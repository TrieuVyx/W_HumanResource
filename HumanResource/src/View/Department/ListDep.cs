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
            ShowDepartment();
        }
        private void ShowDepartment() {
            try
            {
                List<DepartmentResDTO> departments =  departmentController.findAllList();
                GridViewDepartment.DataSource = departments;
                txtAmout.Text = departments.Count.ToString();
                AutoMode();
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
                        //GridViewDepartment.Click += ButtonGetSelectedRows_Click;
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
        private void ButtonGetSelectedRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in GridViewDepartment.SelectedRows)
            {
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    // Thực hiện các thao tác với ô trong hàng được chọn tại đây
                    string cellValue = cell.Value.ToString();
                    MessageBox.Show("Selected Cell Value: " + cellValue.ToString());
                }
            }
        }
    }
}
