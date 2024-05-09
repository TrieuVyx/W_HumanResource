namespace HumanResource.src.View.Role
{
    partial class ListRole
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
            this.ViewRoleData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtIdAmount = new System.Windows.Forms.RichTextBox();
            this.ViewDataEmployee = new System.Windows.Forms.DataGridView();
            this.txtIdEmployee = new System.Windows.Forms.RichTextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnWatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdRole = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRoleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewRoleData
            // 
            this.ViewRoleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewRoleData.Location = new System.Drawing.Point(34, 144);
            this.ViewRoleData.Margin = new System.Windows.Forms.Padding(4);
            this.ViewRoleData.Name = "ViewRoleData";
            this.ViewRoleData.RowHeadersWidth = 51;
            this.ViewRoleData.Size = new System.Drawing.Size(437, 305);
            this.ViewRoleData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(34, 110);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 28);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Create";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(142, 109);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(79, 28);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(229, 110);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 28);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtIdAmount
            // 
            this.txtIdAmount.Location = new System.Drawing.Point(479, 110);
            this.txtIdAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdAmount.Name = "txtIdAmount";
            this.txtIdAmount.Size = new System.Drawing.Size(37, 27);
            this.txtIdAmount.TabIndex = 6;
            this.txtIdAmount.Text = "";
            // 
            // ViewDataEmployee
            // 
            this.ViewDataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataEmployee.Location = new System.Drawing.Point(479, 144);
            this.ViewDataEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.ViewDataEmployee.Name = "ViewDataEmployee";
            this.ViewDataEmployee.RowHeadersWidth = 51;
            this.ViewDataEmployee.Size = new System.Drawing.Size(441, 305);
            this.ViewDataEmployee.TabIndex = 7;
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Location = new System.Drawing.Point(524, 110);
            this.txtIdEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(73, 27);
            this.txtIdEmployee.TabIndex = 8;
            this.txtIdEmployee.Text = "";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(319, 110);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(79, 28);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnWatch
            // 
            this.BtnWatch.Location = new System.Drawing.Point(712, 106);
            this.BtnWatch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWatch.Name = "BtnWatch";
            this.BtnWatch.Size = new System.Drawing.Size(100, 28);
            this.BtnWatch.TabIndex = 10;
            this.BtnWatch.Text = "Watch";
            this.BtnWatch.UseVisualStyleBackColor = true;
            this.BtnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtIdRole
            // 
            this.txtIdRole.Location = new System.Drawing.Point(434, 110);
            this.txtIdRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRole.Name = "txtIdRole";
            this.txtIdRole.Size = new System.Drawing.Size(37, 27);
            this.txtIdRole.TabIndex = 12;
            this.txtIdRole.Text = "";
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 476);
            this.Controls.Add(this.txtIdRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnWatch);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.txtIdEmployee);
            this.Controls.Add(this.ViewDataEmployee);
            this.Controls.Add(this.txtIdAmount);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewRoleData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListRole";
            this.Text = "ListRole";
            ((System.ComponentModel.ISupportInitialize)(this.ViewRoleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewRoleData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.RichTextBox txtIdAmount;
        private System.Windows.Forms.DataGridView ViewDataEmployee;
        private System.Windows.Forms.RichTextBox txtIdEmployee;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnWatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtIdRole;
    }
}