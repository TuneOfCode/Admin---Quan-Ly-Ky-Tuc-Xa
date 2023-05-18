namespace ManageDormitory.PresentationLayer.Room {
    partial class MainRoomForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRoomForm));
            this.cbbField = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.RoomDGV = new System.Windows.Forms.DataGridView();
            this.CBRoom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomMaxQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbField
            // 
            this.cbbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbField.FormattingEnabled = true;
            this.cbbField.Location = new System.Drawing.Point(420, 142);
            this.cbbField.Name = "cbbField";
            this.cbbField.Size = new System.Drawing.Size(121, 24);
            this.cbbField.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(547, 136);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 35);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(190, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá bỏ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(101, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(12, 135);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 35);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // RoomDGV
            // 
            this.RoomDGV.AllowUserToAddRows = false;
            this.RoomDGV.AllowUserToDeleteRows = false;
            this.RoomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBRoom,
            this.STT,
            this.RoomID,
            this.RoomArea,
            this.RoomRange,
            this.RoomType,
            this.RoomQuantity,
            this.RoomMaxQuantity,
            this.RoomPrice,
            this.RoomStatus});
            this.RoomDGV.Location = new System.Drawing.Point(12, 185);
            this.RoomDGV.Name = "RoomDGV";
            this.RoomDGV.ReadOnly = true;
            this.RoomDGV.Size = new System.Drawing.Size(776, 255);
            this.RoomDGV.TabIndex = 14;
            this.RoomDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDGV_CellClick);
            this.RoomDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDGV_CellValueChanged);
            this.RoomDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RoomDGV_MouseClick);
            // 
            // CBRoom
            // 
            this.CBRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CBRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBRoom.HeaderText = "Chọn";
            this.CBRoom.Name = "CBRoom";
            this.CBRoom.ReadOnly = true;
            this.CBRoom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBRoom.ThreeState = true;
            this.CBRoom.Width = 38;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomID.HeaderText = "Phòng";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Width = 63;
            // 
            // RoomArea
            // 
            this.RoomArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomArea.HeaderText = "Khu vực";
            this.RoomArea.Name = "RoomArea";
            this.RoomArea.ReadOnly = true;
            this.RoomArea.Width = 51;
            // 
            // RoomRange
            // 
            this.RoomRange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomRange.HeaderText = "Dãy phòng";
            this.RoomRange.Name = "RoomRange";
            this.RoomRange.ReadOnly = true;
            this.RoomRange.Width = 78;
            // 
            // RoomType
            // 
            this.RoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomType.HeaderText = "Loại phòng";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Width = 79;
            // 
            // RoomQuantity
            // 
            this.RoomQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomQuantity.HeaderText = "Số lượng hiện tại";
            this.RoomQuantity.Name = "RoomQuantity";
            this.RoomQuantity.ReadOnly = true;
            // 
            // RoomMaxQuantity
            // 
            this.RoomMaxQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomMaxQuantity.HeaderText = "Số lượng tối đa";
            this.RoomMaxQuantity.Name = "RoomMaxQuantity";
            this.RoomMaxQuantity.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomPrice.HeaderText = "Tiền phòng";
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            this.RoomPrice.Width = 79;
            // 
            // RoomStatus
            // 
            this.RoomStatus.HeaderText = "Tình trạng";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.ReadOnly = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(258, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(268, 37);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Quản lý phòng ở";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbField);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.RoomDGV);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "MainRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ở";
            this.Load += new System.EventHandler(this.MainRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbField;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView RoomDGV;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomMaxQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
    }
}