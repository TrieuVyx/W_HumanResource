using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HumanResource.src.View.Employee
{
    public partial class ListEmployee : Form
    {
        private Employees employee;
        private readonly EmployeeController employeeController;
        private readonly EmployeeReqDTO employeeReqDTO;
        private readonly EmployeeReferenceReqDTO employeeReferenceReqDTO;
        readonly MoreEmployee moreEmployee;

        public ListEmployee()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            employee = new Employees();
            employeeReqDTO = new EmployeeReqDTO();
            employeeReferenceReqDTO = new EmployeeReferenceReqDTO();
            moreEmployee = new MoreEmployee();  
            GridViewEmployee.CellContentClick += ChooseItem;
            ShowEmployee();
        }
        private void ChooseItem(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = GridViewEmployee.Rows[indexOfContent];
            txtId.Text = dataGridViewRow.Cells[0].Value.ToString();
        }
        private void ShowEmployee()
        {

            try
            {
                List<Employees> employeeRes = employeeController.FindAllList();
                GridViewEmployee.DataSource = employeeRes;
                txtAmout.Text = employeeRes.Count.ToString();
                txtSearchBox.Clear();
                AutoMode();
                GridViewLock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListEmployee " + ex.Message);
            }
        }
        private void AutoMode()
        {
            txtAmout.ReadOnly = true;
            txtAmout.Enabled = false;
            txtId.ReadOnly = true;
            txtId.Enabled = false;
        }
        private void GridViewLock()
        {
            GridViewEmployee.ReadOnly = true;
            //GridViewDepartment.Enabled = false;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string txtSearchValue = txtSearchBox.Text;
            employee = new Employees();
            try
            {
                if (string.IsNullOrEmpty(txtSearchValue))
                {
                    MessageBox.Show("Vui lòng nhập NHÂN VIÊN bạn muốn tìm.");
                }
                else
                {
                    employee.EmployeeName = txtSearchValue;
                    List<Employees> employees = employeeController.FindNameEmployee(employee);
                    if (employees.Count > 0)
                    {
                        GridViewEmployee.DataSource = employees;
                        txtAmout.Text = employees.Count.ToString();
                        AutoMode();

                    }
                    else
                    {
                        GridViewEmployee.DataSource = null;
                        MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListEmployee " + ex.Message);
            }
        }
        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            ShowEmployee();
            txtSearchBox.Clear();
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            moreEmployee.StartPosition = FormStartPosition.Manual;
            moreEmployee.Bounds = new Rectangle(x, y, width, height);
            moreEmployee.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)

        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(txtId.Text);

                    List<EmployeeReqDTO> employeeReqs = employeeController.FindAndDetail(employeeReqDTO);
                    if (employeeReqs.Count > 0)
                    {
                        Update update = new Update();
                        update.ControlAdded(employeeReqs);
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

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(txtId.Text);
                    List<EmployeeReqDTO> employeeReqs = employeeController.FindAndDetail(employeeReqDTO);
                    if (employeeReqs.Count > 0)
                    {
                        Read read = new Read();
                        read.ControlAdded(employeeReqs);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(txtId.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool employeeReqs = employeeController.FindAndDelete(employeeReqDTO);
                        if (employeeReqs)
                        {
                            MessageBox.Show("Xoá thành công, vui lòng reset để kiểm tra ^");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy");
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


        private void BtnRefer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReferenceReqDTO.EmployId = int.Parse(txtId.Text);

                    List<EmployeeReferencesResDTO> employeeReqs = employeeController.FindReferences(employeeReferenceReqDTO);
                    if (employeeReqs.Count > 0)
                    {
                        References read = new References();
                        read.ControlAdded(employeeReqs);
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
    }
}
