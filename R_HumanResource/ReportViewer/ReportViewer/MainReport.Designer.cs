namespace ReportViewer
{
    partial class MainReport
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relativeEmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyEmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeReportToolStripMenuItem,
            this.departmentReportToolStripMenuItem,
            this.salaryReportToolStripMenuItem,
            this.accountReportToolStripMenuItem,
            this.relativeEmployeeReportToolStripMenuItem,
            this.historyEmployeeReportToolStripMenuItem,
            this.degreeReportToolStripMenuItem,
            this.roleReportToolStripMenuItem,
            this.educationReportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.employeeReportToolStripMenuItem.Text = "EmployeeReport";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.BtnEmployeeReport_Click);
            // 
            // departmentReportToolStripMenuItem
            // 
            this.departmentReportToolStripMenuItem.Name = "departmentReportToolStripMenuItem";
            this.departmentReportToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.departmentReportToolStripMenuItem.Text = "DepartmentReport";
            this.departmentReportToolStripMenuItem.Click += new System.EventHandler(this.BtnDepartmentReport_Click);
            // 
            // salaryReportToolStripMenuItem
            // 
            this.salaryReportToolStripMenuItem.Name = "salaryReportToolStripMenuItem";
            this.salaryReportToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.salaryReportToolStripMenuItem.Text = "SalaryReport";
            this.salaryReportToolStripMenuItem.Click += new System.EventHandler(this.BtnSalaryReport_Click);
            // 
            // accountReportToolStripMenuItem
            // 
            this.accountReportToolStripMenuItem.Name = "accountReportToolStripMenuItem";
            this.accountReportToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.accountReportToolStripMenuItem.Text = "AccountReport";
            this.accountReportToolStripMenuItem.Click += new System.EventHandler(this.BtnAccountReport_Click);
            // 
            // relativeEmployeeReportToolStripMenuItem
            // 
            this.relativeEmployeeReportToolStripMenuItem.Name = "relativeEmployeeReportToolStripMenuItem";
            this.relativeEmployeeReportToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.relativeEmployeeReportToolStripMenuItem.Text = "RelativeEmployeeReport";
            this.relativeEmployeeReportToolStripMenuItem.Click += new System.EventHandler(this.BtnRelativeEmployeeReport_Click);
            // 
            // historyEmployeeReportToolStripMenuItem
            // 
            this.historyEmployeeReportToolStripMenuItem.Name = "historyEmployeeReportToolStripMenuItem";
            this.historyEmployeeReportToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.historyEmployeeReportToolStripMenuItem.Text = "HistoryEmployee Report";
            this.historyEmployeeReportToolStripMenuItem.Click += new System.EventHandler(this.BtnEmployeeHistoryReport_Click);
            // 
            // degreeReportToolStripMenuItem
            // 
            this.degreeReportToolStripMenuItem.Name = "degreeReportToolStripMenuItem";
            this.degreeReportToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.degreeReportToolStripMenuItem.Text = "DegreeReport";
            this.degreeReportToolStripMenuItem.Click += new System.EventHandler(this.BtnDegreeReport_Click);
            // 
            // roleReportToolStripMenuItem
            // 
            this.roleReportToolStripMenuItem.Name = "roleReportToolStripMenuItem";
            this.roleReportToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.roleReportToolStripMenuItem.Text = "RoleReport";
            this.roleReportToolStripMenuItem.Click += new System.EventHandler(this.BtnRolesReport_Click);
            // 
            // educationReportToolStripMenuItem
            // 
            this.educationReportToolStripMenuItem.Name = "educationReportToolStripMenuItem";
            this.educationReportToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.educationReportToolStripMenuItem.Text = "EducationReport";
            this.educationReportToolStripMenuItem.Click += new System.EventHandler(this.BtnEducationReport_Click);
            // 
            // MainReport
            // 
            this.ClientSize = new System.Drawing.Size(1276, 508);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainReport";
            this.Text = "Quản Lý Nhân Sự";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnEmployeeReport;
        private System.Windows.Forms.ToolStripMenuItem BtnDepartmentReport;
        private System.Windows.Forms.ToolStripMenuItem BtnSalaryReport;
        private System.Windows.Forms.ToolStripMenuItem BtnRolesReport;
        private System.Windows.Forms.ToolStripMenuItem BtnEducationReport;
        private System.Windows.Forms.ToolStripMenuItem BtnDegreeReport;
        private System.Windows.Forms.ToolStripMenuItem BtnEmployeeHistoryReport;
        private System.Windows.Forms.ToolStripMenuItem BtnRelativeEmployeeReport;
        private System.Windows.Forms.ToolStripMenuItem BtnAccountReport;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relativeEmployeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyEmployeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationReportToolStripMenuItem;
    }
}

