using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ReportViewer.HumanResourceDataSet;

namespace ReportViewer.EnityForm
{
    public partial class RelavtiveEmployeeForm : Form
    {
        public RelavtiveEmployeeForm()
        {
            InitializeComponent();
        }

        private void RelavtiveEmployeeForm_Load(object sender, EventArgs e)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
                string sqlQuery = "SELECT * FROM RelativeEmployee";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            RelativeEmployeeFor.LocalReport.ReportPath = "RDLC/RelativeEmployee.rdlc";
                            ReportDataSource reportDataSource = new ReportDataSource("RelativeEmployeeDataSet", dataTable);
                            RelativeEmployeeFor.LocalReport.DataSources.Clear();
                            RelativeEmployeeFor.LocalReport.DataSources.Add(reportDataSource);

                            this.RelativeEmployeeFor.RefreshReport();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
