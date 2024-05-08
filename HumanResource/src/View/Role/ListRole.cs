using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.src.View.Role
{
    public partial class ListRole : Form
    {
        private readonly RoleController roleController;
        public ListRole()
        {
            InitializeComponent();
            roleController = new RoleController();
            txtIdAmount.Enabled = false;
            txtIdRole.Enabled = false;
            txtIdAmount.ReadOnly = true;
            txtIdRole.ReadOnly = true;
            txtIdEmployee.ReadOnly = true;
            txtIdEmployee.Enabled =  false;
            ShowRole();
        }
        private void ShowRole()
        {
            try
            {
                List<RoleReqDTO> role = roleController.FindAllRole();
                ViewRoleData.DataSource = role;
                txtIdAmount.Text = role.Count.ToString();
                ViewRoleData.CellContentClick += AddId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ RoleController " + ex.Message);
            }
        }

        private void AddId(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = ViewRoleData.Rows[indexOfContent];
            txtIdRole.Text = dataGridViewRow.Cells[0].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void BtnWatch_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ShowRole();
            txtIdAmount.Clear();
            txtIdRole.Clear();  
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
