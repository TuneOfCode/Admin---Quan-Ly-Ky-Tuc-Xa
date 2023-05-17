using ManageDormitory.BusinessLayer;
using PresentationLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Room {
    public partial class MainRoomForm : Form {
        /// <summary>
        /// Giá trị của phòng ở lấy từ database
        /// </summary>
        private IList<Models.Room> rooms;
        /// <summary>
        /// Danh sách phòng ở khi được checkbox
        /// </summary>
        List<string> roomIDs;
        /// <summary>
        /// Giá trị cột được lọc
        /// </summary>
        private string colFilter = "id";
        /// <summary>
        /// thêm giá trị vào bảng lọc cột để tìm kiếm
        /// </summary>
        private ComboBoxItem[] colsRoom = {
                new ComboBoxItem{
                    DisplayName = "Tên phòng",
                    Value = "id"
                },
                new ComboBoxItem{
                    DisplayName = "Khu phòng ở",
                    Value = "area"
                },
                 new ComboBoxItem{
                    DisplayName = "Dãy phòng ở",
                    Value = "range"
                }
        };
        public MainRoomForm() {
            InitializeComponent();
            btnUpdate.Enabled = btnDelete.Enabled = false;
            rooms = new List<Models.Room>();
        }
        /// <summary>
        /// Tải lại toàn bộ dữ liệu
        /// </summary>
        /// <param name="hasNull"></param>
        private void LoadData(bool hasNull = true) {
            roomIDs = new List<string>();
            RoomDGV.Rows.Clear();

            rooms = RoomServices.ListOfRooms(
                hasNull ? null : "Room",
                hasNull ? null : colFilter,
                hasNull ? null : txtSearch.Text
            );
            RoomServices.LoadDatatable(RoomDGV, rooms);
            btnUpdate.Enabled = btnDelete.Enabled = false;
        }
        /// <summary>
        /// Tải lại form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainRoomForm_Load(object sender, System.EventArgs e) {
            // Đưa giá trị trong SQL vào data grid view
            LoadData();
            // Đưa giá trị lọc theo cột vào combobox
            foreach (var col in colsRoom) {
                cbbField.Items.Add(col.DisplayName);
            }
            cbbField.SelectedText = colsRoom[0].DisplayName;
            cbbField.SelectedItem = colsRoom[0].Value;
        }
        /// <summary>
        /// Thêm danh sách bảng chọn khi bấm chuột phải vào 1 dòng
        /// </summary>
        /// <param name="dgv"></param>
        public void AddContextMenu(DataGridView dgv) {
            ContextMenuStrip strip = new ContextMenuStrip();
            ToolStripItem checkAll = strip.Items.Add("Chọn tất cả");
            ToolStripItem unCheckAll = strip.Items.Add("Huỷ chọn tất cả");
            ToolStripItem createNewBill = strip.Items.Add("Tạo hóa đơn mới");

            checkAll.Click += new EventHandler(checkAll_Click);
            unCheckAll.Click += new EventHandler(unCheckAll_Click);
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
            foreach (DataGridViewRow row in RoomDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBRoom"];
                chk.Value = true;
            }
        }
        /// <summary>
        /// Sự kiện huỷ chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unCheckAll_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in RoomDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBRoom"];
                chk.Value = false;
            }
        }
        /// <summary>
        /// Sự kiến tạo một hoá đơn tiền điện nước mới cho một phòng được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewBill_Click(object sender, EventArgs e) {
            string roomID = null;
            if (RoomDGV.CurrentRow != null) {
                roomID = RoomDGV["RoomID", RoomDGV.CurrentRow.Index].Value.ToString();
            }
            MessageBox.Show($"Tạo hóa đơn cho phòng: {roomID}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomDGV_MouseClick(object sender, MouseEventArgs e) {
            // sự kiện chuột phải
            if (e.Button == MouseButtons.Right) {
                AddContextMenu(RoomDGV);
            }
        }
        /// <summary>
        /// Xử lý khi có tác động vào ô
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            Codes.AllowedCheckbox(RoomDGV, e);
        }
        /// <summary>
        /// Xử lý sự kiện lọc theo cột để tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbField_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedValue = cbbField.SelectedItem.ToString();
            foreach (var col in colsRoom) {
                if (col.DisplayName == selectedValue) {
                    colFilter = col.Value;
                    break;
                }
            }
        }
        /// <summary>
        /// Xử lý sự kiện khi có giá trị trong 1 ô bị thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra xem sự kiện được kích hoạt bởi checkbox hay không
            if (RoomDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0) {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)RoomDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;

                // Xử lý sự kiện checkbox
                string roomID = RoomDGV["RoomID", e.RowIndex].Value.ToString();
                if (isChecked) {
                    roomIDs.Add(roomID);
                } else {
                    roomIDs.Remove(roomID);
                }

                switch (roomIDs.Count()) {
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
                RoomDGV.Rows.Clear();
                rooms = RoomServices.ListOfRooms();
            }
            bool hasNull = string.IsNullOrEmpty(colFilter) && string.IsNullOrEmpty(txtSearch.Text);
            LoadData(hasNull);
        }



        /// <summary>
        /// Xử lý sự kiện xoá một hoặc nhiều phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            string infor = "";
            for (int i = 0; i < roomIDs.Count; i++) {
                infor += $"\n {i + 1}. {roomIDs[i]} \n";
            }
            DialogResult resultMessage = MessageBox.Show(
                "Bạn có chắc chắn muốn xoá những phòng đã chọn?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultMessage == DialogResult.No) {
                return;
            }
            int isDeleted = StudentServices.DeleteStudent(roomIDs);
            if (isDeleted > 0) {
                MessageBox.Show
                    ($"Những phòng sau sẽ bị xoá: {infor}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LoadData();
            } else {
                MessageBox.Show(
                  "Có lỗi khi xoá phòng!",
                  "Lỗi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }
    }
}
