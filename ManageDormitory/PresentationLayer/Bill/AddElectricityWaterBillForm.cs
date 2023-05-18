using ManageDormitory.BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManageDormitory.PresentationLayer.Bill {
    public partial class AddElectricityWaterBillForm : Form {
        private Models.Room room;
        private IList<Models.Student> students = new List<Models.Student>();
        private string[] studentIDs = { };
        public AddElectricityWaterBillForm(Models.Room room) {
            InitializeComponent();
            this.room = room;
            students = StudentServices.ListOfStudents("Student", "room_id", room.id);
            foreach (var student in students) {
                Array.Resize(ref studentIDs, studentIDs.Length + 1);
                studentIDs[studentIDs.Length - 1] = student.id;
            }
            cbStudentID.Items.AddRange(studentIDs);
            cbStudentID.SelectedIndex = 0;
            txtElecWaterBillName.Text = $"[{room.id}] Hoá đơn tiền điện nước tháng ... năm ...";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e) {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElectricityWaterBillForm_Load(object sender, System.EventArgs e) {
            txtRoomID.Text = room.id;
            txtRoomArea.Text = room.area;
            txtRoomRange.Text = room.range;
            txtRoomType.Text = room.type;
            txtRoomPrice.Text = room.price.ToString("N2");
            txtRoomCurrentQuantity.Text = StudentServices.Count("Student", "room_id", room.id).ToString();
            txtRoomQuantity.Text = room.quantity.ToString();
            txtRoomStatus.Text = room.status;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedValue = cbStudentID.SelectedItem.ToString();
            var student = StudentServices.GetStudent(selectedValue);
            txtStudentName.Text = student.name;
            txtStudentRoomName.Text = student.room_id;
            txtStudentCourse.Text = student.course;
            txtStudentIndustry.Text = student.industry;
            txtStudentSchool.Text = student.school;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            int oldElecIndex = int.Parse(txtElecWaterBillOldElecIndex.Text);
            int newElecIndex = int.Parse(txtElecWaterBillNewElecIndex.Text);
            int oldWaterIndex = int.Parse(txtElecWaterBillOldWaterIndex.Text);
            int newWaterIndex = int.Parse(txtElecWaterBillNewWaterIndex.Text);
            decimal elecAmount = decimal.Parse(txtElecWaterBillElecAmount.Text);
            decimal waterAmount = decimal.Parse(txtElecWaterBillWaterAmount.Text);
            txtElecWaterBillElecTotal.Text =
                (elecAmount * Math.Abs(oldElecIndex - newElecIndex)).ToString();
            txtElecWaterBillWaterTotal.Text =
                (waterAmount * Math.Abs(oldWaterIndex - newWaterIndex)).ToString();
            txtElecWaterBillEnviromentFee.Text = "20000";
            txtElecWaterBillTotal.Text =
                (decimal.Parse(txtElecWaterBillElecTotal.Text)
                + decimal.Parse(txtElecWaterBillWaterTotal.Text)
                + decimal.Parse(txtElecWaterBillEnviromentFee.Text)).ToString();

            string[] cols = {
                lbElecWaterBillName.Text,
                lbElecWaterBillOldElecIndex.Text,
                lbElecWaterBillNewElecIndex.Text,
                lbElecWaterBillElecAmount.Text,
                lbElecWaterBillElecTotal.Text,
                lbElecWaterBillOldWaterIndex.Text,
                lbElecWaterBillNewWaterIndex.Text,
                lbElecWaterBillWaterAmount.Text,
                lblbElecWaterBillWaterTotal.Text,
                lbElecWaterBillNote.Text,
                lbElecWaterBillEnviromentFee.Text,
                lbElecWaterBillTotal.Text,
                "Phòng:"
            };
            string[] values = {
                txtElecWaterBillName.Text,
                txtElecWaterBillOldElecIndex.Text,
                txtElecWaterBillNewElecIndex.Text,
                txtElecWaterBillElecAmount.Text,
                txtElecWaterBillElecTotal.Text,
                txtElecWaterBillOldWaterIndex.Text,
                txtElecWaterBillNewWaterIndex.Text,
                txtElecWaterBillWaterAmount.Text,
                txtElecWaterBillWaterTotal.Text,
                txtElecWaterBillNote.Text,
                txtElecWaterBillEnviromentFee.Text,
                txtElecWaterBillTotal.Text,
                room.id
            };

            // kiểm tra có lỗi đầu vào hay không
            bool hasError = CustomException.ValidateNotEmptyFields(cols, values);
            if (hasError) {
                return;
            }

            // thêm mới hoá đơn điên nước
            int isCreateNewElecWaterBill =
                ElectricityWaterBillServices.CreateNewElectricityWaterBill(values);
            if (isCreateNewElecWaterBill == 1) {
                MessageBox.Show(
                $"Thêm mới hoá đơn điện nước cho phòng {room.id} thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
                Close();
            } else {
                MessageBox.Show(
                   $"Thêm mới hoá đơn điện nước cho phòng {room.id} thất bại!",
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
        private void txtElecWaterBillElecAmount_TextChanged(object sender, EventArgs e) {
            if (txtElecWaterBillElecAmount.Text.Length == 0) {
                txtElecWaterBillElecTotal.Text = "";
            } else {
                int oldElecIndex = int.Parse(txtElecWaterBillOldElecIndex.Text);
                int newElecIndex = int.Parse(txtElecWaterBillNewElecIndex.Text);
                decimal elecAmount = decimal.Parse(txtElecWaterBillElecAmount.Text);
                decimal total = (elecAmount * Math.Abs(oldElecIndex - newElecIndex));
                txtElecWaterBillElecTotal.Text = total.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtElecWaterBillWaterAmount_TextChanged(object sender, EventArgs e) {
            if (txtElecWaterBillWaterAmount.Text.Length == 0) {
                txtElecWaterBillWaterTotal.Text = "";
            } else {
                int oldWaterIndex = int.Parse(txtElecWaterBillOldWaterIndex.Text);
                int newWaterIndex = int.Parse(txtElecWaterBillNewWaterIndex.Text);
                decimal waterAmount = decimal.Parse(txtElecWaterBillWaterAmount.Text);
                decimal total = (waterAmount * Math.Abs(oldWaterIndex - newWaterIndex));
                txtElecWaterBillWaterTotal.Text = total.ToString();
                txtElecWaterBillEnviromentFee.Text = "20000";
                txtElecWaterBillTotal.Text =
                    (decimal.Parse(txtElecWaterBillElecTotal.Text)
                    + decimal.Parse(txtElecWaterBillWaterTotal.Text)
                    + decimal.Parse(txtElecWaterBillEnviromentFee.Text)).ToString();
            }
        }
    }
}
