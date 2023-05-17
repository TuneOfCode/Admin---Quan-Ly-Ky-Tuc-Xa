using ManageDormitory.BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Nếu có cờ này thì sẽ là hiển thị chi tiết
        /// </summary>
        private bool isReadonly;
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
        public AddStudentForm(DataGridView studentDGV, Models.Student student, bool isReadonly = false) {
            InitializeComponent();
            this.studentDGV = studentDGV;
            this.student = student;
            this.isReadonly = isReadonly;
            cbbRoomRange.Enabled = cbbRoomID.Enabled = btnReset.Visible = false;

            // Đôi tên form
            if (student != null && !isReadonly) {
                Text = "Biểu mẫu cập nhật thông tin của sinh viên";
            } else if (student != null && isReadonly) {
                Text = "Biểu mẫu xem thông tin chi tiết sinh viên";
            } else {
                Text = "Biểu mẫu thêm sinh viên";
            }
            // thêm dữ liệu vào khu vực phòng ở
            string[] areas = { };
            IList<Models.Room> rooms = RoomServices.ListOfRooms();
            foreach (var room in rooms) {
                if (room != null && !areas.Contains(room.area)) {
                    Array.Resize(ref areas, areas.Length + 1);
                    areas[areas.Length - 1] = room.area;
                }
            }
            cbbRoomArea.Items.AddRange(areas);
        }
        /// <summary>
        /// Chức năng tải ảnh đại diện của sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbStudentAvatar_Click(object sender, System.EventArgs e) {
            if (isReadonly) {
                return;
            }
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
            if (isSaved || isReadonly) {
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
            //string val = "";
            //foreach (string value in values) {
            //    val += $"\n {value} \n";
            //}
            //MessageBox.Show($"values: {val}");
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
                    lbRoomID.Text,
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
            if (string.IsNullOrEmpty(cbbRoomID.Text)) {
                MessageBox.Show(
                   $"Vui lòng chọn phòng",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }
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
                    cbbRoomID.Text,
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError) {
                return;
            }

            // kiểm tra trường hợp chọn phòng:
            //  + loại phòng: nam / nữ
            //  + số lượng
            bool isRoomType = (txtRoomType.Text == "nam") ? true : false;
            string type = isRoomType ? "nữ" : "nam";
            if (gender != isRoomType) {
                MessageBox.Show(
                   $"Vui lòng chọn phòng khác. Phải chọn loại phòng giành cho {type}",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }
            if (txtRoomQuantity.Text == txtRoomMaxQuantity.Text) {
                MessageBox.Show(
                   $"Hiện phòng đã đầy. Vui lòng chọn phòng khác",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }

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
            dtpStudentBirthdate.Text = student.birthdate.ToString();
            txtStudentCitizenIdentification.Text = student.citizen_identification;
            dtpStudentDateIssue.Text = student.date_issue.ToString();
            txtStudentPlaceIssue.Text = student.place_issue;
            txtStudentAddress.Text = student.address;
            txtStudentPhone.Text = student.phone;
            txtStudentEmail.Text = student.email;
            txtStudentSchool.Text = student.school;
            txtStudentIndustry.Text = student.industry;
            txtStudentCourse.Text = student.course;
            cbbRoomID.Text = student.room_id;

            if (!string.IsNullOrEmpty(student.room_id)) {
                Models.Room room = RoomServices.GetRoom(student.room_id);
                int currentQuantity = StudentServices.Count("Student", "room_id", student.room_id);
                cbbRoomArea.Text = room.area;
                cbbRoomRange.Text = room.range;
                txtRoomType.Text = room.type;
                txtRoomQuantity.Text = currentQuantity.ToString();
                txtRoomMaxQuantity.Text = room.quantity.ToString();
                txtRoomPrice.Text = room.price.ToString("N2");
                txtRoomStatus.Text = room.status;
            }

            // xử lý khi có cờ đọc chi tiết
            pbStudentAvatar.Enabled
            // = txtStudentID.Enabled
            = txtStudentName.Enabled
            = rbStudentGenderMan.Enabled
            = rbStudentGenderFeman.Enabled
            = dtpStudentBirthdate.Enabled
            = dtpStudentDateIssue.Enabled
            = txtStudentCitizenIdentification.Enabled
            = txtStudentPlaceIssue.Enabled
            = txtStudentAddress.Enabled
            = txtStudentEmail.Enabled
            = txtStudentPhone.Enabled
            = txtStudentSchool.Enabled
            = txtStudentIndustry.Enabled
            = txtStudentCourse.Enabled
            = cbbRoomArea.Enabled
            // = cbbRoomRange.Enabled
            // = cbbRoomID.Enabled
            = btnCancel.Visible
            = btnSave.Visible
            = !isReadonly;
            btnReset.Visible = cbbRoomID.Enabled = false;
        }
        /// <summary>
        /// Xử lý khi chọn vào khu vực phòng ở
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbRoomArea_SelectedIndexChanged(object sender, EventArgs e) {
            cbbRoomRange.Items.Clear();
            cbbRoomRange.Enabled = btnReset.Visible = true;
            cbbRoomArea.Enabled = false;
            string selectedValue = cbbRoomArea.SelectedItem.ToString();
            IList<Models.Room> rooms = RoomServices.ListOfRooms("Room", "area", selectedValue);
            string[] ranges = { };
            foreach (var room in rooms) {
                if (room != null && !ranges.Contains(room.range)) {
                    Array.Resize(ref ranges, ranges.Length + 1);
                    ranges[ranges.Length - 1] = room.range;
                }
            }
            cbbRoomRange.Items.AddRange(ranges);
        }
        /// <summary>
        /// Xử lý khi chọn vào dãy phòng ở
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbRoomRange_SelectedIndexChanged(object sender, EventArgs e) {
            cbbRoomID.SelectedItem = "";
            cbbRoomID.Items.Clear();
            cbbRoomID.Enabled = true;
            cbbRoomRange.Enabled = false;
            string selectedValue = cbbRoomRange.SelectedItem.ToString();
            string sql = $"SELECT * FROM Room WHERE area = '{cbbRoomArea.SelectedItem}' AND range = '{selectedValue}'";
            IList<Models.Room> rooms = RoomServices.QuerySQL(sql);
            string[] ids = { };
            foreach (var room in rooms) {
                if (room != null && !ids.Contains(room.id)) {
                    Array.Resize(ref ids, ids.Length + 1);
                    ids[ids.Length - 1] = room.id;
                }
            }
            cbbRoomID.Items.AddRange(ids);
        }
        /// <summary>
        /// Xử lý khi chọn phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbRoomID_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedValue = cbbRoomID.SelectedItem.ToString();
            Models.Room room = RoomServices.GetRoom(selectedValue);
            int currentQuantity = StudentServices.Count("Student", "room_id", selectedValue);
            txtRoomType.Text = room.type;
            txtRoomQuantity.Text = currentQuantity.ToString();
            txtRoomMaxQuantity.Text = room.quantity.ToString();
            txtRoomPrice.Text = room.price.ToString("N2");
            txtRoomStatus.Text = room.status;
            cbbRoomID.Enabled = false;
            btnReset.Visible = true;
        }
        /// <summary>
        /// Xử lý khi đặt lại giá trị cho khu vực, dãy và phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e) {
            cbbRoomArea.Items.Clear();
            cbbRoomArea.Enabled = true;
            cbbRoomRange.Enabled = false;
            // thêm dữ liệu vào khu vực phòng ở
            string[] areas = { };
            IList<Models.Room> rooms = RoomServices.ListOfRooms();
            foreach (var room in rooms) {
                if (room != null && !areas.Contains(room.area)) {
                    Array.Resize(ref areas, areas.Length + 1);
                    areas[areas.Length - 1] = room.area;
                }
            }
            cbbRoomArea.Items.AddRange(areas);
            btnReset.Visible = cbbRoomID.Enabled = false;
        }
    }
}
