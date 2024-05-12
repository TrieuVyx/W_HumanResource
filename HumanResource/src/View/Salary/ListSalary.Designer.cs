namespace HumanResource.src.View.Salary
{
    partial class ListSalary
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
            this.DataSalary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnWatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.TxTId = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSalary
            // 
            this.DataSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSalary.Location = new System.Drawing.Point(16, 49);
            this.DataSalary.Margin = new System.Windows.Forms.Padding(4);
            this.DataSalary.Name = "DataSalary";
            this.DataSalary.RowHeadersWidth = 51;
            this.DataSalary.Size = new System.Drawing.Size(867, 196);
            this.DataSalary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary";
            // 
            // BtnWatch
            // 
            this.BtnWatch.Location = new System.Drawing.Point(568, 469);
            this.BtnWatch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWatch.Name = "BtnWatch";
            this.BtnWatch.Size = new System.Drawing.Size(100, 28);
            this.BtnWatch.TabIndex = 2;
            this.BtnWatch.Text = "Watch";
            this.BtnWatch.UseVisualStyleBackColor = true;
            this.BtnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(16, 263);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowHeadersWidth = 51;
            this.EmployeeList.Size = new System.Drawing.Size(867, 184);
            this.EmployeeList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(676, 469);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(100, 28);
            this.BtnShow.TabIndex = 6;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // TxTId
            // 
            this.TxTId.Location = new System.Drawing.Point(842, 28);
            this.TxTId.Name = "TxTId";
            this.TxTId.Size = new System.Drawing.Size(42, 31);
            this.TxTId.TabIndex = 7;
            this.TxTId.Text = "";
            // 
            // ListSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 541);
            this.Controls.Add(this.TxTId);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnWatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListSalary";
            this.Text = "ListSalary";
            ((System.ComponentModel.ISupportInitialize)(this.DataSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnWatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.RichTextBox TxTId;
    }
}