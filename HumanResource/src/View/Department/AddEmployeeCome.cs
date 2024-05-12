using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity.Extend;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace HumanResource.src.View.Department
{
    public partial class AddEmployeeCome : Form
    {
        private readonly DepartmentController departmentController;
        private readonly EmployeeController employeeController;
        //private readonly ImportExportController importExportController;
        private EmployeeReqDTO employeeReqDTO;
        private DepartmentReqDTO departmentReqDTO;
        //private readonly ExcelEntity _excelEntity;
        private readonly SaveFileDialog _saveFileDialog;
        private readonly DataTable _dataTable;

        public AddEmployeeCome()
        {
            InitializeComponent();
            departmentController = new DepartmentController();
            employeeController = new EmployeeController();
            employeeReqDTO = new EmployeeReqDTO();
            departmentReqDTO = new DepartmentReqDTO();
            _saveFileDialog= new SaveFileDialog();
            _dataTable = new DataTable();
            //importExportController = new ImportExportController();
            List();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
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
                        bool employees = employeeController.MoveDepart(employeeReqDTO);
                        bool insertHistory = employeeController.UpdateHistory(employeeReqDTO);
                        if (employees && insertHistory)
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
            List<DepartmentResDTO> departments = departmentController.FindAllList();
            dataGridDepartMent.DataSource = departments;
            dataGridDepartMent.CellContentClick += AddId;
            List<EmployeeAndDepartmentReqDTO> employeeAndDepartmentReqDTO = employeeController.FindAllUserNotDep();
            dataGridEmployee.DataSource = employeeAndDepartmentReqDTO;
            dataGridEmployee.CellContentClick += AddIDEmploy;
            txtAmoutEmploy.Text = employeeAndDepartmentReqDTO.Count.ToString();
            txtAmoutEmploy.Enabled = false;
            txtAmoutEmploy.ReadOnly = true;
            txtAmout.ReadOnly = true;
            txtAmout.Enabled = false;
            txtDepartmentId.ReadOnly = true;
            txtDepartmentId.Enabled = false;
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Enabled = false;
            txtListEmployInDepartment.Enabled = false;
            txtListEmployInDepartment.Enabled = false;
        }

        private void AddIDEmploy(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataEmploy = dataGridEmployee.Rows[indexOfContent];
            txtEmployeeId.Text = dataEmploy.Cells[0].Value.ToString();
        }

        private void AddId(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataDep = dataGridDepartMent.Rows[indexOfContent];
            txtDepartmentId.Text = dataDep.Cells[0].Value.ToString();
            txtListEmployInDepartment.Text = dataDep.Cells[1].Value.ToString();
        }

        private void BtbReset_Click(object sender, EventArgs e)
        {
            List();
            txtAmout.Clear();
            txtDepartmentId.Clear();
            txtEmployeeId.Clear();
            txtListEmployInDepartment.Clear();
            txtDepartmentId.Clear();
        }

        private void BtnWatch_Click(object sender, EventArgs e)
        {
            string DepName = txtListEmployInDepartment.Text;
            if (!string.IsNullOrEmpty(DepName))
            {
                EmployeeDep(DepName);
            }
            else
            {
                MessageBox.Show("Tên Phòng Ban không được trống: ");
            }
        }
        private void EmployeeDep(string DepDecs)
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

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelEntity _excelEntity = new ExcelEntity();

                for (int i = 0; i < dataEmployeeDepart.Columns.Count; i++)
                {
                    _dataTable.Columns.Add(dataEmployeeDepart.Columns[i].HeaderText);
                }
                foreach (DataGridViewRow row in dataEmployeeDepart.Rows)
                {
                    DataRow dataRow = _dataTable.NewRow();
                    for (int i = 0; i < dataEmployeeDepart.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                    _dataTable.Rows.Add(dataRow);
                }

                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    string filePath = _saveFileDialog.FileName;
                   
                    List<string> visibleColumns = new List<string>();

                    visibleColumns.AddRange(_dataTable.Columns.Contains("EmployId") ? new[] { "EmployId" } : new string[0]);
                    visibleColumns.AddRange(_dataTable.Columns.Contains("DepDesc") ? new[] { "DepDesc" } : new string[0]);
                    visibleColumns.AddRange(_dataTable.Columns.Contains("EmployeeName") ? new[] { "EmployeeName" } : new string[0]);
                    visibleColumns.AddRange(_dataTable.Columns.Contains("AddressEmployee") ? new[] { "AddressEmployee" } : new string[0]);

                    _excelEntity.ExportDataTableToExcel(_dataTable, filePath, visibleColumns);
                    MessageBox.Show("Bạn đã xuất thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
