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
    public partial class EmployeeHistoryForm : Form
    {
        public EmployeeHistoryForm()
        {
            InitializeComponent();
        }

        private void EmployeeHistoryForm_Load(object sender, EventArgs e)
        {


            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
                string sqlQuery = "SELECT * FROM EmployeeHistory";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            EmployeeHistoryFor.LocalReport.ReportPath = "RDLC/EmployeeHistory.rdlc";
                            ReportDataSource reportDataSource = new ReportDataSource("EmployeeHistoryDataSet", dataTable);
                            EmployeeHistoryFor.LocalReport.DataSources.Clear();
                            EmployeeHistoryFor.LocalReport.DataSources.Add(reportDataSource);

                            this.EmployeeHistoryFor.RefreshReport();
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
