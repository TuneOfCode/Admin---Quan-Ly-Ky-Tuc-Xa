using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ManageDormitory {
    public static class Codes {
        private static readonly string STT_COLUMN = "STT";
        /// <summary>
        /// Đọc dữ liệu từ datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ReadDataTable<T>(this IList<T> data) {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++) {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(
            prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data) {
                for (int i = 0; i < values.Length; i++) {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            table.Columns.Add(STT_COLUMN);
            for (int i = 0; i < table.Rows.Count; i++) {
                table.Rows[i][STT_COLUMN] = (i + 1).ToString();
            }
            return table;
        }
        /// <summary>
        /// Thêm danh sách bảng chọn khi bấm chuột phải vào 1 dòng
        /// </summary>
        /// <param name="dgv"></param>
        public static void AddContextMenu(DataGridView dgv) {
            ContextMenuStrip strip = new ContextMenuStrip();
            ToolStripItem checkAll = strip.Items.Add("Chọn tất cả");
            ToolStripItem getDetail = strip.Items.Add("Xem chi tiết");
            ToolStripItem createNewBill = strip.Items.Add("Tạo hóa đơn mới");

            checkAll.Click += new EventHandler(checkAll_Click);
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
        private static void checkAll_Click(object sender, EventArgs e) {
            // var cell = dgv.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // do something even more stupid
            // cell.Style.BackColor = Color.Blue;
            MessageBox.Show("Chọn tất cả");
        }
        /// <summary>
        /// Sự kiện xem chi tiết một bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void getDetail_Click(object sender, EventArgs e) {
            // var cell = dgv.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // do something even more stupid
            // cell.Style.BackColor = Color.Blue;
            MessageBox.Show("Chọn tất cả");
        }
        /// <summary>
        /// Sự kiến tạo một hoá đơn mới cho một sinh viên được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void createNewBill_Click(object sender, EventArgs e) {
            //var cell = dgv.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            //// do something stupid
            //cell.Style.BackColor = Color.Red;
            MessageBox.Show("Tạo hóa đơn cho sinh viên này");
        }
        /// <summary>
        /// Cho phép checkbox
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        public static void AllowedCheckbox(DataGridView dgv, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) {
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null
                        ? true
                        : (!(bool)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
            }
        }
        /// <summary>
        /// Hàm chuyển đổi từ kiểu chuỗi sang kiểu ngày tháng năm
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? DMYStingToDateTime(string s, string format = "d/M/yyyy") {
            try {
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            } catch {
                return null;
            }
        }
        /// <summary>
        /// Hàm chuyển đổi từ kiểu chuỗi sang int
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static int? ConvertStingToInt(string s) {
            try {
                return int.Parse(s);
            } catch {
                return null;
            }
        }
        /// <summary>
        /// Xuất ra file excel
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="fileName"></param>
        /// <param name="worksheetName"></param>
        public static void ExportExcel(DataGridView dgv, string fileName, string worksheetName) {
            // Định dạng tên file
            long currentMilliseconds = DateTime.Now.Ticks;
            string fileNameFormat = $"{currentMilliseconds}_{fileName}";
            // tạo SaveFileDialog để lưu file excel
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            dialog.FileName = fileNameFormat;

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK) {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath)) {
                MessageBox.Show(
                    "Đường dẫn báo cáo không hợp lệ",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                //excel.Visible = false;
                //excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = worksheetName;

                // export header trong DataGridView
                for (int i = 0; i < dgv.ColumnCount; i++) {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                    worksheet.Rows.AutoFit();
                    worksheet.Columns.AutoFit();
                }
                if (dgv.RowCount == 0) {
                    MessageBox.Show(
                        "Không có dữ liệu để xuất file",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dgv.RowCount; i++) {
                    for (int j = 0; j < dgv.ColumnCount; j++) {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        worksheet.Rows.AutoFit();
                        worksheet.Columns.AutoFit();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(filePath);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show(
                    "Xuất dữ liệu ra Excel thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            } catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } finally {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
