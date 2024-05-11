namespace ReportViewer.EnityForm
{
    partial class RelavtiveEmployeeForm
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
            this.RelativeEmployeeFor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RelativeEmployeeFor
            // 
            this.RelativeEmployeeFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelativeEmployeeFor.Location = new System.Drawing.Point(0, 0);
            this.RelativeEmployeeFor.Name = "RelativeEmployeeFor";
            this.RelativeEmployeeFor.ServerReport.BearerToken = null;
            this.RelativeEmployeeFor.Size = new System.Drawing.Size(800, 450);
            this.RelativeEmployeeFor.TabIndex = 0;
            // 
            // RelavtiveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RelativeEmployeeFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelavtiveEmployeeForm";
            this.Text = "RelavtiveEmployeeFor";
            this.Load += new System.EventHandler(this.RelavtiveEmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RelativeEmployeeFor;
    }
}