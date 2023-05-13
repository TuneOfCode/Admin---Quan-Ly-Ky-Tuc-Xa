using PresentationLayer.Auth;
using PresentationLayer.Student;
using System;
using System.Windows.Forms;

namespace PresentationLayer {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
        /// <summary>
        /// Sự kiện mở biểu mẫu đăng nhập hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTSMI_Click(object sender, EventArgs e) {
            new LoginForm().Show();
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
            new MainStudentForm().Show();
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
    }
}
