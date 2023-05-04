using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiKetThucHocPhan
{
    public partial class FormSinhvien : Form
    {
        public FormSinhvien()
        {
            InitializeComponent();
        }
        private DataTable GetTestData()
        {
            DataTable tab = new DataTable();
            DataColumn c1 = new DataColumn("col1");
            DataColumn c2 = new DataColumn("col2");
            tab.Columns.AddRange(new DataColumn[] { c1, c2 });
            DataRow r1 = tab.NewRow(); r1[c1] = "cell 1"; r1[c2] = "cell 2";
            DataRow r2 = tab.NewRow(); r2[c1] = "cell 3"; r2[c2] = "cell 4";
            tab.Rows.Add(r1);
            tab.Rows.Add(r2);

            return tab;
        }

        private void AddContextMenu(DataGridView dgv)
        {
            var strip = new ContextMenuStrip();
            var menu1 = strip.Items.Add("Chọn tất cả");
            var menu2 = strip.Items.Add("Tạo hóa đơn mới");

            menu1.Click += new EventHandler(menu1_Click);
            menu2.Click += new EventHandler(menu2_Click);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.ContextMenuStrip = strip;
            }
        }

        DataGridViewCellEventArgs mouseLocation;
        void AddMouseEnterEvent()
        {
            dataGridView1.CellMouseEnter += (s, e) => { mouseLocation = e; };
        }

        void menu2_Click(object sender, EventArgs e)
        {
            //var cell = dataGridView1.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            //// do something stupid
            //cell.Style.BackColor = Color.Red;
            MessageBox.Show("Tạo hóa đơn cho sinh viên này");
        }

        void menu1_Click(object sender, EventArgs e)
        {
            // var cell = dataGridView1.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex];
            // do something even more stupid
            // cell.Style.BackColor = Color.Blue;
            MessageBox.Show("Chọn tất cả");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // sự kiện chuột phải
            if (e.Button == MouseButtons.Right)
            {
                AddContextMenu(dataGridView1);
            }
        }
    }
}
