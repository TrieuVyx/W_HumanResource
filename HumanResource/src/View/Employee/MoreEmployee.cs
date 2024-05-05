using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.View.Employee
{
    public partial class MoreEmployee : Form
    {
        private EmployeeController employeeController;
        private EmployeeReqDTO employeeReqDTO;
        public MoreEmployee()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            employeeReqDTO = new EmployeeReqDTO();  
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string FullName = TXTHOTEN.Text;
            string Phone = txtsodienthoai.Text;
            string Email = TXTemail.Text;
            string Address = txtAddress.Text;
            string Id = txtid.Text;





            employeeReqDTO = new EmployeeReqDTO();
            try
            {
                //if (string.IsNullOrEmpty(txtSearchValue))
                //{
                //    MessageBox.Show("Vui lòng nhập PHÒNG BAN bạn muốn tìm.");
                //}
                //else
                //{
                //    departmentReqDTO.DepDesc = txtSearchValue;
                //    List<EmployeeResDTO> employees = departmentController.FindNameDepart(departmentReqDTO);
                //    if (employees.Count > 0)
                //    {
                //        GridViewDepartment.DataSource = employees;
                //        txtAmout.Text = employees.Count.ToString();

                //        AutoMode();

                //        GridViewDepartment.CellContentClick += GridViewDepartment_CellContentClick;
                //    }
                //    else
                //    {
                //        GridViewDepartment.DataSource = null;
                //        MessageBox.Show("Không tìm thấy nhân viên nào trong phòng ban này.");
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ MoreEmployee " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Lock()
        {
            txtid.ReadOnly = true;
            txtid.Enabled = false;
        }
    }
}
