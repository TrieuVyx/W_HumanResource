namespace ReportViewer.EnityForm
{
    partial class DegreeForm
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
            this.DegreeFor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // DegreeFor
            // 
            this.DegreeFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DegreeFor.LocalReport.ReportEmbeddedResource = "ReportViewer.RDLC.Degree.rdlc";
            this.DegreeFor.Location = new System.Drawing.Point(0, 0);
            this.DegreeFor.Name = "DegreeFor";
            this.DegreeFor.ServerReport.BearerToken = null;
            this.DegreeFor.Size = new System.Drawing.Size(800, 450);
            this.DegreeFor.TabIndex = 0;
            // 
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DegreeFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DegreeForm";
            this.Text = "DegreeForm";
            this.Load += new System.EventHandler(this.DegreeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DegreeFor;
    }
}