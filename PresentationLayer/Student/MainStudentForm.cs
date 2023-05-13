using System;
using System.Windows.Forms;

namespace PresentationLayer.Student {
    public partial class MainStudentForm : Form {
        public MainStudentForm() {
            InitializeComponent();
            StudentDGV.Rows.Add(false, 1, "20T1080009", "Trần Thanh Tú", "nam", "22/08/2002",
                "", "Đại học khoa học -Đại học Huế", "12/05/2023");
            StudentDGV.Rows.Add(false, 2, "20F7511329", "Hoàng Thị Ngọc Yến", "nữ", "18/01/2001",
                "", "Đại học ngoại ngữ - Đại học Huế", "12/05/2023");
        }

        private void AddContextMenu(DataGridView dgv) {
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
        void checkAll_Click(object sender, EventArgs e) {
            // var cell = dataGridView1.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // do something even more stupid
            // cell.Style.BackColor = Color.Blue;
            MessageBox.Show("Chọn tất cả");
        }
        /// <summary>
        /// Sự kiện xem chi tiết một bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void getDetail_Click(object sender, EventArgs e) {
            // var cell = dataGridView1.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // do something even more stupid
            // cell.Style.BackColor = Color.Blue;
            MessageBox.Show("Chọn tất cả");
        }
        /// <summary>
        /// Sự kiến tạo một hoá đơn mới cho một sinh viên được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void createNewBill_Click(object sender, EventArgs e) {
            //var cell = dataGridView1.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            //// do something stupid
            //cell.Style.BackColor = Color.Red;
            MessageBox.Show("Tạo hóa đơn cho sinh viên này");
        }

        /// <summary>
        /// Mở form thêm sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e) {
            new AddStudentForm().Show();
        }

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
            if (e.ColumnIndex == 0) {
                StudentDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    (StudentDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null
                        ? true
                        : (!(bool)StudentDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
            }
        }
    }
}
