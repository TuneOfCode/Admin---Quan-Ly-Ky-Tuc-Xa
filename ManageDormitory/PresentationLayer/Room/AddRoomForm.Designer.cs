namespace ManageDormitory.PresentationLayer.Room {
    partial class AddRoomForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoomForm));
            this.gbRoomInfor = new System.Windows.Forms.GroupBox();
            this.cbbRoomArea = new System.Windows.Forms.ComboBox();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.cbbRoomRange = new System.Windows.Forms.ComboBox();
            this.lbRoomPrice = new System.Windows.Forms.Label();
            this.lbRoomRange = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbRoomArea = new System.Windows.Forms.Label();
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.lbRoomQuantity = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtRoomQuantity = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbRoomStatus = new System.Windows.Forms.ComboBox();
            this.gbRoomInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRoomInfor
            // 
            this.gbRoomInfor.Controls.Add(this.cbbRoomStatus);
            this.gbRoomInfor.Controls.Add(this.cbbRoomArea);
            this.gbRoomInfor.Controls.Add(this.cbbRoomType);
            this.gbRoomInfor.Controls.Add(this.cbbRoomRange);
            this.gbRoomInfor.Controls.Add(this.lbRoomPrice);
            this.gbRoomInfor.Controls.Add(this.lbRoomRange);
            this.gbRoomInfor.Controls.Add(this.lbRoomType);
            this.gbRoomInfor.Controls.Add(this.lbRoomArea);
            this.gbRoomInfor.Controls.Add(this.lbRoomStatus);
            this.gbRoomInfor.Controls.Add(this.lbRoomQuantity);
            this.gbRoomInfor.Controls.Add(this.lbRoomID);
            this.gbRoomInfor.Controls.Add(this.txtRoomPrice);
            this.gbRoomInfor.Controls.Add(this.txtRoomID);
            this.gbRoomInfor.Controls.Add(this.txtRoomQuantity);
            this.gbRoomInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomInfor.Location = new System.Drawing.Point(18, 12);
            this.gbRoomInfor.Name = "gbRoomInfor";
            this.gbRoomInfor.Size = new System.Drawing.Size(697, 164);
            this.gbRoomInfor.TabIndex = 34;
            this.gbRoomInfor.TabStop = false;
            this.gbRoomInfor.Text = "Thông tin phòng ở của sinh viên";
            // 
            // cbbRoomArea
            // 
            this.cbbRoomArea.FormattingEnabled = true;
            this.cbbRoomArea.Location = new System.Drawing.Point(143, 35);
            this.cbbRoomArea.Name = "cbbRoomArea";
            this.cbbRoomArea.Size = new System.Drawing.Size(137, 24);
            this.cbbRoomArea.Sorted = true;
            this.cbbRoomArea.TabIndex = 1;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Location = new System.Drawing.Point(143, 72);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(137, 24);
            this.cbbRoomType.Sorted = true;
            this.cbbRoomType.TabIndex = 4;
            // 
            // cbbRoomRange
            // 
            this.cbbRoomRange.FormattingEnabled = true;
            this.cbbRoomRange.Location = new System.Drawing.Point(386, 35);
            this.cbbRoomRange.Name = "cbbRoomRange";
            this.cbbRoomRange.Size = new System.Drawing.Size(112, 24);
            this.cbbRoomRange.Sorted = true;
            this.cbbRoomRange.TabIndex = 2;
            this.cbbRoomRange.SelectedIndexChanged += new System.EventHandler(this.cbbRoomRange_SelectedIndexChanged);
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.AutoSize = true;
            this.lbRoomPrice.Location = new System.Drawing.Point(6, 111);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(95, 17);
            this.lbRoomPrice.TabIndex = 1;
            this.lbRoomPrice.Text = "Tiền phòng:";
            // 
            // lbRoomRange
            // 
            this.lbRoomRange.AutoSize = true;
            this.lbRoomRange.Location = new System.Drawing.Point(286, 38);
            this.lbRoomRange.Name = "lbRoomRange";
            this.lbRoomRange.Size = new System.Drawing.Size(91, 17);
            this.lbRoomRange.TabIndex = 1;
            this.lbRoomRange.Text = "Dãy phòng:";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(10, 76);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(94, 17);
            this.lbRoomType.TabIndex = 1;
            this.lbRoomType.Text = "Loại phòng:";
            // 
            // lbRoomArea
            // 
            this.lbRoomArea.AutoSize = true;
            this.lbRoomArea.Location = new System.Drawing.Point(10, 38);
            this.lbRoomArea.Name = "lbRoomArea";
            this.lbRoomArea.Size = new System.Drawing.Size(71, 17);
            this.lbRoomArea.TabIndex = 1;
            this.lbRoomArea.Text = "Khu vực:";
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.AutoSize = true;
            this.lbRoomStatus.Location = new System.Drawing.Point(299, 111);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(138, 17);
            this.lbRoomStatus.TabIndex = 1;
            this.lbRoomStatus.Text = "Trạng thái phòng:";
            // 
            // lbRoomQuantity
            // 
            this.lbRoomQuantity.AutoSize = true;
            this.lbRoomQuantity.Location = new System.Drawing.Point(314, 73);
            this.lbRoomQuantity.Name = "lbRoomQuantity";
            this.lbRoomQuantity.Size = new System.Drawing.Size(123, 17);
            this.lbRoomQuantity.TabIndex = 1;
            this.lbRoomQuantity.Text = "Số lượng tối đa:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(504, 38);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(59, 17);
            this.lbRoomID.TabIndex = 1;
            this.lbRoomID.Text = "Phòng:";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(143, 108);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(137, 23);
            this.txtRoomPrice.TabIndex = 6;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(569, 36);
            this.txtRoomID.MaxLength = 5;
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(86, 23);
            this.txtRoomID.TabIndex = 3;
            // 
            // txtRoomQuantity
            // 
            this.txtRoomQuantity.Location = new System.Drawing.Point(443, 70);
            this.txtRoomQuantity.Name = "txtRoomQuantity";
            this.txtRoomQuantity.Size = new System.Drawing.Size(212, 23);
            this.txtRoomQuantity.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 50);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(189, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 50);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu dữ liệu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbRoomStatus
            // 
            this.cbbRoomStatus.FormattingEnabled = true;
            this.cbbRoomStatus.Location = new System.Drawing.Point(443, 107);
            this.cbbRoomStatus.Name = "cbbRoomStatus";
            this.cbbRoomStatus.Size = new System.Drawing.Size(212, 24);
            this.cbbRoomStatus.Sorted = true;
            this.cbbRoomStatus.TabIndex = 1;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 245);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRoomInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu mẫu thêm phòng ở";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRoomForm_FormClosed);
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            this.gbRoomInfor.ResumeLayout(false);
            this.gbRoomInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoomInfor;
        private System.Windows.Forms.ComboBox cbbRoomArea;
        private System.Windows.Forms.ComboBox cbbRoomRange;
        private System.Windows.Forms.Label lbRoomPrice;
        private System.Windows.Forms.Label lbRoomRange;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label lbRoomArea;
        private System.Windows.Forms.Label lbRoomStatus;
        private System.Windows.Forms.Label lbRoomQuantity;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.TextBox txtRoomQuantity;
        private System.Windows.Forms.ComboBox cbbRoomType;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbRoomStatus;
    }
}