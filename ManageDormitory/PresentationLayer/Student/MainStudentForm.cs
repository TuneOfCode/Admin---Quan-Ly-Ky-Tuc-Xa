using ManageDormitory.BusinessLayer;
using PresentationLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Student {
    public partial class MainStudentForm : Form {
        /// <summary>
        /// Giá trị của sinh viên lấy từ database
        /// </summary>
        private IList<Models.Student> students;
        /// <summary>
        /// Danh sáchh mã sinh viên khi được checkbox
        /// </summary>
        List<string> studentIDs;
        /// <summary>
        /// thêm giá trị vào bảng lọc cột để tìm kiếm
        /// </summary>
        private ComboBoxItem[] colsStudent = {
                new ComboBoxItem{
                    DisplayName = "Họ và tên",
                    Value = "name"
                },
                new ComboBoxItem{
                    DisplayName = "Mã sinh viên",
                    Value = "id"
                },
                 new ComboBoxItem{
                    DisplayName = "Số điện thoại",
                    Value = "phone"
                },
                  new ComboBoxItem{
                    DisplayName = "Trường",
                    Value = "school"
                },
        };
        /// <summary>
        /// Giá trị cột được lọc
        /// </summary>
        private string colFilter = "name";
        public MainStudentForm() {
            InitializeComponent();
            btnSearch.Visible = false;
            btnUpdate.Enabled = btnDelete.Enabled = false;
            students = new List<Models.Student>();
        }
        /// <summary>
        /// Tải lại toàn bộ dữ liệu
        /// </summary>
        /// <param name="hasNull"></param>
        private void LoadData(bool hasNull = true) {
            studentIDs = new List<string>();
            StudentDGV.Rows.Clear();

            students = StudentServices.ListOfStudents(
                hasNull ? null : "Student",
                hasNull ? null : colFilter,
                hasNull ? null : txtSearch.Text
            );
            StudentServices.LoadDatatable(StudentDGV, students);
        }
        /// <summary>
        /// Xử lý sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainStudentForm_Load(object sender, EventArgs e) {
            // Đưa giá trị trong SQL vào data grid view
            LoadData();
            // Đưa giá trị lọc theo cột vào combobox
            foreach (var col in colsStudent) {
                cbbField.Items.Add(col.DisplayName);
            }
            cbbField.SelectedText = colsStudent[0].DisplayName;
            cbbField.SelectedItem = colsStudent[0].Value;
        }
        /// <summary>
        /// Thêm danh sách bảng chọn khi bấm chuột phải vào 1 dòng
        /// </summary>
        /// <param name="dgv"></param>
        public void AddContextMenu(DataGridView dgv) {
            ContextMenuStrip strip = new ContextMenuStrip();
            ToolStripItem checkAll = strip.Items.Add("Chọn tất cả");
            ToolStripItem unCheckAll = strip.Items.Add("Huỷ chọn tất cả");
            ToolStripItem getDetail = strip.Items.Add("Xem chi tiết");
            ToolStripItem createNewBill = strip.Items.Add("Tạo hóa đơn mới");

            checkAll.Click += new EventHandler(checkAll_Click);
            unCheckAll.Click += new EventHandler(unCheckAll_Click);
            getDetail.Click += new EventHandler(getDetail_Click);
            createNewBill.Click += new EventHandler(createNewBill_Click);


            foreach (DataGridViewColumn column in dgv.Columns) {
                column.ContextMenuStrip = strip;
            }
        }
        /// <summary>
        /// Sự kiện chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in StudentDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBStudent"];
                chk.Value = true;
            }
        }
        /// <summary>
        /// Sự kiện huỷ chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unCheckAll_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in StudentDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBStudent"];
                chk.Value = false;
            }
        }
        /// <summary>
        /// Sự kiện xem chi tiết một bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDetail_Click(object sender, EventArgs e) {
            // TODO: ĐANG LÀM
            // studentIDs = new List<string>();
            // var cell = StudentDGV.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // string studentID = StudentDGV["StudentID", cell.RowIndex].Value.ToString();
            MessageBox.Show($"Lấy chi tiết của hàng có mã sinh viên");
        }
        DataGridViewCellEventArgs mouseLocation;
        void AddMouseEnterEvent() {
            StudentDGV.CellMouseEnter += (s, e) => { mouseLocation = e; };
        }

        /// <summary>
        /// Sự kiến tạo một hoá đơn mới cho một sinh viên được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewBill_Click(object sender, EventArgs e) {
            // var cell = StudentDGV.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            //// do something stupid
            //cell.Style.BackColor = Color.Red;
            MessageBox.Show("Tạo hóa đơn cho sinh viên này");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentDataGridView_MouseClick(object sender, MouseEventArgs e) {
            // sự kiện chuột phải
            if (e.Button == MouseButtons.Right) {
                AddContextMenu(StudentDGV);
            }
        }
        /// <summary>
        /// Xử lý khi có tác động vào ô
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            Codes.AllowedCheckbox(StudentDGV, e);
        }
        /// <summary>
        /// Xử lý sự kiện lọc theo cột để tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbField_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedValue = cbbField.SelectedItem.ToString();
            // MessageBox.Show($"Giá trị khi lọc theo cột: {selectedValue}", "Thông báo");
            foreach (var col in colsStudent) {
                if (col.DisplayName == selectedValue) {
                    // MessageBox.Show($"Giá trị mảng khớp được chọn: {col.Value}", "Thông báo");
                    colFilter = col.Value;
                    break;
                }
            }
        }
        /// <summary>
        /// Xử lý nút tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e) {
            bool hasNull = string.IsNullOrEmpty(colFilter) && string.IsNullOrEmpty(colFilter);
            LoadData(hasNull);
        }
        /// <summary>
        /// Xử lý sự kiện khi có giá trị trong 1 ô bị thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra xem sự kiện được kích hoạt bởi checkbox hay không
            if (StudentDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0) {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)StudentDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;

                // Xử lý sự kiện checkbox
                string studentID = StudentDGV["StudentID", e.RowIndex].Value.ToString();
                if (isChecked) {
                    studentIDs.Add(studentID);
                    // MessageBox.Show($"Checkbox đã được chọn có mã sinh viên {studentID}");
                } else {
                    studentIDs.Remove(studentID);
                }

                // MessageBox.Show($"Mảng có mã sinh viên có độ dài {studentIDs.Count()}");
                switch (studentIDs.Count()) {
                    case 0:
                        btnUpdate.Enabled = btnDelete.Enabled = false;
                        break;
                    case 1:
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        break;
                    default:
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = true;
                        break;
                }
            }
        }
        /// <summary>
        /// Sự kiện thay đổi nội dung trong thanh tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSearch.Text)) {
                StudentDGV.Rows.Clear();
                students = StudentServices.ListOfStudents();
            }
            bool hasNull = string.IsNullOrEmpty(colFilter) && string.IsNullOrEmpty(txtSearch.Text);
            LoadData(hasNull);
        }
        /// <summary>
        /// Mở form thêm sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e) {
            new AddStudentForm(StudentDGV, null).Show();
            studentIDs = new List<string>();
            btnUpdate.Enabled = btnDelete.Enabled = false;
        }
        /// <summary>
        /// Xử lý sự kiện 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e) {
            Models.Student s = StudentServices.GetStudent(studentIDs[0]);
            new AddStudentForm(StudentDGV, s).Show();
            studentIDs = new List<string>();
            btnUpdate.Enabled = btnDelete.Enabled = false;
        }
        /// <summary>
        /// Xử lý sự kiện xoá một hoặc nhiều sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            string infor = "";
            for (int i = 0; i < studentIDs.Count; i++) {
                infor += $"\n {i + 1}. {studentIDs[i]} \n";
            }
            DialogResult resultMessage = MessageBox.Show(
                "Bạn có chắc chắn muốn xoá những sinh viên đã chọn?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultMessage == DialogResult.No) {
                return;
            }
            int isDeleted = StudentServices.DeleteStudent(studentIDs);
            if (isDeleted > 0) {
                MessageBox.Show
                    ($"Những sinh viên có mã sau sẽ bị xoá: {infor}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LoadData();
            } else {
                MessageBox.Show(
                  "Có lỗi khi xoá sinh viên!",
                  "Lỗi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }
    }
}
