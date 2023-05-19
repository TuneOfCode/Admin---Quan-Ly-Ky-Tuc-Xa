using ManageDormitory.PresentationLayer.Auth;
using ManageDormitory.PresentationLayer.Bill;
using ManageDormitory.PresentationLayer.Room;
using ManageDormitory.PresentationLayer.Student;
using System;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer {
    public partial class Main : Form {
        public Main(bool isShow) {
            InitializeComponent();
            // ToogleMenuItem(Temp.IsShow);
            ToogleMenuItem(isShow);
        }
        /// <summary>
        /// Ẩn hiện phần tử trong menu
        /// </summary>
        public void ToogleMenuItem(bool isShow) {
            LoginTSMI.Enabled = ExitTSMI.Enabled = isShow;
            LogoutTSMI.Enabled = ManageTSM.Enabled = StatisticTSM.Enabled = AboutTSMI.Enabled = !isShow;
        }
        /// <summary>
        /// Sự kiện mở biểu mẫu đăng nhập hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTSMI_Click(object sender, EventArgs e) {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        /// <summary>
        /// Sự kiện thoát chương trình nếu người dùng bấm nút "Thoát"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitTSMI_Click(object sender, EventArgs e) {
            DialogResult resultMessage = MessageBox.Show("Bạn có chắc chắn thoát phần mềm?",
                            "Thông báo",
                            MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes) {
                Application.Exit();
            }
        }
        /// <summary>
        /// Mở nội dung chính của sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageStudentTSMI_Click(object sender, EventArgs e) {
            MainStudentForm mainStudentForm = new MainStudentForm();
            mainStudentForm.Show();
        }
        /// <summary>
        /// Sự kiện thoát chương trình nếu người dùng bấm nút X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                DialogResult resultMessage = MessageBox.Show("Bạn có chắc chắn thoát phần mềm?",
                           "Thông báo",
                           MessageBoxButtons.YesNo);
                if (resultMessage == DialogResult.Yes) {
                    Application.Exit();
                } else {
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// Xử lý sự kiện khi hoạt động
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Activated(object sender, EventArgs e) {
            ToogleMenuItem(Temp.IsShow);
        }
        /// <summary>
        /// Xử lý sự kiện đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutTSMI_Click(object sender, EventArgs e) {
            Temp.IsShow = !Temp.IsShow;
            ToogleMenuItem(Temp.IsShow);
        }
        /// <summary>
        /// Xử lý sự kiện khi chọn mục quản lý phòng ở
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageRoomTSMI_Click(object sender, EventArgs e) {
            new MainRoomForm().Show();
        }
        /// <summary>
        /// Xử lý sự kiện khi chọn mục quản lý hoá đơn nội trú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageBoardingBillTSMI_Click(object sender, EventArgs e) {
            new MainBoardingBillForm().Show();
        }
        /// <summary>
        /// Xử lý sự kiện khi chọn mục quản lý hoá đơn điện nước
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageElecWaterBillTSMI_Click(object sender, EventArgs e) {
            new MainElectricityWaterBillForm().Show();
        }
    }
}
