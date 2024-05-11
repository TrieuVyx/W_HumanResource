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
    public partial class DegreeForm : Form
    {
        public DegreeForm()
        {
            InitializeComponent();
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
                string sqlQuery = "SELECT * FROM Degree";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DegreeFor.LocalReport.ReportPath = "RDLC/Degree.rdlc";
                            ReportDataSource reportDataSource = new ReportDataSource("DegreeDataSet", dataTable);
                            DegreeFor.LocalReport.DataSources.Clear();
                            DegreeFor.LocalReport.DataSources.Add(reportDataSource);

                            this.DegreeFor.RefreshReport();
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
