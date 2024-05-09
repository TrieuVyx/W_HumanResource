using HumanResource.src.Controller;
using HumanResource.src.DTO.Response;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResource.src.View.Salary
{
    public partial class ListSalary : Form
    {
        private readonly SalaryController salaryController;
        public ListSalary()
        {
            InitializeComponent();
            salaryController = new SalaryController();
            DataSalary.ReadOnly = true;
            DataSalary.Enabled = false;
            
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
