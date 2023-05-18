namespace ManageDormitory.PresentationLayer.Bill {
    partial class MainElectricityWaterBillForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainElectricityWaterBillForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ElectricityWaterBillDGV = new System.Windows.Forms.DataGridView();
            this.CBBoardingBill = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillDateFounded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillTotalElec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillTotalWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterTotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElecWaterBillNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbbField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricityWaterBillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(177, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(493, 37);
            this.lbTitle.TabIndex = 24;
            this.lbTitle.Text = "Quản lý hoá đơn tiền điện nước";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(547, 137);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 35);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ElectricityWaterBillDGV
            // 
            this.ElectricityWaterBillDGV.AllowUserToAddRows = false;
            this.ElectricityWaterBillDGV.AllowUserToDeleteRows = false;
            this.ElectricityWaterBillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElectricityWaterBillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBBoardingBill,
            this.STT,
            this.ElecWaterBillID,
            this.ElecWaterBillName,
            this.ElecWaterBillDateFounded,
            this.ElecWaterBillTotalElec,
            this.ElecWaterBillTotalWater,
            this.ElecWaterTotalPayment,
            this.RoomID,
            this.ElecWaterBillStatus,
            this.ElecWaterBillNote});
            this.ElectricityWaterBillDGV.Location = new System.Drawing.Point(12, 186);
            this.ElectricityWaterBillDGV.Name = "ElectricityWaterBillDGV";
            this.ElectricityWaterBillDGV.ReadOnly = true;
            this.ElectricityWaterBillDGV.Size = new System.Drawing.Size(776, 255);
            this.ElectricityWaterBillDGV.TabIndex = 27;
            this.ElectricityWaterBillDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElectricityWaterBillDGV_CellClick);
            this.ElectricityWaterBillDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElectricityWaterBillDGV_CellValueChanged);
            this.ElectricityWaterBillDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ElectricityWaterBillDGV_MouseClick);
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
            // ElecWaterBillID
            // 
            this.ElecWaterBillID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ElecWaterBillID.HeaderText = "Mã hoá đơn";
            this.ElecWaterBillID.Name = "ElecWaterBillID";
            this.ElecWaterBillID.ReadOnly = true;
            this.ElecWaterBillID.Visible = false;
            // 
            // ElecWaterBillName
            // 
            this.ElecWaterBillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterBillName.HeaderText = "Tên hoá đơn";
            this.ElecWaterBillName.Name = "ElecWaterBillName";
            this.ElecWaterBillName.ReadOnly = true;
            this.ElecWaterBillName.Width = 87;
            // 
            // ElecWaterBillDateFounded
            // 
            this.ElecWaterBillDateFounded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterBillDateFounded.HeaderText = "Ngày lập";
            this.ElecWaterBillDateFounded.Name = "ElecWaterBillDateFounded";
            this.ElecWaterBillDateFounded.ReadOnly = true;
            this.ElecWaterBillDateFounded.Width = 69;
            // 
            // ElecWaterBillTotalElec
            // 
            this.ElecWaterBillTotalElec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterBillTotalElec.HeaderText = "Tổng tiền điện";
            this.ElecWaterBillTotalElec.Name = "ElecWaterBillTotalElec";
            this.ElecWaterBillTotalElec.ReadOnly = true;
            this.ElecWaterBillTotalElec.Width = 74;
            // 
            // ElecWaterBillTotalWater
            // 
            this.ElecWaterBillTotalWater.HeaderText = "Tổng tiền nước";
            this.ElecWaterBillTotalWater.Name = "ElecWaterBillTotalWater";
            this.ElecWaterBillTotalWater.ReadOnly = true;
            // 
            // ElecWaterTotalPayment
            // 
            this.ElecWaterTotalPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterTotalPayment.HeaderText = "Tổng tiền";
            this.ElecWaterTotalPayment.Name = "ElecWaterTotalPayment";
            this.ElecWaterTotalPayment.ReadOnly = true;
            this.ElecWaterTotalPayment.Width = 71;
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoomID.HeaderText = "Số phòng";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Width = 72;
            // 
            // ElecWaterBillStatus
            // 
            this.ElecWaterBillStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterBillStatus.HeaderText = "Tình trạng";
            this.ElecWaterBillStatus.Name = "ElecWaterBillStatus";
            this.ElecWaterBillStatus.ReadOnly = true;
            this.ElecWaterBillStatus.Width = 74;
            // 
            // ElecWaterBillNote
            // 
            this.ElecWaterBillNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElecWaterBillNote.HeaderText = "Ghi chú";
            this.ElecWaterBillNote.Name = "ElecWaterBillNote";
            this.ElecWaterBillNote.ReadOnly = true;
            this.ElecWaterBillNote.Width = 64;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(12, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(167, 35);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "Xác nhận thanh toán ";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbbField
            // 
            this.cbbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbField.FormattingEnabled = true;
            this.cbbField.Location = new System.Drawing.Point(420, 143);
            this.cbbField.Name = "cbbField";
            this.cbbField.Size = new System.Drawing.Size(121, 24);
            this.cbbField.TabIndex = 25;
            this.cbbField.SelectedIndexChanged += new System.EventHandler(this.cbbField_SelectedIndexChanged);
            // 
            // MainElectricityWaterBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ElectricityWaterBillDGV);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbbField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainElectricityWaterBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainElectricityWaterBillForm";
            this.Load += new System.EventHandler(this.MainElectricityWaterBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElectricityWaterBillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView ElectricityWaterBillDGV;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbbField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBBoardingBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillDateFounded;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillTotalElec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillTotalWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterTotalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElecWaterBillNote;
    }
}