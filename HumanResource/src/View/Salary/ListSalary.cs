using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using HumanResource.src.View.Employee;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResource.src.View.Salary
{
    public partial class ListSalary : Form
    {
        private readonly SalaryController salaryController;
        private readonly SalaryReqDTO salaryReqDTO;
        public ListSalary()
        {
            InitializeComponent();
            salaryController = new SalaryController();
            salaryReqDTO = new SalaryReqDTO();  
            DataSalary.ReadOnly = true;
            //DataSalary.Enabled = false;
            
        }

        private void BtnWatch_Click(object sender, EventArgs e)
        {
            ShowSalary();
        }
        private void ShowSalary()
        {
            try
            {
                List<SalaryResDTO> salaryResDTOs = salaryController.FindAllList();
                if(salaryResDTOs.Count > 0 ) { 
                    DataSalary.DataSource = salaryResDTOs;
                    DataSalary.CellContentClick += AddId;
                    //MessageBox.Show("true");
                }
                else
                {
                    DataSalary.DataSource = null;
                    MessageBox.Show("Data khong tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ ListSalary " + ex.Message);
            }
        }

        private void AddId(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = DataSalary.Rows[indexOfContent];
            TxTId.Text = dataGridViewRow.Cells[0].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxTId.Text))
                {
                    salaryReqDTO.SalaryId = int.Parse(TxTId.Text);
                    List<SalaryEmployeeResDTO> salaryEmployeeResDTOs = salaryController.FindEmployee(salaryReqDTO);
                    if (salaryEmployeeResDTOs.Count > 0)
                    {
                        EmployeeList.DataSource = salaryEmployeeResDTOs;    
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
