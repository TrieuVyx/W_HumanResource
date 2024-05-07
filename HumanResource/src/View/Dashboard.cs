using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResource.src.View
{
    public partial class Dashboard : Form
    {
        private readonly EmployeeHistoryController employeeHistoryController;
        private readonly EmployeeReqDTO employeeReqDTO;
        private readonly EmployeeController employeeController;
        public Dashboard()
        {
            InitializeComponent();
            employeeHistoryController = new EmployeeHistoryController();
            employeeReqDTO = new EmployeeReqDTO();
            employeeController = new EmployeeController();
            txtId.ReadOnly = true;
            txtId.Enabled = false;

        }

        private void BtnWatch_Click(object sender, EventArgs e)
        {
            ShowHistory();

        }
        private void ShowHistory()
        {
            try
            {
                List<EmployeeHistoryReqDTO> employeeHistoryReqDTO = employeeHistoryController.FindHistory();

                dataHistoryEmployee.DataSource = employeeHistoryReqDTO;
                dataHistoryEmployee.CellContentClick += AddID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);

            }
        }

        private void AddID(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataHistoryEmployee.Rows[indexOfContent];
            txtId.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            ShowHistory();
        }

        private void BtnWatchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(txtId.Text);
                    List<EmployeeReqDTO> employeeReqs = employeeController.FindAndDetail(employeeReqDTO);
                    if (employeeReqs.Count > 0)
                    {
                        dataRenderEmployee.DataSource = employeeReqs;
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
