﻿namespace ManageDormitory.PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SystemTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageStudentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageRoomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBoardingBillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageElecWaterBillTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMS = new System.Windows.Forms.MenuStrip();
            this.MainMS.SuspendLayout();
            this.SuspendLayout();
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
            this.LoginTSMI.Size = new System.Drawing.Size(132, 22);
            this.LoginTSMI.Text = "Đăng nhập";
            this.LoginTSMI.Click += new System.EventHandler(this.LoginTSMI_Click);
            // 
            // LogoutTSMI
            // 
            this.LogoutTSMI.Name = "LogoutTSMI";
            this.LogoutTSMI.Size = new System.Drawing.Size(132, 22);
            this.LogoutTSMI.Text = "Đăng xuất";
            this.LogoutTSMI.Click += new System.EventHandler(this.LogoutTSMI_Click);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.Size = new System.Drawing.Size(132, 22);
            this.ExitTSMI.Text = "Thoát";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // ManageTSM
            // 
            this.ManageTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageStudentTSMI,
            this.ManageRoomTSMI,
            this.BillTSMI});
            this.ManageTSM.Name = "ManageTSM";
            this.ManageTSM.Size = new System.Drawing.Size(60, 20);
            this.ManageTSM.Text = "Quản lý";
            // 
            // ManageStudentTSMI
            // 
            this.ManageStudentTSMI.Name = "ManageStudentTSMI";
            this.ManageStudentTSMI.Size = new System.Drawing.Size(122, 22);
            this.ManageStudentTSMI.Text = "Sinh viên";
            this.ManageStudentTSMI.Click += new System.EventHandler(this.ManageStudentTSMI_Click);
            // 
            // ManageRoomTSMI
            // 
            this.ManageRoomTSMI.Name = "ManageRoomTSMI";
            this.ManageRoomTSMI.Size = new System.Drawing.Size(122, 22);
            this.ManageRoomTSMI.Text = "Phòng ở";
            this.ManageRoomTSMI.Click += new System.EventHandler(this.ManageRoomTSMI_Click);
            // 
            // BillTSMI
            // 
            this.BillTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageBoardingBillTSMI,
            this.ManageElecWaterBillTSMI});
            this.BillTSMI.Name = "BillTSMI";
            this.BillTSMI.Size = new System.Drawing.Size(122, 22);
            this.BillTSMI.Text = "Hoá đơn";
            // 
            // ManageBoardingBillTSMI
            // 
            this.ManageBoardingBillTSMI.Name = "ManageBoardingBillTSMI";
            this.ManageBoardingBillTSMI.Size = new System.Drawing.Size(128, 22);
            this.ManageBoardingBillTSMI.Text = "Nội trú";
            this.ManageBoardingBillTSMI.Click += new System.EventHandler(this.ManageBoardingBillTSMI_Click);
            // 
            // ManageElecWaterBillTSMI
            // 
            this.ManageElecWaterBillTSMI.Name = "ManageElecWaterBillTSMI";
            this.ManageElecWaterBillTSMI.Size = new System.Drawing.Size(128, 22);
            this.ManageElecWaterBillTSMI.Text = "Điện nước";
            this.ManageElecWaterBillTSMI.Click += new System.EventHandler(this.ManageElecWaterBillTSMI_Click);
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // AboutTSMI
            // 
            this.AboutTSMI.Name = "AboutTSMI";
            this.AboutTSMI.Size = new System.Drawing.Size(125, 20);
            this.AboutTSMI.Text = "Thông tin ứng dụng";
            this.AboutTSMI.Click += new System.EventHandler(this.AboutTSMI_Click);
            // 
            // MainMS
            // 
            this.MainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemTSMI,
            this.ManageTSM,
            this.AboutTSMI});
            this.MainMS.Location = new System.Drawing.Point(0, 0);
            this.MainMS.Name = "MainMS";
            this.MainMS.Size = new System.Drawing.Size(800, 24);
            this.MainMS.TabIndex = 0;
            this.MainMS.Text = "menuStripApp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMS);
            this.MainMenuStrip = this.MainMS;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý ký túc xá [Admin]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MainMS.ResumeLayout(false);
            this.MainMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem SystemTSMI;
        private System.Windows.Forms.ToolStripMenuItem LoginTSMI;
        private System.Windows.Forms.ToolStripMenuItem LogoutTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageTSM;
        private System.Windows.Forms.ToolStripMenuItem ManageStudentTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageRoomTSMI;
        private System.Windows.Forms.ToolStripMenuItem BillTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageBoardingBillTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageElecWaterBillTSMI;
        //private System.Windows.Forms.ToolStripMenuItem StatisticTSM;
        //private System.Windows.Forms.ToolStripMenuItem StatisticStudentTSMI;
        //private System.Windows.Forms.ToolStripMenuItem StatisticRoomTSMI;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem StatisticBoardingBillTSMI;
        //private System.Windows.Forms.ToolStripMenuItem StatisticElecWaterTSMI;
        private System.Windows.Forms.ToolStripMenuItem AboutTSMI;
        private System.Windows.Forms.MenuStrip MainMS;
    }
}

