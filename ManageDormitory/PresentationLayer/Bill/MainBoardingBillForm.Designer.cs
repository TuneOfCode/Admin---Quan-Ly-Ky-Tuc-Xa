namespace ManageDormitory.PresentationLayer.Bill {
    partial class MainBoardingBillForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoardingBillForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BoardingBillDGV = new System.Windows.Forms.DataGridView();
            this.cbbField = new System.Windows.Forms.ComboBox();
            this.CBBoardingBill = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingBillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingBillDateFounded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingBillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardingBillNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardingBillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(228, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(376, 37);
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "Quản lý hoá đơn nội trú";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(547, 136);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 35);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // BoardingBillDGV
            // 
            this.BoardingBillDGV.AllowUserToAddRows = false;
            this.BoardingBillDGV.AllowUserToDeleteRows = false;
            this.BoardingBillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoardingBillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBBoardingBill,
            this.STT,
            this.BoardingBillID,
            this.BoardingBillName,
            this.BoardingBillDateFounded,
            this.RoomType,
            this.StudentID,
            this.StudentName,
            this.BoardingBillStatus,
            this.BoardingBillNote});
            this.BoardingBillDGV.Location = new System.Drawing.Point(12, 185);
            this.BoardingBillDGV.Name = "BoardingBillDGV";
            this.BoardingBillDGV.ReadOnly = true;
            this.BoardingBillDGV.Size = new System.Drawing.Size(776, 255);
            this.BoardingBillDGV.TabIndex = 21;
            this.BoardingBillDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BoardingBillDGV_CellClick);
            this.BoardingBillDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BoardingBillDGV_CellValueChanged);
            this.BoardingBillDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoardingBillDGV_MouseClick);
            // 
            // cbbField
            // 
            this.cbbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbField.FormattingEnabled = true;
            this.cbbField.Location = new System.Drawing.Point(420, 142);
            this.cbbField.Name = "cbbField";
            this.cbbField.Size = new System.Drawing.Size(121, 24);
            this.cbbField.TabIndex = 19;
            this.cbbField.SelectedIndexChanged += new System.EventHandler(this.cbbField_SelectedIndexChanged);
            // 
            // CBBoardingBill
            // 
            this.CBBoardingBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CBBoardingBill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBBoardingBill.HeaderText = "Chọn";
            this.CBBoardingBill.Name = "CBBoardingBill";
            this.CBBoardingBill.ReadOnly = true;
            this.CBBoardingBill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBBoardingBill.ThreeState = true;
            this.CBBoardingBill.Width = 38;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // BoardingBillID
            // 
            this.BoardingBillID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BoardingBillID.HeaderText = "Mã hoá đơn";
            this.BoardingBillID.Name = "BoardingBillID";
            this.BoardingBillID.ReadOnly = true;
            this.BoardingBillID.Visible = false;
            this.BoardingBillID.Width = 90;
            // 
            // BoardingBillName
            // 
            this.BoardingBillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BoardingBillName.HeaderText = "Tên hoá đơn";
            this.BoardingBillName.Name = "BoardingBillName";
            this.BoardingBillName.ReadOnly = true;
            this.BoardingBillName.Width = 87;
            // 
            // BoardingBillDateFounded
            // 
            this.BoardingBillDateFounded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BoardingBillDateFounded.HeaderText = "Ngày lập";
            this.BoardingBillDateFounded.Name = "BoardingBillDateFounded";
            this.BoardingBillDateFounded.ReadOnly = true;
            this.BoardingBillDateFounded.Width = 69;
            // 
            // RoomType
            // 
            this.RoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoomType.HeaderText = "Tổng số tiền trả";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Width = 87;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StudentID.HeaderText = "Mã sinh viên";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 85;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StudentName.HeaderText = "Họ và tên sinh viên";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 96;
            // 
            // BoardingBillStatus
            // 
            this.BoardingBillStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BoardingBillStatus.HeaderText = "Tình trạng";
            this.BoardingBillStatus.Name = "BoardingBillStatus";
            this.BoardingBillStatus.ReadOnly = true;
            this.BoardingBillStatus.Width = 74;
            // 
            // BoardingBillNote
            // 
            this.BoardingBillNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BoardingBillNote.HeaderText = "Ghi chú";
            this.BoardingBillNote.Name = "BoardingBillNote";
            this.BoardingBillNote.ReadOnly = true;
            this.BoardingBillNote.Width = 64;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(12, 136);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(167, 35);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Xác nhận thanh toán ";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // MainBoardingBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BoardingBillDGV);
            this.Controls.Add(this.cbbField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainBoardingBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hoá đơn nội trú";
            this.Load += new System.EventHandler(this.MainBoardingBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoardingBillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView BoardingBillDGV;
        private System.Windows.Forms.ComboBox cbbField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBBoardingBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardingBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardingBillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardingBillDateFounded;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardingBillStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardingBillNote;
        private System.Windows.Forms.Button btnAccept;
    }
}