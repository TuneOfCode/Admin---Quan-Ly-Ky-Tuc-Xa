namespace ManageDormitory.PresentationLayer.Student {
    partial class MainStudentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStudentForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbField = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.CBStudent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentDateIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPlaceIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentContractSigningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(258, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(278, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quản lý sinh viên";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentDGV
            // 
            this.StudentDGV.AllowUserToAddRows = false;
            this.StudentDGV.AllowUserToDeleteRows = false;
            this.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBStudent,
            this.STT,
            this.StudentID,
            this.StudentName,
            this.StudentGender,
            this.StudentBirthdate,
            this.StudentAddress,
            this.StudentCMND,
            this.StudentDateIssue,
            this.StudentPlaceIssue,
            this.StudentSchool,
            this.StudentIndustry,
            this.StudentCourse,
            this.StudentPhone,
            this.StudentEmail,
            this.StudentRoomID,
            this.StudentContractSigningDate});
            this.StudentDGV.Location = new System.Drawing.Point(12, 183);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.ReadOnly = true;
            this.StudentDGV.Size = new System.Drawing.Size(776, 255);
            this.StudentDGV.TabIndex = 6;
            this.StudentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellClick);
            this.StudentDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellValueChanged);
            this.StudentDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentDataGridView_MouseClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(12, 133);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 35);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(101, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 35);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(190, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoá bỏ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(547, 134);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 35);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(744, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbField
            // 
            this.cbbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbField.FormattingEnabled = true;
            this.cbbField.Location = new System.Drawing.Point(420, 140);
            this.cbbField.Name = "cbbField";
            this.cbbField.Size = new System.Drawing.Size(121, 24);
            this.cbbField.TabIndex = 4;
            this.cbbField.SelectedIndexChanged += new System.EventHandler(this.cbbField_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(279, 133);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(135, 35);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Xuất file excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // CBStudent
            // 
            this.CBStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CBStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBStudent.HeaderText = "Chọn";
            this.CBStudent.Name = "CBStudent";
            this.CBStudent.ReadOnly = true;
            this.CBStudent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBStudent.ThreeState = true;
            this.CBStudent.Width = 38;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Mã sinh viên";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Họ và tên";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 120;
            // 
            // StudentGender
            // 
            this.StudentGender.HeaderText = "Giới tính";
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.ReadOnly = true;
            this.StudentGender.Width = 70;
            // 
            // StudentBirthdate
            // 
            this.StudentBirthdate.HeaderText = "Ngày sinh";
            this.StudentBirthdate.Name = "StudentBirthdate";
            this.StudentBirthdate.ReadOnly = true;
            this.StudentBirthdate.Width = 110;
            // 
            // StudentAddress
            // 
            this.StudentAddress.HeaderText = "Địa chỉ thường trú";
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.ReadOnly = true;
            this.StudentAddress.Visible = false;
            // 
            // StudentCMND
            // 
            this.StudentCMND.HeaderText = "CMND/CCCD";
            this.StudentCMND.Name = "StudentCMND";
            this.StudentCMND.ReadOnly = true;
            this.StudentCMND.Visible = false;
            // 
            // StudentDateIssue
            // 
            this.StudentDateIssue.HeaderText = "Ngày cấp";
            this.StudentDateIssue.Name = "StudentDateIssue";
            this.StudentDateIssue.ReadOnly = true;
            this.StudentDateIssue.Visible = false;
            // 
            // StudentPlaceIssue
            // 
            this.StudentPlaceIssue.HeaderText = "Nơi cấp";
            this.StudentPlaceIssue.Name = "StudentPlaceIssue";
            this.StudentPlaceIssue.ReadOnly = true;
            this.StudentPlaceIssue.Visible = false;
            // 
            // StudentSchool
            // 
            this.StudentSchool.HeaderText = "Trường đại học";
            this.StudentSchool.Name = "StudentSchool";
            this.StudentSchool.ReadOnly = true;
            this.StudentSchool.Width = 140;
            // 
            // StudentIndustry
            // 
            this.StudentIndustry.HeaderText = "Ngành học";
            this.StudentIndustry.Name = "StudentIndustry";
            this.StudentIndustry.ReadOnly = true;
            this.StudentIndustry.Visible = false;
            // 
            // StudentCourse
            // 
            this.StudentCourse.HeaderText = "Khoá học";
            this.StudentCourse.Name = "StudentCourse";
            this.StudentCourse.ReadOnly = true;
            this.StudentCourse.Visible = false;
            // 
            // StudentPhone
            // 
            this.StudentPhone.HeaderText = "Số điện thoại";
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.ReadOnly = true;
            this.StudentPhone.Visible = false;
            // 
            // StudentEmail
            // 
            this.StudentEmail.HeaderText = "Email";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            this.StudentEmail.Visible = false;
            // 
            // StudentRoomID
            // 
            this.StudentRoomID.HeaderText = "Phòng đang ở";
            this.StudentRoomID.Name = "StudentRoomID";
            this.StudentRoomID.ReadOnly = true;
            // 
            // StudentContractSigningDate
            // 
            this.StudentContractSigningDate.HeaderText = "Ngày ký hợp đồng";
            this.StudentContractSigningDate.Name = "StudentContractSigningDate";
            this.StudentContractSigningDate.ReadOnly = true;
            this.StudentContractSigningDate.Width = 120;
            // 
            // MainStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbField);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.StudentDGV);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.MainStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbField;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentDateIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPlaceIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentContractSigningDate;
    }
}