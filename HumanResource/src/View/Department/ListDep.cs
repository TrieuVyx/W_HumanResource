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
using System.Web.Security;

namespace HumanResource.src.View.Department
{
    public partial class ListDep : Form
    {
        private DepartmentReqDTO departmentReqDTO;
        private DepartmentController departmentController;
        private EmployeeResDTO employeeResDTO;
        private EmployeeReqDTO employeeReqDTO;
        private EmployeeController employeeController;
        public ListDep()
        {
            InitializeComponent();
            departmentController = new DepartmentController();
            departmentReqDTO = new DepartmentReqDTO();
            employeeResDTO = new EmployeeResDTO();  
            employeeReqDTO = new EmployeeReqDTO();  
            employeeController = new EmployeeController();
            ShowDepartment();
        }
      
        private void ShowDepartment()
        {
            try
            {
                List<DepartmentResDTO> departments = departmentController.findAllList();
                GridViewDepartment.DataSource = departments;
                txtComboDep.DataSource = departments;
                txtComboDep.DisplayMember = "DepDesc";
                txtComboDep.ValueMember = "DepId";
                txtComboDep.SelectedIndex = 1;
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
            txtDepartmentName.Enabled = false;
            txtID.Enabled = false;
            txtDepartmentName.ReadOnly = true;
            txtID.ReadOnly = true;
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

        private void btnMoveHouse_Click(object sender, EventArgs e)
        {
            try
            {
                int DepId;
                employeeReqDTO = new EmployeeReqDTO();
                if (int.TryParse(txtComboDep.SelectedValue.ToString(), out DepId))
                {
                    employeeReqDTO.DepId = DepId;
                }
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn chuyển đổi phòng ban không?!", "Xác nhận câp nhật", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        employeeReqDTO.DepId = DepId;
                        employeeReqDTO.EmployId = int.Parse(txtID.Text);
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
    }
}
