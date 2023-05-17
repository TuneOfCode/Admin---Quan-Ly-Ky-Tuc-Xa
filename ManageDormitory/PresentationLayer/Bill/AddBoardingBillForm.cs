using ManageDormitory.BusinessLayer;
using PresentationLayer;
using System;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Bill {
    public partial class AddBoardingBillForm : Form {
        /// <summary>
        /// 
        /// </summary>
        private string studentID;
        public AddBoardingBillForm(string studentID) {
            InitializeComponent();
            this.studentID = studentID;
            txtStudentID.Enabled
                = txtStudentName.Enabled
                = txtStudentRoomName.Enabled
                = txtStudentSchool.Enabled
                = txtStudentIndustry.Enabled
                = txtStudentCourse.Enabled
                = false;
            txtBoardingBillName.Text = $"[{studentID}] Hoá đơn nội trú tháng ... năm ...";
            txtBoardingBillTotal.Text = $"300000";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBoardingBillForm_Load(object sender, EventArgs e) {
            Models.Student student = StudentServices.GetStudent(studentID);
            txtStudentID.Text = student.id;
            txtStudentName.Text = student.name;
            txtStudentRoomName.Text = student.room_id;
            txtStudentSchool.Text = student.school;
            txtStudentIndustry.Text = student.industry;
            txtStudentCourse.Text = student.course;
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
                lbBoardingBillName.Text,
                "Ngày lập:",
                lbBoardingBillTotal.Text,
                lbStudentID.Text,
                lbBoardingBillNote.Text
            };
            string[] values = {
                txtBoardingBillName.Text,
                DateTime.Now.Date.ToString(),
                txtBoardingBillTotal.Text,
                txtStudentID.Text,
                txtBoardingBillNote.Text
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError) {
                return;
            }

            // thêm mới hoá đơn nội trú
            int isCreateNewBoardingBill = BoardingBillServices.CreateNewBoardingBill(values);
            if (isCreateNewBoardingBill == 1) {
                MessageBox.Show(
                $"Thêm mới hoá đơn nội trú cho sinh viên {txtStudentName.Text} thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
                Close();
            } else {
                MessageBox.Show(
                   $"Thêm mới hoá đơn nội trú cho sinh viên {txtStudentName.Text} thất bại!",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
    }
}
