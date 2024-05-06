using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.View.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.View
{
    public partial class Dashboard : Form
    {
        private EmployeeHistoryController employeeHistoryController;
        private EmployeeHistoryReqDTO employeeHistoryReqDTO;
        private EmployeeReqDTO employeeReqDTO;
        private EmployeeController employeeController;
        public Dashboard()
        {
            InitializeComponent();
            employeeHistoryController = new EmployeeHistoryController();
            employeeHistoryReqDTO = new EmployeeHistoryReqDTO();
            employeeReqDTO = new EmployeeReqDTO();
            employeeController = new EmployeeController();
            txtId.ReadOnly = true;
            txtId.Enabled = false;

        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            ShowHistory();

        }
        private void ShowHistory()
        {
            try
            {
                List<EmployeeHistoryReqDTO> employeeHistoryReqDTO = employeeHistoryController.FindHistory();

                dataHistoryEmployee.DataSource = employeeHistoryReqDTO;
                dataHistoryEmployee.CellContentClick += addID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);

            }
        }

        private void addID(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataHistoryEmployee.Rows[indexOfContent];
            txtId.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }

        private void btnWatchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(txtId.Text);
                    List<EmployeeReqDTO> employeeReqs = employeeController.findAndDetail(employeeReqDTO);
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
