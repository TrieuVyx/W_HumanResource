namespace ReportViewer.EnityForm
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.humanResourceDataSet = new ReportViewer.HumanResourceDataSet();
            this.AccountFor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.humanResourceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new ReportViewer.HumanResourceDataSetTableAdapters.AccountTableAdapter();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.humanResourceDataSet;
            // 
            // humanResourceDataSet
            // 
            this.humanResourceDataSet.DataSetName = "HumanResourceDataSet";
            this.humanResourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountFor
            // 
            this.AccountFor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.accountBindingSource1;
            this.AccountFor.LocalReport.DataSources.Add(reportDataSource1);
            this.AccountFor.LocalReport.ReportEmbeddedResource = "ReportViewer.RDLC.Account.rdlc";
            this.AccountFor.Location = new System.Drawing.Point(0, 0);
            this.AccountFor.Name = "AccountFor";
            this.AccountFor.ServerReport.BearerToken = null;
            this.AccountFor.Size = new System.Drawing.Size(800, 450);
            this.AccountFor.TabIndex = 0;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.humanResourceDataSet;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer AccountFor;
        private System.Windows.Forms.BindingSource humanResourceDataSetBindingSource;
        private HumanResourceDataSet humanResourceDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private HumanResourceDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource1;
    }
}