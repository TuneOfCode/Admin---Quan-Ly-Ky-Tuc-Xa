using ManageDormitory.BusinessLayer;
using PresentationLayer;
using System;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Room {
    public partial class AddRoomForm : Form {
        /// <summary>
        /// Bảng dữ liệu phòng ở
        /// </summary>
        private DataGridView roomDGV;
        /// <summary>
        /// Trường hợp cập nhật thì hiển thị thông tin một phòng ở
        /// </summary>
        private Models.Room room;
        public AddRoomForm(DataGridView roomDGV, Models.Room room = null) {
            InitializeComponent();
            this.roomDGV = roomDGV;
            this.room = room;
            string[] areas = { "A", "B", "C", "D" };
            string[] ranges = { };
            string[] types = { "nam", "nữ" };
            string[] status = { "còn trống", "đã đầy" };
            cbbRoomArea.Items.AddRange(areas);
            for (int i = 0; i < areas.Length; i++) {
                for (int j = 0; j < 5; j++) {
                    Array.Resize(ref ranges, ranges.Length + 1);
                    ranges[ranges.Length - 1] = $"{areas[i]}{j + 1}";
                }
            }
            cbbRoomRange.Items.AddRange(ranges);
            cbbRoomType.Items.AddRange(types);
            cbbRoomStatus.Items.AddRange(status);
            if (room != null) {
                return;
            }
            cbbRoomType.SelectedIndex = cbbRoomStatus.SelectedIndex = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            string[] cols = {
                lbRoomArea.Text,
                lbRoomRange.Text,
                lbRoomID.Text,
                lbRoomType.Text,
                lbRoomQuantity.Text,
                lbRoomPrice.Text,
                lbRoomStatus.Text
            };

            string[] values = {
                cbbRoomArea.Text,
                cbbRoomRange.Text,
                txtRoomID.Text,
                cbbRoomType.Text,
                txtRoomQuantity.Text,
                txtRoomPrice.Text,
                cbbRoomStatus.Text
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError) {
                return;
            }

            // trường hợp chọn khu vực và dãy không hợp lý
            if (!cbbRoomRange.Text.Contains(cbbRoomArea.Text)) {
                MessageBox.Show(
                       $"Dãy phòng {cbbRoomRange.Text} không thuộc khu phòng {cbbRoomArea.Text}",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            // kiểm tra tên phòng có hợp lý hay không
            if (txtRoomID.Text.Length < 5) {
                MessageBox.Show(
                    $"Phòng {txtRoomID.Text} không đúng định dạng",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (!txtRoomID.Text.Contains(cbbRoomRange.Text)) {
                MessageBox.Show(
                       $"Phòng {txtRoomID.Text} không thuộc dãy phòng {cbbRoomRange.Text}",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            // trường hợp cập nhật
            if (room != null) {
                int currentQuantity = StudentServices.Count("Student", "room_id", room.id);
                // kiểm tra loại phòng
                if (cbbRoomType.Text != room.type && currentQuantity > 0) {
                    MessageBox.Show(
                       $"Phòng đang có sinh viên ở nên không thể cập nhật được loại phòng",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                    return;
                }
                // kiểm tra số lượng tối đa
                if (int.Parse(txtRoomQuantity.Text) < currentQuantity) {
                    MessageBox.Show(
                      $"Sinh viên hiện tại đang ở có {currentQuantity} người",
                      "Lỗi",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
                    return;
                }
                int isUpdated = RoomServices.UpdateRoom(values);
                if (isUpdated == 1) {
                    MessageBox.Show(
                    "Cập nhật thông tin sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                    Close();
                } else {
                    MessageBox.Show(
                       "Cập nhật thông tin sinh viên thất bại!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                }
                return;
            }

            // kiểm tra tính chất độc nhất của khu - dãy - phòng
            int isDuplicateRoomID = RoomServices.Count("Room", "id", txtRoomID.Text);
            if (isDuplicateRoomID > 0) {
                MessageBox.Show(
                   $"Vui lòng chọn phòng khác. Phòng {txtRoomID.Text} đã được tạo trước đó",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }

            // thêm phòng ở
            int isCreated = RoomServices.CreateNewRoom(values);
            if (isCreated == 1) {
                MessageBox.Show(
                "Tạo mới thông tin phòng ở thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
                Close();
            } else {
                MessageBox.Show(
                   "Tạo mới thông tin phòng ở thất bại!",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRoomForm_Load(object sender, EventArgs e) {
            if (room == null) {
                txtRoomID.Enabled = true;
                return;
            }

            txtRoomID.Enabled = false;
            txtRoomID.Text = room.id;
            cbbRoomArea.Text = room.area;
            cbbRoomRange.Text = room.range;
            cbbRoomType.Text = room.type;
            txtRoomPrice.Text = room.price.ToString("N2");
            txtRoomQuantity.Text = room.quantity.ToString();
            cbbRoomStatus.Text = room.status;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbRoomRange_SelectedIndexChanged(object sender, EventArgs e) {
            if (room != null) {
                return;
            }
            string selectedvalue = cbbRoomRange.SelectedItem.ToString();
            txtRoomID.Text = selectedvalue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRoomForm_FormClosed(object sender, FormClosedEventArgs e) {
            roomDGV.Rows.Clear();
            RoomServices.LoadDatatable(roomDGV, RoomServices.ListOfRooms());
        }
    }
}
