using ManageDormitory.BusinessLayer;
using ManageDormitory.Models;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Bill
{
    public partial class FormBillFW : Form
    {
        /// <summary>
        /// Bảng dữ liệu sinh viên
        /// </summary>
        private DataGridView studentDGV;
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
        public FormBillFW()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thoát bằng nút x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBillFW_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved || isReadonly)
            {
                return;
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultMessage = MessageBox.Show(
                            MESSAGE_EXIT,
                            "Thông báo",
                            MessageBoxButtons.YesNo);
                if (resultMessage == DialogResult.Yes)
                {
                    Hide();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Sự kiện tạo mới một sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string[] cols = {

                    lbCSDcu.Text,
                    lbCSDmoi.Text,
                    lbCSNcu.Text,
                    lbCSNmoi.Text,
                    lbKWDien.Text,
                    lbNuoctieuthu.Text,
                    lbPhiMT.Text,
                    lbSoPhong.Text,
                    lbTenHD.Text,
                    lbTienDien.Text,
                    lbTienNuoc.Text,
                    lbTongTien.Text,
                    // lbRoomID.Text,
            };

            string[] values = {
                    txtCSDcu.Text,
                    txtCSDmoi.Text,
                    txtCSNcu.Text,
                    txtCSNmoi.Text,
                    txtKWdien.Text,
                    txtNuoctieuthu.Text,
                    txtPhiMT.Text,
                    txtSoPhong.Text,
                    txtTenHD.Text,
                    txtTienDien.Text,
                    txtTienNuoc.Text,
                    txtTongTien.Text,
                    // cbbRoomID.Text,
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError)
            {
                return;
            }
        }
        /// <summary>
        /// Xử lý sự kiện khi đã đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBillFW_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentDGV.Rows.Clear();
            StudentServices.LoadDatatable(studentDGV, StudentServices.ListOfStudents());
        }

        /// Sự kiện huỷ bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show(
                                MESSAGE_EXIT,
                                "Thông báo",
                                MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes)
            {
                Hide();
            }
        }

        /// <summary>
        /// Xử lý khi form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormBillFW_Load(object sender, EventArgs e)
        {
            isSaved = false;
            if (student == null)
            {
                txtStudentID.Enabled = true;
                return;
            }
            txtStudentID.Enabled = false;
            pbStudentAvatar.ImageLocation = student.avatar;
            txtStudentID.Text = student.id;
            txtStudentName.Text = student.name;
            if (!student.gender)
            {
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
        }
        
    }
    
}
