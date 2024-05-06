using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HumanResource.src.View.Salary
{
    public partial class ListSalary : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-EIIG3BE\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();



        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from Roles";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public ListSalary()
        {
            InitializeComponent();
        }

        private void ListSalary_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();

            command.CommandText = "insert into Roles values('" + rtbrole.Text + "','" + rtbRoleDescription.Text + "','" + rtbEmloyeename.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();

            command.CommandText = "delete from Roles where RoleId ='" + rtbrole.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();

            command.CommandText = "update  Roles set RoleDesc ='" + rtbEmloyeename.Text + "',RoleName='" + rtbRoleDescription.Text + "'where RoleId='" + rtbrole.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv.CurrentRow.Index;
            rtbrole.Text = dgv.Rows[i].Cells[0].Value.ToString();
            rtbRoleDescription.Text = dgv.Rows[i].Cells[1].Value.ToString();
            rtbEmloyeename.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }
    }
}
