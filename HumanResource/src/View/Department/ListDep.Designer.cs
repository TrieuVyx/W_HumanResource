namespace HumanResource.src.View.Department
{
    partial class ListDep
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtComboDep = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.RichTextBox();
            this.btnMoveHouse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmout = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.GridViewDepartment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchDepart = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtComboDep);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDepartmentName);
            this.panel3.Controls.Add(this.btnMoveHouse);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnUpdateDepartment);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtAmout);
            this.panel3.Controls.Add(this.btnSearchDepart);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.GridViewDepartment);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 567);
            this.panel3.TabIndex = 5;
            // 
            // txtComboDep
            // 
            this.txtComboDep.FormattingEnabled = true;
            this.txtComboDep.Location = new System.Drawing.Point(214, 460);
            this.txtComboDep.Name = "txtComboDep";
            this.txtComboDep.Size = new System.Drawing.Size(310, 24);
            this.txtComboDep.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(214, 497);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 39);
            this.txtID.TabIndex = 28;
            this.txtID.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Department Name";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(214, 407);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(310, 39);
            this.txtDepartmentName.TabIndex = 24;
            this.txtDepartmentName.Text = "";
            // 
            // btnMoveHouse
            // 
            this.btnMoveHouse.Location = new System.Drawing.Point(419, 497);
            this.btnMoveHouse.Name = "btnMoveHouse";
            this.btnMoveHouse.Size = new System.Drawing.Size(105, 39);
            this.btnMoveHouse.TabIndex = 23;
            this.btnMoveHouse.Text = "Move";
            this.btnMoveHouse.UseVisualStyleBackColor = true;
            this.btnMoveHouse.Click += new System.EventHandler(this.btnMoveHouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Current Department";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 82);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 32);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(608, 82);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(101, 32);
            this.btnUpdateDepartment.TabIndex = 18;
            this.btnUpdateDepartment.Text = "Update";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Amount";
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(801, 82);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(50, 32);
            this.txtAmout.TabIndex = 16;
            this.txtAmout.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(81, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(410, 33);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "";
            // 
            // GridViewDepartment
            // 
            this.GridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDepartment.Location = new System.Drawing.Point(30, 120);
            this.GridViewDepartment.Name = "GridViewDepartment";
            this.GridViewDepartment.RowHeadersWidth = 51;
            this.GridViewDepartment.RowTemplate.Height = 24;
            this.GridViewDepartment.Size = new System.Drawing.Size(821, 281);
            this.GridViewDepartment.TabIndex = 2;
            this.GridViewDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDepartment_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Department";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HumanResource.Properties.Resources.Image1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(530, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 160);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackgroundImage = global::HumanResource.Properties.Resources.search;
            this.btnSearchDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepart.Location = new System.Drawing.Point(30, 82);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(45, 32);
            this.btnSearchDepart.TabIndex = 4;
            this.btnSearchDepart.UseVisualStyleBackColor = true;
            this.btnSearchDepart.Click += new System.EventHandler(this.btnSearchDepart_Click);
            // 
            // ListDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 593);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListDep";
            this.Text = "List Department";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchDepart;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.DataGridView GridViewDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtAmout;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDepartmentName;
        private System.Windows.Forms.Button btnMoveHouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtComboDep;
    }
}