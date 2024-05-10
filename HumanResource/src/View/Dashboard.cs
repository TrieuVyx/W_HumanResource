using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
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
        private readonly EmployeeResProfile employeeResProfile;
        private readonly EmployeeHistoryResDTO employeeHistoryRes;
        public Dashboard()
        {
            InitializeComponent();
            employeeHistoryController = new EmployeeHistoryController();
            employeeReqDTO = new EmployeeReqDTO();
            employeeController = new EmployeeController();
            employeeResProfile= new EmployeeResProfile();
            employeeHistoryRes = new EmployeeHistoryResDTO();
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

        private void BtnWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeHistoryRes.EmployId = int.Parse(txtId.Text);
                    List<EmployeeHistoryResDTO> employeeReqs = employeeController.ExportWorkHistory(employeeHistoryRes);
                    if (employeeReqs.Count > 0)
                    {
                        dataShowHistory.DataSource = employeeReqs;
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

        private void BtnPosiition_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeResProfile.EmployId = int.Parse(txtId.Text);
                    List<EmployeeResProfile> employeeReqs = employeeController.ExportPositionHistory(employeeResProfile);
                    if (employeeReqs.Count > 0)
                    {
                        dataShowHistory.DataSource = employeeReqs;
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
                MessageBox.Show("đã xảy ra lỗi BtnPosiition_Click: " + ex.Message);
            }
        }
        //private void BtnPosiition_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(txtId.Text))
        //        {
        //            employeeReqDTO.EmployId = int.Parse(txtId.Text);
        //            List<EmployeeReqDTO> employeeReqs = employeeController.ExportPositionHistory(employeeReqDTO);
        //            if (employeeReqs.Count > 0)
        //            {
        //                dataShowHistory.DataSource = employeeReqs;
        //            }
        //            else
        //            {
        //                dataShowHistory.DataSource = null;

        //                MessageBox.Show("Không tìm thấy");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("ID không được để trống: ");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("đã xảy ra lỗi BtnPosiition_Click: " + ex.Message);
        //    }
        //}
        private void BtnRotation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    employeeResProfile.EmployId = int.Parse(txtId.Text);
                    List<EmployeeReqDTO> employeeReqs = employeeController.FindAndDetail(employeeReqDTO);
                    if (employeeReqs.Count > 0)
                    {
                        dataShowHistory.DataSource = employeeReqs;
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
