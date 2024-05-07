namespace HumanResource.src.View.Department
{
    partial class AddEmployeeCome
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
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDepartMent = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btbReset = new System.Windows.Forms.Button();
            this.txtDepartmentId = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeId = new System.Windows.Forms.RichTextBox();
            this.dataEmployeeDepart = new System.Windows.Forms.DataGridView();
            this.btnWatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmout = new System.Windows.Forms.RichTextBox();
            this.txtListEmployInDepartment = new System.Windows.Forms.RichTextBox();
            this.txtAmoutEmploy = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartMent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeDepart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Location = new System.Drawing.Point(27, 64);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.RowHeadersWidth = 51;
            this.dataGridEmployee.RowTemplate.Height = 24;
            this.dataGridEmployee.Size = new System.Drawing.Size(386, 227);
            this.dataGridEmployee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "EmployeeList";
            // 
            // dataGridDepartMent
            // 
            this.dataGridDepartMent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepartMent.Location = new System.Drawing.Point(509, 64);
            this.dataGridDepartMent.Name = "dataGridDepartMent";
            this.dataGridDepartMent.RowHeadersWidth = 51;
            this.dataGridDepartMent.RowTemplate.Height = 24;
            this.dataGridDepartMent.Size = new System.Drawing.Size(376, 227);
            this.dataGridDepartMent.TabIndex = 3;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(419, 64);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(84, 43);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // btbReset
            // 
            this.btbReset.Location = new System.Drawing.Point(419, 150);
            this.btbReset.Name = "btbReset";
            this.btbReset.Size = new System.Drawing.Size(84, 55);
            this.btbReset.TabIndex = 6;
            this.btbReset.Text = "Reset";
            this.btbReset.UseVisualStyleBackColor = true;
            this.btbReset.Click += new System.EventHandler(this.BtbReset_Click);
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(419, 211);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(84, 31);
            this.txtDepartmentId.TabIndex = 7;
            this.txtDepartmentId.Text = "";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(419, 113);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(84, 31);
            this.txtEmployeeId.TabIndex = 8;
            this.txtEmployeeId.Text = "";
            // 
            // dataEmployeeDepart
            // 
            this.dataEmployeeDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeeDepart.Location = new System.Drawing.Point(27, 300);
            this.dataEmployeeDepart.Name = "dataEmployeeDepart";
            this.dataEmployeeDepart.RowHeadersWidth = 51;
            this.dataEmployeeDepart.RowTemplate.Height = 24;
            this.dataEmployeeDepart.Size = new System.Drawing.Size(858, 227);
            this.dataEmployeeDepart.TabIndex = 9;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(419, 248);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(84, 43);
            this.btnWatch.TabIndex = 10;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "DepartmentList";
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(298, 27);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(115, 31);
            this.txtAmout.TabIndex = 12;
            this.txtAmout.Text = "";
            // 
            // txtListEmployInDepartment
            // 
            this.txtListEmployInDepartment.Location = new System.Drawing.Point(509, 27);
            this.txtListEmployInDepartment.Name = "txtListEmployInDepartment";
            this.txtListEmployInDepartment.Size = new System.Drawing.Size(163, 31);
            this.txtListEmployInDepartment.TabIndex = 13;
            this.txtListEmployInDepartment.Text = "";
            // 
            // txtAmoutEmploy
            // 
            this.txtAmoutEmploy.Location = new System.Drawing.Point(213, 27);
            this.txtAmoutEmploy.Name = "txtAmoutEmploy";
            this.txtAmoutEmploy.Size = new System.Drawing.Size(79, 31);
            this.txtAmoutEmploy.TabIndex = 14;
            this.txtAmoutEmploy.Text = "";
            // 
            // AddEmployeeCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 546);
            this.Controls.Add(this.txtAmoutEmploy);
            this.Controls.Add(this.txtListEmployInDepartment);
            this.Controls.Add(this.txtAmout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.dataEmployeeDepart);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.btbReset);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.dataGridDepartMent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeCome";
            this.Text = "AddEmployeeCome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartMent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeDepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDepartMent;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btbReset;
        private System.Windows.Forms.RichTextBox txtDepartmentId;
        private System.Windows.Forms.RichTextBox txtEmployeeId;
        private System.Windows.Forms.DataGridView dataEmployeeDepart;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtAmout;
        private System.Windows.Forms.RichTextBox txtListEmployInDepartment;
        private System.Windows.Forms.RichTextBox txtAmoutEmploy;
    }
}