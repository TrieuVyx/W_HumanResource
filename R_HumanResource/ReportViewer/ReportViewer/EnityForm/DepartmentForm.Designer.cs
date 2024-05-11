namespace ReportViewer.EnityForm
{
    partial class DepartmentForm
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
            this.DepartmentFor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // DepartmentFor
            // 
            this.DepartmentFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentFor.LocalReport.ReportEmbeddedResource = "ReportViewer.RDLC.Department.rdlc";
            this.DepartmentFor.Location = new System.Drawing.Point(0, 0);
            this.DepartmentFor.Name = "DepartmentFor";
            this.DepartmentFor.ServerReport.BearerToken = null;
            this.DepartmentFor.Size = new System.Drawing.Size(800, 450);
            this.DepartmentFor.TabIndex = 0;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartmentFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DepartmentFor;
    }
}