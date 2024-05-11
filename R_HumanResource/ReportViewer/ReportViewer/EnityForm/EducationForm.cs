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
    public partial class EducationForm : Form
    {
        public EducationForm()
        {
            InitializeComponent();
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {


            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
                string sqlQuery = "SELECT * FROM Education";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            EducationFor.LocalReport.ReportPath = "RDLC/Education.rdlc";
                            ReportDataSource reportDataSource = new ReportDataSource("EducationDataSet", dataTable);
                            EducationFor.LocalReport.DataSources.Clear();
                            EducationFor.LocalReport.DataSources.Add(reportDataSource);

                            this.EducationFor.RefreshReport();
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
