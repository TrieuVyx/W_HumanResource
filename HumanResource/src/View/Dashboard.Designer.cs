namespace HumanResource.src.View
{
    partial class Dashboard
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
            this.dataHistoryEmployee = new System.Windows.Forms.DataGridView();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearchDepart = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.a = new System.Windows.Forms.Label();
            this.dataRenderEmployee = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.RichTextBox();
            this.btnWatchEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRenderEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHistoryEmployee
            // 
            this.dataHistoryEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoryEmployee.Location = new System.Drawing.Point(9, 87);
            this.dataHistoryEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataHistoryEmployee.Name = "dataHistoryEmployee";
            this.dataHistoryEmployee.RowHeadersWidth = 51;
            this.dataHistoryEmployee.RowTemplate.Height = 24;
            this.dataHistoryEmployee.Size = new System.Drawing.Size(326, 301);
            this.dataHistoryEmployee.TabIndex = 0;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(245, 47);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(89, 35);
            this.btnWatch.TabIndex = 1;
            this.btnWatch.Text = "Render";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 47);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(570, 47);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackgroundImage = global::HumanResource.Properties.Resources.search;
            this.btnSearchDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepart.Location = new System.Drawing.Point(9, 51);
            this.btnSearchDepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(34, 26);
            this.btnSearchDepart.TabIndex = 6;
            this.btnSearchDepart.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(47, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 28);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(10, 15);
            this.a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(125, 18);
            this.a.TabIndex = 7;
            this.a.Text = "Employee History";
            // 
            // dataRenderEmployee
            // 
            this.dataRenderEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRenderEmployee.Location = new System.Drawing.Point(339, 87);
            this.dataRenderEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRenderEmployee.Name = "dataRenderEmployee";
            this.dataRenderEmployee.RowHeadersWidth = 51;
            this.dataRenderEmployee.RowTemplate.Height = 24;
            this.dataRenderEmployee.Size = new System.Drawing.Size(320, 301);
            this.dataRenderEmployee.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(339, 47);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 36);
            this.txtId.TabIndex = 9;
            this.txtId.Text = "";
            // 
            // btnWatchEmployee
            // 
            this.btnWatchEmployee.Location = new System.Drawing.Point(386, 47);
            this.btnWatchEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatchEmployee.Name = "btnWatchEmployee";
            this.btnWatchEmployee.Size = new System.Drawing.Size(89, 35);
            this.btnWatchEmployee.TabIndex = 10;
            this.btnWatchEmployee.Text = "Watch";
            this.btnWatchEmployee.UseVisualStyleBackColor = true;
            this.btnWatchEmployee.Click += new System.EventHandler(this.BtnWatchEmployee_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 398);
            this.Controls.Add(this.btnWatchEmployee);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataRenderEmployee);
            this.Controls.Add(this.a);
            this.Controls.Add(this.btnSearchDepart);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.dataHistoryEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRenderEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHistoryEmployee;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearchDepart;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridView dataRenderEmployee;
        private System.Windows.Forms.RichTextBox txtId;
        private System.Windows.Forms.Button btnWatchEmployee;
    }
}