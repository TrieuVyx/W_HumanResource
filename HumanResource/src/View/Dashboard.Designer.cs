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
            this.BtnWork = new System.Windows.Forms.Button();
            this.BtnPosiition = new System.Windows.Forms.Button();
            this.BtnRotation = new System.Windows.Forms.Button();
            this.dataShowHistoryWork = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataViewRotation = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRenderEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowHistoryWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHistoryEmployee
            // 
            this.dataHistoryEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoryEmployee.Location = new System.Drawing.Point(16, 49);
            this.dataHistoryEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHistoryEmployee.Name = "dataHistoryEmployee";
            this.dataHistoryEmployee.RowHeadersWidth = 51;
            this.dataHistoryEmployee.RowTemplate.Height = 24;
            this.dataHistoryEmployee.Size = new System.Drawing.Size(435, 214);
            this.dataHistoryEmployee.TabIndex = 0;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(328, 6);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(119, 43);
            this.btnWatch.TabIndex = 1;
            this.btnWatch.Text = "Render";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 539);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 43);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(640, 6);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 43);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackgroundImage = global::HumanResource.Properties.Resources.search;
            this.btnSearchDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepart.Location = new System.Drawing.Point(26, 11);
            this.btnSearchDepart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(45, 32);
            this.btnSearchDepart.TabIndex = 6;
            this.btnSearchDepart.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(77, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 34);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(12, 38);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(150, 22);
            this.a.TabIndex = 7;
            this.a.Text = "Employee History";
            // 
            // dataRenderEmployee
            // 
            this.dataRenderEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRenderEmployee.Location = new System.Drawing.Point(452, 49);
            this.dataRenderEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRenderEmployee.Name = "dataRenderEmployee";
            this.dataRenderEmployee.RowHeadersWidth = 51;
            this.dataRenderEmployee.RowTemplate.Height = 24;
            this.dataRenderEmployee.Size = new System.Drawing.Size(427, 214);
            this.dataRenderEmployee.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(453, 6);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 43);
            this.txtId.TabIndex = 9;
            this.txtId.Text = "";
            // 
            // btnWatchEmployee
            // 
            this.btnWatchEmployee.Location = new System.Drawing.Point(515, 6);
            this.btnWatchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWatchEmployee.Name = "btnWatchEmployee";
            this.btnWatchEmployee.Size = new System.Drawing.Size(119, 43);
            this.btnWatchEmployee.TabIndex = 10;
            this.btnWatchEmployee.Text = "Watch";
            this.btnWatchEmployee.UseVisualStyleBackColor = true;
            this.btnWatchEmployee.Click += new System.EventHandler(this.BtnWatchEmployee_Click);
            // 
            // BtnWork
            // 
            this.BtnWork.Location = new System.Drawing.Point(433, 539);
            this.BtnWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(119, 43);
            this.BtnWork.TabIndex = 11;
            this.BtnWork.Text = "Working History";
            this.BtnWork.UseVisualStyleBackColor = true;
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // BtnPosiition
            // 
            this.BtnPosiition.Location = new System.Drawing.Point(558, 539);
            this.BtnPosiition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPosiition.Name = "BtnPosiition";
            this.BtnPosiition.Size = new System.Drawing.Size(155, 43);
            this.BtnPosiition.TabIndex = 12;
            this.BtnPosiition.Text = "Personal Information";
            this.BtnPosiition.UseVisualStyleBackColor = true;
            this.BtnPosiition.Click += new System.EventHandler(this.BtnPosiition_Click);
            // 
            // BtnRotation
            // 
            this.BtnRotation.Location = new System.Drawing.Point(719, 539);
            this.BtnRotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRotation.Name = "BtnRotation";
            this.BtnRotation.Size = new System.Drawing.Size(160, 43);
            this.BtnRotation.TabIndex = 13;
            this.BtnRotation.Text = "Staff Rotation History";
            this.BtnRotation.UseVisualStyleBackColor = true;
            this.BtnRotation.Click += new System.EventHandler(this.BtnRotation_Click);
            // 
            // dataShowHistoryWork
            // 
            this.dataShowHistoryWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataShowHistoryWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowHistoryWork.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataShowHistoryWork.Location = new System.Drawing.Point(12, 287);
            this.dataShowHistoryWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataShowHistoryWork.Name = "dataShowHistoryWork";
            this.dataShowHistoryWork.RowHeadersWidth = 51;
            this.dataShowHistoryWork.RowTemplate.Height = 24;
            this.dataShowHistoryWork.Size = new System.Drawing.Size(435, 248);
            this.dataShowHistoryWork.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Work History";
            // 
            // dataViewRotation
            // 
            this.dataViewRotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewRotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRotation.Location = new System.Drawing.Point(453, 287);
            this.dataViewRotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataViewRotation.Name = "dataViewRotation";
            this.dataViewRotation.RowHeadersWidth = 51;
            this.dataViewRotation.RowTemplate.Height = 24;
            this.dataViewRotation.Size = new System.Drawing.Size(426, 248);
            this.dataViewRotation.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Staff Rotation History";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataViewRotation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataShowHistoryWork);
            this.Controls.Add(this.BtnRotation);
            this.Controls.Add(this.BtnPosiition);
            this.Controls.Add(this.BtnWork);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRenderEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowHistoryWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRotation)).EndInit();
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
        private System.Windows.Forms.Button BtnWork;
        private System.Windows.Forms.Button BtnPosiition;
        private System.Windows.Forms.Button BtnRotation;
        private System.Windows.Forms.DataGridView dataShowHistoryWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataViewRotation;
        private System.Windows.Forms.Label label4;
    }
}