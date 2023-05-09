namespace PresentationLayer
{
    partial class Main
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
            this.MainMS = new System.Windows.Forms.MenuStrip();
            this.SystemTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BoardingBillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ElecWaterBillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMS
            // 
            this.MainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemTSMI,
            this.ManageTSMI,
            this.AboutTSMI});
            this.MainMS.Location = new System.Drawing.Point(0, 0);
            this.MainMS.Name = "MainMS";
            this.MainMS.Size = new System.Drawing.Size(800, 24);
            this.MainMS.TabIndex = 0;
            this.MainMS.Text = "menuStripApp";
            // 
            // SystemTSMI
            // 
            this.SystemTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginTSMI,
            this.LogoutTSMI,
            this.ExitTSMI});
            this.SystemTSMI.Name = "SystemTSMI";
            this.SystemTSMI.Size = new System.Drawing.Size(69, 20);
            this.SystemTSMI.Text = "Hệ thống";
            // 
            // LoginTSMI
            // 
            this.LoginTSMI.Name = "LoginTSMI";
            this.LoginTSMI.Size = new System.Drawing.Size(180, 22);
            this.LoginTSMI.Text = "Đăng nhập";
            this.LoginTSMI.Click += new System.EventHandler(this.LoginTSMI_Click);
            // 
            // LogoutTSMI
            // 
            this.LogoutTSMI.Name = "LogoutTSMI";
            this.LogoutTSMI.Size = new System.Drawing.Size(180, 22);
            this.LogoutTSMI.Text = "Đăng xuất";
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.Size = new System.Drawing.Size(180, 22);
            this.ExitTSMI.Text = "Thoát";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // ManageTSMI
            // 
            this.ManageTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentTSMI,
            this.RoomTSMI,
            this.BillTSMI});
            this.ManageTSMI.Name = "ManageTSMI";
            this.ManageTSMI.Size = new System.Drawing.Size(60, 20);
            this.ManageTSMI.Text = "Quản lý";
            // 
            // AboutTSMI
            // 
            this.AboutTSMI.Name = "AboutTSMI";
            this.AboutTSMI.Size = new System.Drawing.Size(125, 20);
            this.AboutTSMI.Text = "Thông tin ứng dụng";
            // 
            // StudentTSMI
            // 
            this.StudentTSMI.Name = "StudentTSMI";
            this.StudentTSMI.Size = new System.Drawing.Size(180, 22);
            this.StudentTSMI.Text = "Sinh viên";
            // 
            // RoomTSMI
            // 
            this.RoomTSMI.Name = "RoomTSMI";
            this.RoomTSMI.Size = new System.Drawing.Size(180, 22);
            this.RoomTSMI.Text = "Phòng ở";
            // 
            // BillTSMI
            // 
            this.BillTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoardingBillTSMI,
            this.ElecWaterBillTSMI});
            this.BillTSMI.Name = "BillTSMI";
            this.BillTSMI.Size = new System.Drawing.Size(180, 22);
            this.BillTSMI.Text = "Hoá đơn";
            // 
            // BoardingBillTSMI
            // 
            this.BoardingBillTSMI.Name = "BoardingBillTSMI";
            this.BoardingBillTSMI.Size = new System.Drawing.Size(180, 22);
            this.BoardingBillTSMI.Text = "Nội trú";
            // 
            // ElecWaterBillTSMI
            // 
            this.ElecWaterBillTSMI.Name = "ElecWaterBillTSMI";
            this.ElecWaterBillTSMI.Size = new System.Drawing.Size(180, 22);
            this.ElecWaterBillTSMI.Text = "Điện nước";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMS);
            this.MainMenuStrip = this.MainMS;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý ký túc xá [Admin]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMS.ResumeLayout(false);
            this.MainMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMS;
        private System.Windows.Forms.ToolStripMenuItem SystemTSMI;
        private System.Windows.Forms.ToolStripMenuItem LoginTSMI;
        private System.Windows.Forms.ToolStripMenuItem LogoutTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageTSMI;
        private System.Windows.Forms.ToolStripMenuItem StudentTSMI;
        private System.Windows.Forms.ToolStripMenuItem RoomTSMI;
        private System.Windows.Forms.ToolStripMenuItem BillTSMI;
        private System.Windows.Forms.ToolStripMenuItem BoardingBillTSMI;
        private System.Windows.Forms.ToolStripMenuItem ElecWaterBillTSMI;
        private System.Windows.Forms.ToolStripMenuItem AboutTSMI;
    }
}

