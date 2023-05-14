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
                //MessageBox.Show(
                //   "Đăng nhập thành công",
                //   "Thông báo"
                //   );
                Temp.IsShow = false;
                Close();
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
            Close();
        }
    }
}
