using System.Windows.Forms;

namespace PresentationLayer.Student {
    public partial class AddStudentForm : Form {
        public AddStudentForm() {
            InitializeComponent();
        }
        /// <summary>
        /// Chức năng tải ảnh đại diện của sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbStudentAvatar_Click(object sender, System.EventArgs e) {
            try {
                string imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter =
                    "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png|jpeg files(*.jpeg)|*.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    imageLocation = dialog.FileName;
                    pbStudentAvatar.ImageLocation = imageLocation;
                }
            } catch {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
