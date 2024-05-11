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
            this.SuspendLayout();
            // 
            // MainReport
            // 
            this.ClientSize = new System.Drawing.Size(1013, 508);
            this.Name = "MainReport";
            this.ResumeLayout(false);

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
    }
}

