using ManageDormitory.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Bill {
    public partial class MainElectricityWaterBillForm : Form {
        /// <summary>
        /// Giá trị của hoá đơn lấy từ database
        /// </summary>
        private IList<Models.ElectricityWaterBill> electricityWaterBills;
        /// <summary>
        /// Danh sách phòng ở khi được checkbox
        /// </summary>
        List<string> electricityWaterBillIDs;
        /// <summary>
        /// Lấy hoá đơn theo mã phòng
        /// </summary>
        private string roomID;
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
        public MainElectricityWaterBillForm(string roomID = "") {
            InitializeComponent();
            btnAccept.Enabled = false;
            electricityWaterBills = new List<Models.ElectricityWaterBill>();
            this.roomID = roomID;
        }
        /// <summary>
        /// Tải lại toàn bộ dữ liệu
        /// </summary>
        /// <param name="hasNull"></param>
        private void LoadData(bool hasNull = true, string selectedValue = "Xem tất cả") {
            electricityWaterBillIDs = new List<string>();
            ElectricityWaterBillDGV.Rows.Clear();

            if ((!string.IsNullOrEmpty(roomID)
            && string.IsNullOrEmpty(txtSearch.Text)
                && selectedValue == "Xem tất cả")) {
                electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills(
                    "ElectricityWaterBill",
                    "room_id",
                    roomID
                 );
                ElectricityWaterBillServices.LoadDatatable(ElectricityWaterBillDGV, electricityWaterBills);
                btnAccept.Enabled = false;
                return;
            }
            if (string.IsNullOrEmpty(txtSearch.Text)
                        && selectedValue == "Xem tất cả") {
                electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills();
                ElectricityWaterBillServices.LoadDatatable(ElectricityWaterBillDGV, electricityWaterBills);
                btnAccept.Enabled = false;
                return;
            }
            if (!string.IsNullOrEmpty(txtSearch.Text) && selectedValue == "Xem tất cả") {
                electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills(
                    hasNull ? null : "BoardingBill",
                    hasNull ? null : colFilter,
                    hasNull ? null : txtSearch.Text
                );
                ElectricityWaterBillServices.LoadDatatable(ElectricityWaterBillDGV, electricityWaterBills);
                btnAccept.Enabled = false;
                return;
            }
            electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills(
                    "ElectricityWaterBill",
                    "status",
                    selectedValue
            );
            ElectricityWaterBillServices.LoadDatatable(ElectricityWaterBillDGV, electricityWaterBills);
            btnAccept.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainElectricityWaterBillForm_Load(object sender, System.EventArgs e) {
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
            foreach (DataGridViewRow row in ElectricityWaterBillDGV.Rows) {
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
            foreach (DataGridViewRow row in ElectricityWaterBillDGV.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CBBoardingBill"];
                chk.Value = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElectricityWaterBillDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            Codes.AllowedCheckbox(ElectricityWaterBillDGV, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElectricityWaterBillDGV_MouseClick(object sender, MouseEventArgs e) {
            // sự kiện chuột phải
            if (e.Button == MouseButtons.Right) {
                AddContextMenu(ElectricityWaterBillDGV);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElectricityWaterBillDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra xem sự kiện được kích hoạt bởi checkbox hay không
            if (ElectricityWaterBillDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0) {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)ElectricityWaterBillDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;

                // Xử lý sự kiện checkbox
                string boardingBillID = ElectricityWaterBillDGV["ElecWaterBillID", e.RowIndex].Value.ToString();
                if (isChecked) {
                    electricityWaterBillIDs.Add(boardingBillID);
                } else {
                    electricityWaterBillIDs.Remove(boardingBillID);
                }

                switch (electricityWaterBillIDs.Count()) {
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
                ElectricityWaterBillDGV.Rows.Clear();
                electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills();
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
                ElectricityWaterBillDGV.Rows.Clear();
                electricityWaterBills = ElectricityWaterBillServices.ListOfElectricityWaterBills();
                ElectricityWaterBillServices.LoadDatatable(ElectricityWaterBillDGV, electricityWaterBills);
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
            for (int i = 0; i < electricityWaterBillIDs.Count; i++) {
                infor += $"\n {i + 1}. {electricityWaterBillIDs[i]} \n";
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
            for (int i = 0; i < electricityWaterBillIDs.Count; i++) {
                var elecWaterBill = ElectricityWaterBillServices.GetElectricityWaterBill(
                    null,
                    "ElectricityWaterBill",
                    "id",
                    electricityWaterBillIDs[i]
                );
                elecWaterBill.status = "Đã thanh toán";
                elecWaterBill.payment_date = DateTime.Now;
                isAcceptPayment = ElectricityWaterBillServices.UpdateElectricityWaterBill(elecWaterBill);
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
                  "Có một vài hoá đơn đã được thanh toán trước đó!",
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
        private void btnExportExcel_Click(object sender, EventArgs e) {
            string fileName = "Quản lý hoá đơn tiền điện";
            string workSheetName = "Quản lý hoá đơn tiền điện";
            Codes.ExportExcel(ElectricityWaterBillDGV, fileName, workSheetName);
        }
    }
}
