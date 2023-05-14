using ManageDormitory.BusinessLayer;
using PresentationLayer;
using System;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Student {
    public partial class AddStudentForm : Form {
        /// <summary>
        /// Bảng dữ liệu sinh viên
        /// </summary>
        private DataGridView studentDGV;
        /// <summary>
        /// Trường hợp cập nhật thì hiển thị thông tin một sinh viên
        /// </summary>
        private Models.Student student;
        /// <summary>
        /// Kiểm tra đã lưu hay chưa
        /// </summary>
        private bool isSaved = false;
        /// <summary>
        /// Hằng số thông báo khi tắt tab này
        /// </summary>
        private static string MESSAGE_EXIT = "Có vẻ bạn chưa lưu và muốn thoát tab này?";
        /// <summary>
        /// Hằng số có đuôi file được cho phép tải lên
        /// </summary>
        private static string EXTENSION_FILTER =
               "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png|jpeg files(*.jpeg)|*.jpeg";
        public AddStudentForm(DataGridView studentDGV, Models.Student student) {
            InitializeComponent();
            this.studentDGV = studentDGV;
            this.student = student;
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
                dialog.Filter = EXTENSION_FILTER;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    imageLocation = dialog.FileName;
                    pbStudentAvatar.ImageLocation = imageLocation;
                }
            } catch {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Thoát bằng nút x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (isSaved) {
                return;
            }
            if (e.CloseReason == CloseReason.UserClosing) {
                DialogResult resultMessage = MessageBox.Show(
                            MESSAGE_EXIT,
                            "Thông báo",
                            MessageBoxButtons.YesNo);
                if (resultMessage == DialogResult.Yes) {
                    Hide();
                } else {
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// Sự kiện huỷ bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e) {
            DialogResult resultMessage = MessageBox.Show(
                            MESSAGE_EXIT,
                            "Thông báo",
                            MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes) {
                Hide();
            }
        }
        /// <summary>
        /// Trường hợp lưu khi tạo mới một sinh viên
        /// </summary>
        /// <param name="values"></param>
        public void SaveWithCreate(string[] values) {
            // kiểm tra mã sinh viên có trùng không
            int isDuplicateStudentID = StudentServices.Count("Student", "id", txtStudentID.Text);
            if (isDuplicateStudentID > 0) {
                MessageBox.Show(
                  "Mã sinh viên này đã tồn tại!",
                  "Lỗi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
                return;
            }
            // thêm mới sinh viên
            int isCreateNewStudent = StudentServices.CreateNewStudent(values);
            if (isCreateNewStudent == 1) {
                MessageBox.Show(
                "Thêm mới một sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
                isSaved = true;
                Close();
            } else {
                MessageBox.Show(
                   "Thêm mới một sinh viên thất bại!",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        /// <summary>
        /// Trường hợp lưu khi cập nhật một sinh viên có sẵn
        /// </summary>
        /// <param name="values"></param>
        public void SaveWithUpdate(string[] values) {
            // cập nhật sinh viên
            int isUpdated = StudentServices.UpdateStudent(values);
            if (isUpdated == 1) {
                MessageBox.Show(
                "Cập nhật thông tin sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
                isSaved = true;
                Close();
            } else {
                MessageBox.Show(
                   "Cập nhật thông tin sinh viên thất bại!",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        /// <summary>
        /// Sự kiện tạo mới một sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e) {
            string[] cols = {
                    "Ảnh đại diện:",
                    lbStudentID.Text,
                    lbStudentName.Text,
                    lbStudentGender.Text,
                    lbStudentBirthdate.Text,
                    lbStudentCitizenIdentification.Text,
                    lbStudentDateIssue.Text,
                    lbStudentPlaceIssue.Text,
                    lbStudentAddress.Text,
                    lbStudentPhone.Text,
                    lbStudentEmail.Text,
                    lbStudentSchool.Text,
                    lbStudentIndustry.Text,
                    lbStudentCourse.Text,
                    // lbRoomID.Text,
            };

            string avatar = pbStudentAvatar.ImageLocation;
            bool gender = true;
            if (rbStudentGenderFeman.Checked) {
                gender = false;
            }

            DateTime? studentBirthdate = Codes.DMYStingToDateTime(
                dtpStudentBirthdate.Text
            );
            DateTime? studentDateIssue = Codes.DMYStingToDateTime(
                dtpStudentDateIssue.Text
            );
            string[] values = {
                    avatar,
                    txtStudentID.Text,
                    txtStudentName.Text,
                    gender.ToString(),
                    studentBirthdate?.ToString("yyyy-MM-dd"),
                    txtStudentCitizenIdentification.Text,
                    studentDateIssue?.ToString("yyyy-MM-dd"),
                    txtStudentPlaceIssue.Text,
                    txtStudentAddress.Text,
                    txtStudentPhone.Text,
                    txtStudentEmail.Text,
                    txtStudentSchool.Text,
                    txtStudentIndustry.Text,
                    txtStudentCourse.Text,
                    // cbbRoomID.Text,
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError) {
                return;
            }
            //cols.Append(lbRoomID.Text);
            //values.Append(cbbRoomID.Text);

            // trường hợp thêm
            if (student == null) {
                SaveWithCreate(values);
                return;
            }
            // trường hợp cập nhật
            SaveWithUpdate(values);
        }
        /// <summary>
        /// Xử lý sự kiện khi đã đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e) {
            studentDGV.Rows.Clear();
            StudentServices.LoadDatatable(studentDGV, StudentServices.ListOfStudents());
        }
        /// <summary>
        /// Xử lý khi form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentForm_Load(object sender, EventArgs e) {
            isSaved = false;
            if (student == null) {
                txtStudentID.Enabled = true;
                return;
            }
            txtStudentID.Enabled = false;
            pbStudentAvatar.ImageLocation = student.avatar;
            txtStudentID.Text = student.id;
            txtStudentName.Text = student.name;
            if (!student.gender) {
                rbStudentGenderFeman.Checked = true;
            }
            DateTime? studentBirthdate = Codes.DMYStingToDateTime(student.birthdate.ToString());
            DateTime? studentDateIssue = Codes.DMYStingToDateTime(student.date_issue.ToString());
            dtpStudentBirthdate.Text = studentBirthdate.ToString();
            txtStudentCitizenIdentification.Text = student.citizen_identification;
            dtpStudentDateIssue.Text = studentDateIssue.ToString();
            txtStudentPlaceIssue.Text = student.place_issue;
            txtStudentAddress.Text = student.address;
            txtStudentPhone.Text = student.phone;
            txtStudentEmail.Text = student.email;
            txtStudentSchool.Text = student.school;
            txtStudentIndustry.Text = student.industry;
            txtStudentCourse.Text = student.course;
            cbbRoomID.Text = student.room_id;
        }
    }
}
