using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Auth {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }
        /// <summary>
        /// Xử lý sự kiện đăng nhập 
        /// </summary>
        private void btnLogin_Click(object sender, System.EventArgs e) {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "123") {
                MessageBox.Show(
                   "Đăng nhập thành công",
                   "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                   );
                Temp.IsShow = false;
                new Main(Temp.IsShow).Show();
                Hide();
            } else {
                MessageBox.Show(
                    "Tài khoản hoặc mật khẩu không chính xác",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        /// <summary>
        /// Xử lý sự kiện huỷ bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e) {
            DialogResult resultMessage = MessageBox.Show("Bạn có chắc chắn thoát phần mềm?",
                            "Thông báo",
                            MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
