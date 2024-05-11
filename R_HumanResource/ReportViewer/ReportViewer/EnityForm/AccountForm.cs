using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportViewer;
using System.Windows.Forms;
using ReportViewer.Entity;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static ReportViewer.HumanResourceDataSet;

namespace ReportViewer.EnityForm
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
                string sqlQuery = "SELECT * FROM Account";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            AccountFor.LocalReport.ReportPath = "RDLC/Account.rdlc";
                            ReportDataSource reportDataSource = new ReportDataSource("AccountDataSet", dataTable);
                            AccountFor.LocalReport.DataSources.Clear();
                            AccountFor.LocalReport.DataSources.Add(reportDataSource);

                            this.AccountFor.RefreshReport();
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
