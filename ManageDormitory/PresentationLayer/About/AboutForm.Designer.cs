namespace ManageDormitory.PresentationLayer.About {
    partial class AboutForm {
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
            this.lbIntroduce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIntroduce
            // 
            this.lbIntroduce.AutoSize = true;
            this.lbIntroduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntroduce.Location = new System.Drawing.Point(12, 9);
            this.lbIntroduce.Name = "lbIntroduce";
            this.lbIntroduce.Size = new System.Drawing.Size(365, 155);
            this.lbIntroduce.TabIndex = 0;
            this.lbIntroduce.Text = "Ứng dụng quản lý ký túc xá\r\nNgười thực hiện:\r\n1. Trần Thanh Tú \r\n2. Nguyễn Thị Th" +
    "u Ni\r\n3. Nguyễn Đức Tuyến ";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 178);
            this.Controls.Add(this.lbIntroduce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin ứng dụng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntroduce;
    }
}