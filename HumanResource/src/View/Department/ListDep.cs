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
        }


        //private void btnSearchDepart_Click(object sender, EventArgs e)
        //{
        //    string txtSearchValue = txtSearch.Text;
        //    departmentReqDTO = new DepartmentReqDTO();
        //    try
        //    {
        //        if (txtSearchValue == null ||
        //           txtSearchValue == "" 
        //        )
        //        {
        //            MessageBox.Show("Vui lòng nhập PHÒNG BAN bạn muốn tìm?");
        //        }
        //        else
        //        {
        //            departmentReqDTO.DepDesc = txtSearchValue;
        //            bool depart = departmentController.FindNameDepart(departmentReqDTO);
        //            if (depart)
        //            {

        //                MessageBox.Show("Đã tìm thấy ");
        //            }
        //            else
        //            {
        //                MessageBox.Show("PHÒNG BAN KHÔNG TỒN TẠI ");

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi Phát Sinh Từ ListDep " + ex.Message);
        //    }
        //}
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
                        txtAmout.ReadOnly = true;
                        txtAmout.Enabled = true;
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
    }
}
