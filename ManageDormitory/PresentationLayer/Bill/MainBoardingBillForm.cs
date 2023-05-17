using ManageDormitory.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Bill {
    public partial class MainBoardingBillForm : Form {
        /// <summary>
        /// Giá trị của hoá đơn lấy từ database
        /// </summary>
        private IList<Models.BoardingBill> boardingBills;
        /// <summary>
        /// Danh sách phòng ở khi được checkbox
        /// </summary>
        List<string> boardingBillIDs;
        /// <summary>
        /// Lấy hoá đơn theo mã sinh viên
        /// </summary>
        private string studentID;
        /// <summary>
        /// Giá trị cột được lọc
        /// </summary>
        private string colFilter = "name";
        /// <summary>
        /// thêm giá trị vào bảng lọc cột để tìm kiếm
        /// </summary>
        private string[] statusFilter = {
                "Xem tất cả",
                "Chờ thanh toán",
                "Đã thanh toán"
        };
        public MainBoardingBillForm(string studentID = "") {
            InitializeComponent();
            btnAccept.Enabled = false;
            boardingBills = new List<Models.BoardingBill>();
            this.studentID = studentID;
        }
        /// <summary>
        /// Tải lại toàn bộ dữ liệu
        /// </summary>
        /// <param name="hasNull"></param>
        private void LoadData(bool hasNull = true, string selectedValue = "Xem tất cả") {
            boardingBillIDs = new List<string>();
            BoardingBillDGV.Rows.Clear();

            if ((!string.IsNullOrEmpty(studentID)
                && string.IsNullOrEmpty(txtSearch.Text)
                && selectedValue == "Xem tất cả")) {
                boardingBills = BoardingBillServices.ListOfBoardingBills(
                        "BoardingBill",
                        "student_id",
                        studentID
                 );
                BoardingBillServices.LoadDatatable(BoardingBillDGV, boardingBills);
                btnAccept.Enabled = false;
                return;
            }
            if (string.IsNullOrEmpty(txtSearch.Text)
                        && selectedValue == "Xem tất cả") {
                boardingBills = BoardingBillServices.ListOfBoardingBills();
                BoardingBillServices.LoadDatatable(BoardingBillDGV, boardingBills);
                btnAccept.Enabled = false;
                return;
            }
            if (!string.IsNullOrEmpty(txtSearch.Text) && selectedValue == "Xem tất cả") {
                boardingBills = BoardingBillServices.ListOfBoardingBills(
                    hasNull ? null : "BoardingBill",
                    hasNull ? null : colFilter,
                    hasNull ? null : txtSearch.Text
                );
                BoardingBillServices.LoadDatatable(BoardingBillDGV, boardingBills);
                btnAccept.Enabled = false;
                return;
            }
            boardingBills = BoardingBillServices.ListOfBoardingBills(
                    "BoardingBill",
                    "status",
                    selectedValue
            );
            BoardingBillServices.LoadDatatable(BoardingBillDGV, boardingBills);
            btnAccept.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBoardingBillForm_Load(object sender, EventArgs e) {
            LoadData();
            cbbField.Items.AddRange(statusFilter);
        }
        /// <summary>
        /// Thêm danh sách bảng chọn khi bấm chuột phải vào 1 dòng
        /// </summary>
        /// <param name="dgv"></param>
        public void AddContextMenu(DataGridView dgv) {
            ContextMenuStrip strip = new ContextMenuStrip();
            ToolStripItem checkAll = strip.Items.Add("Chọn tất cả");
            ToolStripItem unCheckAll = strip.Items.Add("Huỷ chọn tất cả");

            checkAll.Click += new EventHandler(checkAll_Click);
            unCheckAll.Click += new EventHandler(unCheckAll_Click);


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
            foreach (DataGridViewRow row in BoardingBillDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBBoardingBill"];
                chk.Value = true;
            }
        }
        /// <summary>
        /// Sự kiện huỷ chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unCheckAll_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in BoardingBillDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBBoardingBill"];
                chk.Value = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardingBillDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            Codes.AllowedCheckbox(BoardingBillDGV, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardingBillDGV_MouseClick(object sender, MouseEventArgs e) {
            // sự kiện chuột phải
            if (e.Button == MouseButtons.Right) {
                AddContextMenu(BoardingBillDGV);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardingBillDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra xem sự kiện được kích hoạt bởi checkbox hay không
            if (BoardingBillDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0) {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)BoardingBillDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;

                // Xử lý sự kiện checkbox
                string boardingBillID = BoardingBillDGV["BoardingBillID", e.RowIndex].Value.ToString();
                if (isChecked) {
                    boardingBillIDs.Add(boardingBillID);
                } else {
                    boardingBillIDs.Remove(boardingBillID);
                }

                switch (boardingBillIDs.Count()) {
                    case 0:
                        btnAccept.Enabled = false;
                        break;
                    case 1:
                        btnAccept.Enabled = true;
                        break;
                    default:
                        btnAccept.Enabled = true;
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSearch.Text)) {
                BoardingBillDGV.Rows.Clear();
                boardingBills = BoardingBillServices.ListOfBoardingBills();
            }
            bool hasNull = string.IsNullOrEmpty(colFilter) && string.IsNullOrEmpty(txtSearch.Text);
            LoadData(hasNull);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbField_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedValue = cbbField.SelectedItem.ToString();
            if (selectedValue == "Xem tất cả") {
                BoardingBillDGV.Rows.Clear();
                boardingBills = BoardingBillServices.ListOfBoardingBills();
                BoardingBillServices.LoadDatatable(BoardingBillDGV, boardingBills);
                return;
            }
            LoadData(string.IsNullOrEmpty(selectedValue), selectedValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e) {
            string infor = "";
            for (int i = 0; i < boardingBillIDs.Count; i++) {
                infor += $"\n {i + 1}. {boardingBillIDs[i]} \n";
            }
            DialogResult resultMessage = MessageBox.Show(
                $"Xác nhận những hoá đơn này đã được thanh toán?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultMessage == DialogResult.No) {
                return;
            }
            int isAcceptPayment = 0;
            for (int i = 0; i < boardingBillIDs.Count; i++) {
                var boardingBill = BoardingBillServices.GetBoardingBill(
                    null,
                    "BoardingBill",
                    "id",
                    boardingBillIDs[i]
                );
                boardingBill.status = "Đã thanh toán";
                isAcceptPayment = BoardingBillServices.UpdateBoardingBill(boardingBill);
                if (isAcceptPayment == 0) {
                    break;
                }
            }
            if (isAcceptPayment > 0) {
                MessageBox.Show
                    ($"Những hoá đơn có mã sau đã được thanh toán: {infor}",
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
